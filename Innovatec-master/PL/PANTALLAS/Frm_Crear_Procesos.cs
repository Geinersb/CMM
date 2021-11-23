using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//using DAL.CAT_MANT;

//using BLL.CAT_MANT;

namespace PL.PANTALLAS
{
    public partial class Frm_Crear_Procesos : Form
    {

        //Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
        //CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();

        //Cls_Pacientes_DAL Obj_Pacientes_DAL = new Cls_Pacientes_DAL();
        //Cls_Pacientes_BLL Obj_Pacientes_BLL = new Cls_Pacientes_BLL();

        string sMsjError = string.Empty;
        public Frm_Crear_Procesos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
       
                  

        private void Frm_Pacientes_Load(object sender, EventArgs e)
        {
           
        }




        public void CargarComboFamiliar()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-6BRVLJ4;Initial Catalog=RESIDENCIA_GERIATRICA;Integrated Security=True");
            SqlCommand cm = new SqlCommand("Select Cedula_Cont from CONTACTOS", cn);


            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cmbNivel.Items.Add(dr.GetString(0));
            }
            cn.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //if (txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtCedula.Text == string.Empty || txtSangre.Text == string.Empty || cbHombre.Checked == false & cbMujer.Checked == false || cmbContacto.SelectedItem == null)
            //{
            //    MessageBox.Show("Todos los campos son necesarios para crear el caso!!!", "Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //}

            //else
            //{
            //    Obj_Pacientes_DAL.sNombre = txtNombre.Text.Trim();
            //    Obj_Pacientes_DAL.sApellidos = txtApellido.Text.Trim();
            //    Obj_Pacientes_DAL.sIdPaciente = txtCedula.Text.Trim();
            //    Obj_Pacientes_DAL.DFecha = dtFecha.Value.Date;
            //    Obj_Pacientes_DAL.sTipoSangre = txtSangre.Text.Trim();

            //    if (cbHombre.Checked == true)
            //    {
            //        cbMujer.Checked = false;
            //        Obj_Pacientes_DAL.cSexo = 'M';
            //    }
            //    else
            //    {
            //        cbHombre.Checked = false;
            //        Obj_Pacientes_DAL.cSexo = 'F';
            //    }

            //    Obj_Pacientes_DAL.cEstado = 'A';
            //    Obj_Pacientes_DAL.sIdContacto = cmbContacto.SelectedItem.ToString();

            //    Obj_Pacientes_BLL.CrearPacientes(ref Obj_Pacientes_DAL, ref sMsjError);


            //    if (sMsjError == string.Empty)
            //    {
            //        MessageBox.Show("SE HA INSERTADO CORRECTAMENTE EL NUEVO PACIENTE");
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("SE PRESENTÓ UN ERROR A LA HORA DE INSERTAR EL NUEVO PACIENTE, VERIFIQUE LA INFORMACIÓN. [" + sMsjError + "]");
            //    }
            //}
        }


    }
}
