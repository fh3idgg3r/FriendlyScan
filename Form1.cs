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
using System.Text.RegularExpressions;

namespace FriendlyScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Ao Iniciar esconde os seguintes componentes:
            InitializeComponent();

            
            

            textMD5.Hide();
            txtSenha.Hide();
            button4.Hide();
            button5.Hide();
            buttonSenha.Hide();
            label2.Hide();
            label3.Hide();
            labelS.Hide();
            labelsenha.Hide();
            button6.Show();
            button1.Show();
            button2.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Quando Botão Verificar Arquivo for acionado:
            button2.Hide();
            labelsenha.Hide();
            labelS.Hide();
            buttonSenha.Hide();
            txtSenha.Hide();
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
         ofd.Filter = "Textfiles | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                textMD5.Text = (GetMD5FromFile(ofd.FileName));
                
                
            }
            
        }

        //Se botão 1 pressionado, então abra novo formulario
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Chama = new Form2();
            Chama.Show();
            this.Hide();
  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textMD5.Hide();
            label2.Hide();
            label3.Hide();
            button5.Hide();
            buttonSenha.Show();
            labelsenha.Show();
            labelS.Show();
            button2.Show();
            button6.Show();
            txtSenha.Show();
        }

        public enum ForcaDaSenha
        {
            Inaceitavel,
            Fraca,
            Aceitavel,
            Forte,
            Segura
        }

        /*
    GetPontoPorTamanho -Seis pontos serão atribuídos para cada caractere na senha, até um máximo de sessenta pontos.
    GetPontoPorMinusculas - Cinco pontos serão concedidos se a senha inclui uma letra minúscula. Dez pontos serão atribuídos se mais de uma letra minúscula estiver presente.
    GetPontoPorMaiusculas - Cinco pontos serão concedidos se a senha incluir uma letra maiúscula. Dez pontos serão atribuídos se mais de uma letra maiúscula estiver presente.
    GetPontoPorDigitos - Cinco pontos serão concedidos se a senha incluir um dígito numérico. Dez pontos serão atribuídos se mais de um dígito numérico estiver presente.
    GetPontoPorSimbolos - Cinco pontos serão concedidos se a senha incluir qualquer caractere diferente de uma letra ou um dígito. Isto inclui símbolos e espaços em branco. Dez pontos serão concedidos se houver dois ou mais de tais caracteres.
    GetPontoPorRepeticao - Se houver caracteres repetidos na senha será atribuido 30 pontos que será subtraida da fórmula do cálculo do total dos pontos;
        */

        public int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 7;
        }

        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 6;
        }

        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorRepeticao(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }


        public ForcaDaSenha GetForcaDaSenha(string senha)
        {
            int placar = geraPontosSenha(senha);

            if (placar < 50)
                return ForcaDaSenha.Inaceitavel;
            else if (placar < 60)
                return ForcaDaSenha.Fraca;
            else if (placar < 80)
                return ForcaDaSenha.Aceitavel;
            else if (placar < 100)
                return ForcaDaSenha.Forte;
            else
                return ForcaDaSenha.Segura;
        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != string.Empty)
            {
                int placar;
                ForcaDaSenha forca;

                placar = geraPontosSenha(txtSenha.Text);
                forca = GetForcaDaSenha(txtSenha.Text);

                labelS.Text = "Status:" + forca.ToString();
            }
        }
    }
}
