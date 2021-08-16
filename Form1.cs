using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FriendlyScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Ao Iniciar esconde os seguintes componentes:
            InitializeComponent();

            
            

            textMD5.Hide();
            button4.Hide();
            button5.Hide();
            label2.Hide();
            label3.Hide();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Quando Botão Verificar Arquivo for acionado:
            button2.Hide();
            button4.Show();
            
            textMD5.Show();
            button5.Show();
            label2.Show();
            label3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        // Responsavel por gerar o hash
        public string GetMD5FromFile(string filenPath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filenPath))
                {
                    
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }
        
        // Verifica se o hash encontrado bate com algum da base de dados
        private void button4_Click(object sender, EventArgs e)
        {
            var md5hashes = File.ReadLines("MD5Base.txt");
            if (md5hashes.Contains(textMD5.Text))
            {
                // Se bater é vírus
                label3.Text = "Arquivo Infectado!";
                label3.ForeColor = Color.Red;
            }

            else
            {
                label3.Text = "Arquivo Limpo!";
                label3.ForeColor = Color.Green;
            }
                
        }
        // Responsável por selecionar o arquivo para ser analisado
        private void button5_Click(object sender, EventArgs e)
        {

            
            OpenFileDialog ofd = new OpenFileDialog();
         ofd.Filter = "Textfiles | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                textMD5.Text = (GetMD5FromFile(ofd.FileName));
                
                
            }
            
        }

        //Se botão 1 pressionado, então abra novo formulario
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Chama = new Form2();
            Chama.ShowDialog();
            
  
        }
    }
}
