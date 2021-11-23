using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
               
            Empleado Pempleado = new Empleado();

            Pempleado.Nombre = txtNombre.Text.ToString();
            Pempleado.Apellido1 = txtPrimerApellido.Text.ToString();
            Pempleado.Apellido2 = txt_SegundoApellido.Text.ToString();
            Pempleado.Cedula = txt_Cedula.Text.ToString();
            Pempleado.Telefono = txtTelefono.Text.ToString();
            Pempleado.Correo = txtCorreo.Text.ToString();
            Pempleado.Usuario = txtUsuario.Text.ToString();
            Pempleado.Pass = txtPassword.Text.ToString();
            Pempleado.Id_perfil = Convert.ToInt32(cmbPersonal.SelectedText.ToString()); 
            Pempleado.Id_departamento = Convert.ToInt32(cmbDepartamento.SelectedText.ToString());

            editar.ModificarEmpleado(Pempleado);

        }



        private void CargarDatos()
        {
                     

        }

        private void Frm_Modificar_Pacientes_PL_Load(object sender, EventArgs e)
        {
            CargarComboPerfil();
        }


        public void CargarComboPerfil()
        {
            Frm_Modificar_Personal_PL pantalla = new Frm_Modificar_Personal_PL();

            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6BRVLJ4;Initial Catalog=db_cmm;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select nombre from perfil", cn);


            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                pantalla.cmbPersonal.Items.Add(dr.GetString(0));
            }
            cn.Close();
        }


    }
}
