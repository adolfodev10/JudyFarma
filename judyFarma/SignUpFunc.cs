using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace judyFarma
{
    public partial class SignUpFunc : Form
    {
        public SignUpFunc()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtEmail.Text == "" && txtTelefone.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha Tudo!");
            }
            else if(txtNome.Text == "")
            {
                MessageBox.Show("Coloque o Nome!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Coloque o Email!");
            }
            else if(txtTelefone.Text == "")
            {
                MessageBox.Show("Coloque o Telefone!");

            }
            else if(txtSenha.Text == "")
            {
                MessageBox.Show("Coloque a Senha!");
            }
            else
            {
                bd b = new bd();
                b.CadastrarFuncionarios(txtNome.Text, txtEmail.Text, int.Parse(txtTelefone.Text), txtSenha.Text);
                Limpar();
            }
        }
        private void Limpar()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtSenha.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginFunc l = new LoginFunc();
            this.Hide();
            l.ShowDialog();
        }

        private void labelAccount_Click(object sender, EventArgs e)
        {
            LoginFunc l = new LoginFunc();
            this.Hide();
            l.ShowDialog();
        }
    }
}
