using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using DAL.CAT_MANT;
//using BLL.CAT_MANT;


namespace PL.PANTALLAS
{
    public partial class Frm_Modificar_Procesos_PL : Form
    {
        //CLS_BD_DAL Obj_BD_DAL = new CLS_BD_DAL();
        //CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();

        //Cls_Pacientes_DAL Obj_Pacientes_DAL = new Cls_Pacientes_DAL();
        //Cls_Pacientes_BLL Obj_Pacientes_BLL = new Cls_Pacientes_BLL();

        //public Cls_Pacientes_DAL Obj_Estados_DAL;

        string sMsjError = string.Empty;

        public Frm_Modificar_Procesos_PL()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //    if (txtNombre.Text== string.Empty || txtApellido.Text == string.Empty || txtCedula.Text == string.Empty|| txtEstado.Text== string.Empty || txtSangre.Text==string.Empty)
            //    {
            //        MessageBox.Show("Se deben llenar todos los campos !!!", "Atención!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //    else
            //    {

            ////        Obj_Pacientes_DAL.sNombre = txtNombre.Text.Trim();
            ////        Obj_Pacientes_DAL.sApellidos = txtApellido.Text.Trim();
            ////        Obj_Pacientes_DAL.sIdPaciente = txtCedula.Text.Trim();
            ////        Obj_Pacientes_DAL.DFecha = dtFecha.Value.Date;
            ////        Obj_Pacientes_DAL.sTipoSangre = txtSangre.Text.Trim();

            ////        if (cbHombre.Checked == true)
            ////        {
            ////            cbMujer.Checked = false;
            ////            Obj_Pacientes_DAL.cSexo = 'M';
            ////        }
            ////        else
            ////        {
            ////            cbHombre.Checked = false;
            ////            Obj_Pacientes_DAL.cSexo = 'F';
            ////        }

            ////        Obj_Pacientes_DAL.cEstado = Convert.ToChar(txtEstado.Text.Trim());
            ////        Obj_Pacientes_DAL.sIdContacto = txtFamiliar.Text.Trim();


            ////        if (Obj_Pacientes_DAL.cBandera == 'I')
            ////        {
            ////            Obj_Pacientes_BLL.CrearPacientes(ref Obj_Pacientes_DAL, ref sMsjError);

            ////            if (sMsjError == string.Empty)
            ////            {
            ////                MessageBox.Show("SE HA INSERTADO CORRECTAMENTE EL NUEVO PACIENTE");
            ////                this.Hide();
            ////            }
            ////            else
            ////            {
            ////                MessageBox.Show("SE PRESENTÓ UN ERROR A LA HORA DE INSERTAR EL NUEVO PACIENTE  [" + sMsjError + "]");
            ////            }
            ////        }
            ////        else
            ////        {

            ////            Obj_Pacientes_BLL.ModificarPacientes(ref Obj_Pacientes_DAL, ref sMsjError);

            ////            if (sMsjError == string.Empty)
            ////            {
            ////                MessageBox.Show("SE HA MODIFICADO CORRECTAMENTE EL PACIENTE");
            ////                this.Hide();
            ////            }
            ////            else
            ////            {
            ////                MessageBox.Show("SE PRESENTÓ UN ERROR A LA HORA DE MODIFICAR EL PACIENTE [" + sMsjError + "]");
            ////            }

            ////        }

            ////        CargarDatos();

            ////    }
            ////}



            //private void CargarDatos()
            //{

            //    Obj_Pacientes_DAL.cBandera = Obj_Estados_DAL.cBandera;


            //if (Obj_Pacientes_DAL.cBandera == 'U')
            //{
            //    txtCaso.Enabled = false;
            //    txtCaso.ReadOnly = true;
            //}
            //else
            //{
            //    txtCaso.Enabled = true;
            //    txtCaso.ReadOnly = false;
            //}

            // txtNombre.Text = Obj_Estados_DAL.sNombre.ToString().Trim();
            // txtApellido.Text = Obj_Estados_DAL.sApellidos.ToString().Trim();
            // txtCedula.Text = Obj_Estados_DAL.sIdPaciente.ToString().Trim();
            // txtEstado.Text = Obj_Estados_DAL.cEstado.ToString().Trim();
            // txtSangre.Text = Obj_Estados_DAL.sTipoSangre.ToString().Trim();

            // if (Obj_Estados_DAL.cSexo=='F')
            // {
            //     cbMujer.Checked = true;
            // }
            // else
            // {
            //     cbHombre.Checked = true;
            // }
            //txtFamiliar.Text= Obj_Estados_DAL.sIdContacto.ToString().Trim();






            //if (Obj_Casos_DAL.cBandera == 'U')
            //{
            //    txtCaso.Enabled = false;
            //    txtCaso.ReadOnly = true;
            //}
            //else
            //{
            //    txtCaso.Enabled = true;
            //    txtCaso.ReadOnly = false;
            //}




        }

        private void Frm_Modificar_Pacientes_PL_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //private void Frm_Modificar_Pacientes_PL_Load(object sender, EventArgs e)
        //{
        //    CargarDatos();
        //}
    }
}
