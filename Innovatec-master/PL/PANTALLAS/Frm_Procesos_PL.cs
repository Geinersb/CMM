using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.PANTALLAS;

//using DAL.CAT_MANT;

//using BLL.CAT_MANT;


namespace PL.PANTALLAS
{
    public partial class Frm_Procesos_PL : Form
    {


        //Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
        //CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();

        //Cls_Pacientes_DAL Obj_Pacientes_DAL = new Cls_Pacientes_DAL();
        //Cls_Pacientes_BLL Obj_Pacientes_BLL = new Cls_Pacientes_BLL();

        public Frm_Procesos_PL()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Crear_Procesos pantalla = new Frm_Crear_Procesos();
            pantalla.ShowDialog();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Admin_PL_Load(object sender, EventArgs e)
        {
            
        }


        private void CargarDatos()
        {
            //Cls_Pacientes_BLL Obj_Pacientes_BLL = new Cls_Pacientes_BLL();

            

                DataSet DS = new DataSet();

            //Obj_Pacientes_BLL.ListarFiltrarPacientes(ref DS, txtFiltro.Text.Trim());

                //if (DS != null)
                //{

                //    dgvPacientes.DataSource = null;
                //    dgvPacientes.DataSource = DS.Tables[0];
                //}

                //lblTotal.Text = string.Format("Total Registros: {0}", this.dgv_Casos.RowCount);
         }

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            PANTALLAS.Frm_Modificar_Procesos_PL Pacientes = new Frm_Modificar_Procesos_PL();

            if (dgvPacientes.Rows.Count >0)
            {
                //Obj_Pacientes_DAL.sNombre = dgvPacientes.SelectedRows[0].Cells[2].Value.ToString();
                //Obj_Pacientes_DAL.sApellidos = dgvPacientes.SelectedRows[0].Cells[3].Value.ToString();
                //Obj_Pacientes_DAL.sIdPaciente= dgvPacientes.SelectedRows[0].Cells[0].Value.ToString();
                //Obj_Pacientes_DAL.sTipoSangre= dgvPacientes.SelectedRows[0].Cells[5].Value.ToString();
                //Obj_Pacientes_DAL.sIdContacto= dgvPacientes.SelectedRows[0].Cells[1].Value.ToString();
                
                //Obj_Pacientes_DAL.cSexo= Convert.ToChar(dgvPacientes.SelectedRows[0].Cells[6].Value.ToString());
                //Obj_Pacientes_DAL.DFecha= Convert.ToDateTime(dgvPacientes.SelectedRows[0].Cells[4].Value.ToString());
                //Obj_Pacientes_DAL.cEstado = Convert.ToChar(dgvPacientes.SelectedRows[0].Cells[7].Value);
                //Obj_Pacientes_DAL.cBandera = 'U';
            }

            //Pacientes.Obj_Estados_DAL = Obj_Pacientes_DAL;

            Pacientes.ShowDialog();

            CargarDatos();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


       



    }
}
