using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerardor_de_Senhas_V4
{
    public partial class Versao1 : Form
    {
        public Versao1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            // Verifica se o número de caracteres é um valor válido
            if (!int.TryParse(NChars.Text, out int numChars) || numChars <= 0)
            {
                MessageBox.Show("Por favor, insira um número válido de caracteres.");
                return;
            }

            // Define os conjuntos de caracteres possíveis
            string caracteres = "";
            if (chkMaiusculas.Checked)
                caracteres += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (chkMinusculas.Checked)
                caracteres += "abcdefghijklmnopqrstuvwxyz";
            if (chkNumeros.Checked)
                caracteres += "0123456789";
            if (chkSimbolos.Checked)
                caracteres += "!@#$%^&*()_+-=[]{}|;:,.<>?";

            // Verifica se pelo menos uma opção de caracteres foi selecionada
            if (string.IsNullOrEmpty(caracteres))
            {
                MessageBox.Show("Selecione pelo menos um tipo de caractere.");
                return;
            }

            // Gera a senha
            StringBuilder senha = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < numChars; i++)
            {
                int indice = rand.Next(caracteres.Length);
                senha.Append(caracteres[indice]);
            }

            // Exibe a senha gerada
            txtSenha.Text = senha.ToString();
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSenha.Text))
            {
                Clipboard.SetText(txtSenha.Text);
                MessageBox.Show("Senha copiada para a área de transferência.");
            }
            else
            {
                MessageBox.Show("Nenhuma senha para copiar.");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            NChars.Value = 0;
            chkMaiusculas.Checked = false;
            chkMinusculas.Checked = false;
            chkNumeros.Checked = false;
            chkSimbolos.Checked = false;
            MessageBox.Show("Seus Valores Limpos Com sucesso","Valores",
                MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
