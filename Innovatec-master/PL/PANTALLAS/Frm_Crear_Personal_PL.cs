using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidadades;
using BLL.CAT_MANT;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using DAL.BD;



namespace PL.PANTALLAS
{
    public partial class Frm_Crear_Personal_PL : Form
    {
        Empleado_BLL EmpleadoBLL = new Empleado_BLL();
        



        public Frm_Crear_Personal_PL()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int perfil = 0;
        private int departamento = 0;
      

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text==string.Empty || txtPrimerApellido.Text == string.Empty || txt_SegundoApellido.Text == string.Empty ||txt_Cedula.Text
                == string.Empty || txtTelefono.Text == string.Empty ||txtCorreo.Text == string.Empty ||cmbRol.SelectedItem == null || cmbDepartamento.SelectedItem==null)
            {
                MessageBox.Show("TODOS LOS CAMPOS DEBEN ESTAR LLENOS ");
            }
            else
            {
                Empleado Pempleado = new Empleado();
                
                Pempleado.Nombre = txtNombre.Text.ToString();
                Pempleado.Apellido1 = txtPrimerApellido.Text.ToString();
                Pempleado.Apellido2 = txt_SegundoApellido.Text.ToString();
                Pempleado.Cedula = txt_Cedula.Text.ToString();
                Pempleado.Telefono = txtTelefono.Text.ToString();
                Pempleado.Correo = txtCorreo.Text.ToString();
             //   Pempleado.Usuario = txtUsuario.Text.ToString();               
                perfil = cmbRol.SelectedIndex;
                Pempleado.Id_perfil = perfil + 1;
                departamento = cmbDepartamento.SelectedIndex;
                Pempleado.Id_departamento = departamento + 1;
                //crear los demas variables
                                             
                EmpleadoBLL.AgregarEmpleado(Pempleado);
                MessageBox.Show("SE HA INSERTADO CORRECTAMENTE EL NUEVO PERSONAL");
                this.Hide();

                
            }
                                                                  

        }

        public void CargarComboPerfil()
        {
            Perfil_BLLcs pbll = new Perfil_BLLcs();


            foreach (Perfil perfil in pbll.ListarPerfiles())
            {
                cmbRol.Items.Add(perfil.Nombre);
            }


        }

        private void Frm_Crear_Personal_PL_Load(object sender, EventArgs e)
        {
            CargarComboPerfil();
            CargarComboDepartamentos();
        }


        public void CargarComboDepartamentos()
        {
            Departamento_BLL DepaBLL = new Departamento_BLL();

            
            foreach (Departamento depa in DepaBLL.ListarDepartamento())
            {
                cmbDepartamento.Items.Add(depa.Nombre);
            }
        }


        private void Validaciontextos()
        {

        }

        #region BLOQUEA DE TECLAS EN TEXTBOX
        public bool BloqueoTeclasLetras(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar==(char)Keys.Space))
            {
                return false;

            }
            else
            {
                return true;
            }


        }


        public bool BloqueoTeclasNumeros(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space))
            {
                return false;
                
            }
            else
            {
                
                return true;
            }


        }




        public bool BloqueoTeclasLetrasyespacio(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                return false;

            }
            else
            {
                return true;
            }


        }

        public bool BloqueoTeclasnumerosyespacio(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                return false;

            }
            else
            {
                return true;
            }         

        }

        public bool BloqueoteclaEspacio(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (char.IsNumber(e.KeyChar)))
            {
                return false;

            }
            else
            {
                return true;
            }

        }


        #endregion

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs f)
        {
            f.Handled = BloqueoTeclasNumeros(f);
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs f)
        {
            f.Handled = BloqueoTeclasnumerosyespacio(f);
        }

        private void txt_SegundoApellido_KeyPress(object sender, KeyPressEventArgs f)
        {
            f.Handled = BloqueoTeclasnumerosyespacio(f);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs f )
        {
            f.Handled = BloqueoTeclasLetrasyespacio(f);
        }


        public static bool ValidarCorreo(string email)
        {
            string formatos = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (Regex.IsMatch(email, formatos))
            {
                if (Regex.Replace(email, formatos, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == string.Empty)
            {
                error.SetError(txtCorreo, "Debe digitar un Correo");
                txtCorreo.Focus();
            }
            else
            {
                btnGuardar.Enabled = true;
                error.Clear();
                if (ValidarCorreo(txtCorreo.Text))
                {
                    // Obj_DAL.sCorreo = txt_Correo.Text.Trim();

                }
                else
                {
                    error.SetError(txtCorreo, "Debe digitar un correo electrónico que sea valido");
                    txtCorreo.Focus();
                    btnGuardar.Enabled = false;

                }


            }
        }

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs f)
        {
            f.Handled = BloqueoteclaEspacio(f);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs f)
        {
            f.Handled = BloqueoteclaEspacio(f);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs f)
        {
            f.Handled = BloqueoteclaEspacio(f);
        }


        private void CargarDatos()
        {
            Frm_Personal_PL pantalla = new Frm_Personal_PL();

            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
