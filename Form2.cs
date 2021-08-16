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
            metroProgressBarCPU.Hide();
            metroProgressBarRAM.Hide();
            metroLabelCPU.Hide();
            metroLabelRAM.Hide();
            chart1.Hide();
            //Design do botão "Scan Internet"
            metroTile2.Location = new Point(24,211);
            metroTile2.Size = new Size(347,130);
            metroTextIP.Hide();
            cmdScan.Hide();
            textHosts.Hide();
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

        //Se clicar em "Scan Internet", faça:
        public void metroTile2_Click(object sender, EventArgs e)
        {
            
            metroTile2.Size = new Size(357, 247);
            metroTile2.Location = new Point(21,91);
            metroCPU.Hide();
            metroTextBox2.Show();
            metroTextBox2.Location = new Point(293, 123);
            metroTextIP.Show();
            cmdScan.Show();
            textHosts.Show();

        }

        
        //aqui não tá funfando direito
        public void scanNet(string internet)
        {
            Ping myPing;
            PingReply reply;
            IPAddress addr;
            IPHostEntry host;

            for(int i = 1; i<255; i++)
            {
                string internetn = "." + i.ToString();
                myPing = new Ping();
                reply = myPing.Send(internet + internetn);

                if (reply.Status == IPStatus.Success)
                {
                    textHosts.Text = internet + internetn;
                    try
                    {
                        addr = IPAddress.Parse(internet + internetn);
                        host = Dns.GetHostEntry(addr);

                        textHosts.AppendText(internet + internetn + host.HostName.ToString() + "up");
                    }
                    catch
                    {
                        
                    }
                }
                else
                {
                    
                    textHosts.Text = internetn ;
                }

            }
            

        }

        private void cmdScan_Click(object sender, EventArgs e)
        {
            myThread = new Thread(() => scanNet(metroTextIP.Text));
            myThread.Start();

            if (myThread.IsAlive)
            {
                metroTextBox2.Enabled = true;
                cmdScan.Enabled = false;
                metroTextIP.Enabled = false;
            }
        }

        //Se botão "Voltar Scan Internet" for clicado, faça:
        private void metroTextBox2_Click(object sender, EventArgs e)
        {

            
            if (myThread == null)
            {
                
                
                metroTile2.Size = new Size(347, 131);
                metroTile2.Location = new Point(23, 206);
                metroCPU.Show();
                metroTextBox2.Hide();

                metroTile2.Location = new Point(24, 211);
                metroTile2.Size = new Size(347, 130);
                metroTextIP.Hide();
                cmdScan.Hide();
                textHosts.Hide();
            }
            if (myThread != null)
            {

                myThread.Abort();

                metroTile2.Size = new Size(347, 131);
                metroTile2.Location = new Point(23, 206);
                metroCPU.Show();
                metroTextBox2.Hide();

                metroTile2.Location = new Point(24, 211);
                metroTile2.Size = new Size(347, 130);
                metroTextIP.Hide();
                cmdScan.Hide();
                textHosts.Hide();
            }

        }


    }
}
