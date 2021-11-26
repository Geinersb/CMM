using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.CAT_MANT;

namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enviarResponse_btn_Click(object sender, EventArgs e)
        {

           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var ebll = new Empleado_BLL();
            var result = ebll.RecuperarPass(dato_txt.Text);
            mensaje_lbl.Text = result;
        }

       
    }
}
