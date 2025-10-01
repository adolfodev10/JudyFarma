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
    public partial class Estoque : Form
    {
        public Estoque(string texto)
        {
            InitializeComponent();
            funcionario.Text = texto;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard(funcionario.Text);
            this.Hide();
            d.ShowDialog();
        }
    }
}
