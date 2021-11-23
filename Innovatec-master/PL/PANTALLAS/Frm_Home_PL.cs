using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.PANTALLAS
{
    public partial class Frm_Home_PL : Form
    {
        public Frm_Home_PL()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 700)
            {
                timer1.Stop();
                Frm_Login_PL Inicio = new Frm_Login_PL();
                this.Hide();
                Inicio.ShowDialog();
            }
        }
    }
}
