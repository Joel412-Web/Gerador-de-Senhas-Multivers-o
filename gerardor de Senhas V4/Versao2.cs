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
    public partial class Versao2 : Form
    {
        public Versao2()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int nChars;
            if (int.TryParse(Nchars.Text, out nChars) && nChars > 0)
            {
                string senha = GerarSenha(nChars);
                txtSenha.Text = senha;
            }
            else
            {
                MessageBox.Show("Por favor, insira um comprimento válido.");
            }
        }

        private string GerarSenha(int comprimento)
        {
            const string maiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string minusculas = "abcdefghijklmnopqrstuvwxyz";
            const string numeros = "0123456789";
            const string simbolos = "!@#$%^&*()_+-=[]{}|;:',.<>?";

            StringBuilder caracteres = new StringBuilder();

            if (chkMaiusculas.Checked)
                caracteres.Append(maiusculas);

            if (chkMinusculas.Checked)
                caracteres.Append(minusculas);

            if (ChkNumeros.Checked)
                caracteres.Append(numeros);

            if (chkSimbolos.Checked)
                caracteres.Append(simbolos);

            if (caracteres.Length == 0)
                throw new InvalidOperationException("Nenhum conjunto de caracteres selecionado.");

            Random random = new Random();
            StringBuilder senha = new StringBuilder(comprimento);

            for (int i = 0; i < comprimento; i++)
            {
                int indice = random.Next(caracteres.Length);
                senha.Append(caracteres[indice]);
            }

            return senha.ToString();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Senhas.Items.Add(txtSenha.Text);
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            // Verifica se há itens na ListBox
            if (Senhas.Items.Count > 0)
            {
                // Concatena todas as senhas em uma única string, separadas por quebras de linha
                var senhas = Senhas.Items.Cast<string>();
                string senhasConcatenadas = string.Join(Environment.NewLine, senhas);

                // Copia a string concatenada para a área de transferência
                Clipboard.SetText(senhasConcatenadas);

                // Opcional: Exibe uma mensagem de confirmação
                MessageBox.Show("Todas as senhas foram copiadas para a área de transferência.");
            }
            else
            {
                // Opcional: Exibe uma mensagem de erro se a ListBox estiver vazia
                MessageBox.Show("Não há senhas para copiar.");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            Nchars.Value=0;
            chkMaiusculas.Checked = false;
            chkMinusculas.Checked = false;
            ChkNumeros.Checked = false;
            chkSimbolos.Checked = false;
            Senhas.Items.Clear();
            MessageBox.Show("Seus Valores Foram Limpos Com Sucesso","Valores",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
