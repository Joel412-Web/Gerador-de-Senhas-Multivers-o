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
    public partial class frCapa : Form
    {
        public frCapa()
        {
            InitializeComponent();
        }

        private void BtnVersão1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Versao1 f = new Versao1();
            f.ShowDialog();
            this.Show();
        }

        private void BtnVersão2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Versao2 f = new Versao2();
            f.ShowDialog();
            this.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
        private void Sair()
        {
            if (MessageBox.Show("Deseja sair Do Programa?","SAIR",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No) return;
            Application.Exit();
        }

        private void BtnAutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor:Joel António Gonçalves Tigeleiro\n"+"Idade:32\n"+"Pais:Portugal\n","AUTOR",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
