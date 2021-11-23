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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado Pempleado = new Empleado();

            Pempleado.Nombre = txtNombre.Text.ToString();
            Pempleado.Apellido1 = txtPrimerApellido.Text.ToString();
            Pempleado.Apellido2 = txt_SegundoApellido.Text.ToString();
            Pempleado.Cedula = txt_Cedula.Text.ToString();
            Pempleado.Telefono = txtTelefono.Text.ToString();
            Pempleado.Correo= txtCorreo.Text.ToString();
            Pempleado.Usuario = txtUsuario.Text.ToString();
            Pempleado.Pass = txtPassword.Text.ToString();
            Pempleado.Id_perfil = cmbRol.SelectedIndex;
            Pempleado.Id_departamento = cmbDepartamento.SelectedIndex;
           //crear los demas variables

            EmpleadoBLL.AgregarEmpleado(Pempleado);

        }

        public void CargarComboPerfil()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6BRVLJ4;Initial Catalog=db_cmm;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select nombre from perfil", cn);


            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbRol.Items.Add(dr.GetString(0));
            }
            cn.Close();
        }

        private void Frm_Crear_Personal_PL_Load(object sender, EventArgs e)
        {
            CargarComboPerfil();
            CargarComboDepartamentos();
        }


        public void CargarComboDepartamentos()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6BRVLJ4;Initial Catalog=db_cmm;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select nombre from Departamentos", cn);


            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbDepartamento.Items.Add(dr.GetString(0));
            }
            cn.Close();
        }


    }
}
