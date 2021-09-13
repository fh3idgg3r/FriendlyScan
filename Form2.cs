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

namespace FriendlyScan
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        //Quando formulario for iniciado, faça:
        public Form2()
        {
            InitializeComponent();
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
            metroTile2.Location = new Point(24,211);
            metroTile2.Size = new Size(347,130);
        }
        //Declarando varial myThread
        Thread myThread = null;

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
            metroTextBox1.Location = new Point(300,308);
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
            url = Convert.ToByte(data);
            return (data.Length * 8) / (dt2 - dt1).TotalSeconds;
            
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
                metroConexao.Text = "Detectamos acesso a internet";
                metroConexao.ForeColor = Color.DarkGreen;
            }
            else
            {
                metroConexao.Text = "Você não possui acesso a internet";
                metroConexao.ForeColor = Color.Red;
            }

            metroSpeed.Text = "Sua banda larga é de:" + (Speed("https://www.google.com/")/1024) * 0.0009765625 + " mb/s";
        }
    }
}
