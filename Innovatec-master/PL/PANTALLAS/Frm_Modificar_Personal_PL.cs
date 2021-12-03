using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.CAT_MANT;
using Entidadades;



namespace PL.PANTALLAS
{
    public partial class Frm_Modificar_Personal_PL : Form
    {
        Empleado_BLL editar = new Empleado_BLL();

        string sMsjError = string.Empty;

        public Frm_Modificar_Personal_PL()
        {
            InitializeComponent();
        }

       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int perfil = 0;
        private int departamento = 0;
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == string.Empty || txtPrimerApellido.Text == string.Empty || txt_SegundoApellido.Text == string.Empty || txt_Cedula.Text
               == string.Empty || txtTelefono.Text == string.Empty || txtCorreo.Text == string.Empty || txtUsuario.Text == string.Empty ||  cmbPersonal.SelectedItem == null || cmbDepartamento.SelectedItem == null)
            {
                MessageBox.Show("TODOS LOS CAMPOS DEBEN ESTAR LLENOS ");
            }
            else
            {
                Empleado Pempleado = new Empleado();
                Pempleado.Id_empleado = Convert.ToInt32(txtIdEmpleado.Text.ToString());
                Pempleado.Nombre = txtNombre.Text.ToString();
                Pempleado.Apellido1 = txtPrimerApellido.Text.ToString();
                Pempleado.Apellido2 = txt_SegundoApellido.Text.ToString();
                Pempleado.Cedula = txt_Cedula.Text.ToString();
                Pempleado.Telefono = txtTelefono.Text.ToString();
                Pempleado.Correo = txtCorreo.Text.ToString();
                Pempleado.Usuario = txtUsuario.Text.ToString();               
                perfil = cmbPersonal.SelectedIndex;
                Pempleado.Id_perfil = perfil + 1;
                departamento = cmbDepartamento.SelectedIndex;
                Pempleado.Id_departamento = departamento + 1;

                                             
                editar.ModificarEmpleado(Pempleado);

                MessageBox.Show("SE HA EDITADO CORRECTAMENTE EL PERSONAL");
                this.Hide();
                
            }           

        }



        private void CargarDatos()
        {
                     

        }

        private void Frm_Modificar_Pacientes_PL_Load(object sender, EventArgs e)
        {
            CargarComboPerfil();
            CargarComboDepartamentos();
        }


        public void CargarComboPerfil()
        {
            Perfil_BLLcs pbll = new Perfil_BLLcs();


            foreach (Perfil perfil in pbll.ListarPerfiles())
            {
                cmbPersonal.Items.Add(perfil.Nombre);
            }
        }

        public void CargarComboDepartamentos()
        {
            Departamento_BLL DepaBLL = new Departamento_BLL();


            foreach (Departamento depa in DepaBLL.ListarDepartamento())
            {
                cmbDepartamento.Items.Add(depa.Nombre);
            }
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
                btnEditar.Enabled = true;
                error.Clear();
                if (ValidarCorreo(txtCorreo.Text))
                {
                    // Obj_DAL.sCorreo = txt_Correo.Text.Trim();

                }
                else
                {
                    error.SetError(txtCorreo, "Debe digitar un correo electrónico que sea valido");
                    txtCorreo.Focus();
                    btnEditar.Enabled = false;

                }


            }
        }
    }
}
