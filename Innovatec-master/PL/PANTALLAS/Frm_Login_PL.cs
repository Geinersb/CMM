using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using BLL.CAT_MANT;
using Entidadades;
namespace PL.PANTALLAS
{
    public partial class Frm_Login_PL : Form
    {
        public Frm_Login_PL()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Frm_Login_PL_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text != "USUARIO" && txtUsuario.TextLength > 2)
            {
                if (txtPassword.Text != "CONTRASEÑA")
                {
                   Empleado_BLL empleado_BLL = new Empleado_BLL();
                    List<Empleado> lst_empleadoLogin = new List<Empleado>(); 
                    Empleado em = new Empleado();

                     em=empleado_BLL.LoginBLL(txtUsuario.Text, txtPassword.Text);

                    if (em.Nombre!=null)
                    {
                        Frm_Inicio_PL pantalla = new Frm_Inicio_PL();

                        MessageBox.Show("BIENVENID@ " + em.Nombre + " " + em.Apellido1, "BIENVENID@", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //MessageBox.Show("BIENVENID@ " + em.Nombre + " " + em.Apellido1);
                        this.Hide();
                        pantalla.ShowDialog();              

                        pantalla.FormClosed += Logout;
                       
                    }
                    else
                    {
                        msgError("Incorrect username or password entered. \n   Please try again.");
                        txtPassword.Text = "Password";
                        txtPassword.UseSystemPasswordChar = false;
                        txtUsuario.Focus();
                    }
                }
                else msgError("Please enter password.");
            }
            else msgError("Please enter username.");



        }


        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     "+msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblErrorMessage.Visible = false;
            this.Show();
            //txtUsuario.Focus();
        }



    }
}
