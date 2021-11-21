using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Runtime.InteropServices;
using System.Management.Automation.Runspaces;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace FriendlyScan
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int RigthRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeigthEllipse
            );
        //Quando formulario for iniciado, faça:
        public Form2()
        {
            InitializeComponent();
            LabelPowerShell.Clear();
            LabelPowerShell.Text = RunScript(comandosPower[0]) + RunScript(comandosPower[1]);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            progressBar1.Value = 0;
            metroTextBox3.Hide();
            //Confere se possue códigos rodando em segundo plano
            Control.CheckForIllegalCrossThreadCalls = false;
            //Design do botão "CPU e RAM"
            metroCPU.Size = new Size(146, 112);
            metroTile2.Show();
            metroTextBox1.Hide();
            metroTextBox2.Hide();
            metroLabel1.Hide();
            metroLabel2.Hide();
            metroSpeed.Hide();
            metroProgressBarCPU.Hide();
            metroProgressBarRAM.Hide();
            metroLabelCPU.Hide();
            metroLabelRAM.Hide();
            metroConexao.Hide();
            chart1.Hide();
            //Design do botão "Scan Internet"
            metroTile2.Location = new Point(24, 211);
            metroTile2.Size = new Size(347, 130);
        }
        //Método responsável por inicial os comandos PowerShell
        private string RunScript(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            pipeline.Commands.Add("Out-String");
            Collection<PSObject> results = pipeline.Invoke();
            runspace.Close();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject pSObject in results)
                stringBuilder.AppendLine(pSObject.ToString());
            return stringBuilder.ToString();
        }
        //Declarando varial myThread
        Thread myThread = null;


        //variavel que contem os comandos powerShell
        public string[] comandosPower = { "Get-NetTCPConnection -State Listen | Select-Object -Property LocalPort, State | Sort-Object LocalPort", "$INSTALLED | ?{ $_.DisplayName -ne $null } | sort-object -Property DisplayName -Unique | Format-Table -AutoSize" };


        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        //Se clicar em "CPU e RAM", faça:
        private void metroCPU_Click(object sender, EventArgs e)
        {
            timer1.Start();
            metroCPU.Size = new Size(370,250);
            metroTile2.Hide();
            metroTextBox1.Show();
            metroTextBox1.Location = new Point(305,308);
            metroLabel1.Show();
            metroLabel2.Show();
            metroProgressBarCPU.Show();
            metroProgressBarRAM.Show();
            metroLabelCPU.Show();
            metroLabelRAM.Show();
            chart1.Show();
        }

        //Se clicar em botão "Voltar CPU e RAM", faça:
        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroCPU.Size = new Size(146, 112);
            metroTile2.Show();
            metroTextBox1.Hide();
            metroTextBox1.Hide();
            metroLabel1.Hide();
            metroLabel2.Hide();
            metroProgressBarCPU.Hide();
            metroProgressBarRAM.Hide();
            metroLabelCPU.Hide();
            metroLabelRAM.Hide();
            chart1.Hide();
            timer1.Stop();
        }

        //método para o funcionamento do monitoramento da CPU e RAM
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            float cpu = CPU.NextValue();
            float ram = RAM.NextValue();
            metroProgressBarCPU.Value = (int)cpu;
            metroProgressBarRAM.Value = (int)ram;
            metroLabelCPU.Text = string.Format("{0:0.00}%", cpu);
            metroLabelRAM.Text = string.Format("{0:0.00}%", ram);
            chart1.Series["CPU"].Points.AddY(cpu);
            chart1.Series["RAM"].Points.AddY(ram);

           
        }

        //Se clicar em "Banda Larga Internet", faça:
        public void metroTile2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            metroTile2.Size = new Size(357, 247);
            metroTile2.Location = new Point(21,91);
            metroCPU.Hide();
            metroTextBox2.Show();
            metroTextBox2.Location = new Point(273, 302);
            metroConexao.Show();
            metroSpeed.Show();

        }       
        /* Método responsável por fazer a requisição com o servidor
           fazendo com que seja possivel calcular a velocidade de download*/
        public static double Speed(string url)
        {
            
            WebClient wc = new WebClient();
            DateTime dt1 = DateTime.Now;
            Byte[] data = wc.DownloadData("https://www.google.com/");
            DateTime dt2 = DateTime.Now;
            double velNet = (data.Length * 8) / (dt2 - dt1).TotalSeconds;
            return Math.Round(velNet);
            
        }

        //Se botão "Voltar Banda Larga Internet" for clicado, faça:
        private void metroTextBox2_Click(object sender, EventArgs e)
        {
                
                metroTile2.Size = new Size(347, 131);
                metroTile2.Location = new Point(23, 206);
                metroCPU.Show();
                metroTextBox2.Hide();
                metroConexao.Hide();
                metroSpeed.Hide();
                timer2.Stop();
                metroTile2.Location = new Point(24, 211);
                metroTile2.Size = new Size(347, 130);
           

        }
        /* Assim que botão " Banda Larga Internet for clicado
           Aciona essa função que é responsavel por verificar a 
           conexão da internet*/
        private void timer2_Tick(object sender, EventArgs e)
        {
            bool conexao = NetworkInterface.GetIsNetworkAvailable();
            if (conexao == true)
            {
                metroConexao.Text = "Você possui acesso a internet!";
                metroConexao.ForeColor = Color.Green;
            }
            else
            {
                metroConexao.Text = "Você não possui acesso a internet!";
                metroConexao.ForeColor = Color.Red;
            }

            double velNet2 = Speed("https://www.google.com/");
            velNet2 = ((int)velNet2);

            metroSpeed.Text = "Sua velocidade de download é de:" + (velNet2/1024) * 0.0009765625 + " mb/s";
        }

       

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            progressBar1.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                timer3.Enabled = false;
                metroTextBox3.Show();
               
            }
        }

        public void metroTextBox3_Click(object sender, EventArgs e)
        {
            Form3 relatorioform = new Form3();
            relatorioform.Show();
            this.Hide();
        }


    }
}
