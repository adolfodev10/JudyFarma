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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressbar.Value <= 99)
            {
                timer1.Start();
                for (int i = 0; i <= 100; i++) ;
                    progressbar.Value += 2;
            }
            else
            {
                timer1.Stop();
                LoginFunc l = new LoginFunc();
                this.Hide();
                l.ShowDialog();

            }
        }
    }
}
