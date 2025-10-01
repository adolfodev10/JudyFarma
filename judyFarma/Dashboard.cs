using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace judyFarma
{
    public partial class Dashboard : Form
    {

        public Dashboard(string texto)
        {
            InitializeComponent();
            funcionario.Text = texto;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            altText.Text = "Dados estatísticos";
            panelDashboard.Show();
            panelAdmin.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelDashboard.Show();
            panelAdmin.Visible = false;
            altText.Text = "Dados estatísticos";
            Menu.Width = 45;
            }

        private void Menu_MouseHover(object sender, EventArgs e)
        {
            Menu.Width = 120;
            sepadorMenu.Width = 110;
            label1.Text = "Farmácia Judy Farma";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            DashSeparador.Width = 450;
            DashSeparador.Left = 130;

        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Menu.Width = 45;
            sepadorMenu.Width = 45;
            label1.Text = "Judy\n Farma";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            DashSeparador.Width = 500;
            DashSeparador.Left = 50;
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            Menu.Width = 120;
            sepadorMenu.Width = 110;
            label1.Text = "Farmácia Judy Farma";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            DashSeparador.Width = 450;
            DashSeparador.Left = 130;
            panelDashboard.Left = 130;
            panelDashboard.Width = 450;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoginFunc l = new LoginFunc();
            this.Hide();
            l.ShowDialog();
        }

        private void Administrador_Click(object sender, EventArgs e)
        {
            altText.Text = "Entrar como Administrador";
            panelDashboard.Hide();
            panelAdmin.Show();
        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            panelAdmin.Hide();
            painelVender.Show();
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct a = new AddProduct();
            this.Hide();
            a.ShowDialog();
        }
    }
}
