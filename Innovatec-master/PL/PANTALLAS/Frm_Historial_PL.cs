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
    public partial class Frm_Historial_PL : Form
    {



        //Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
        //CLS_BD_BLL Obj_BD_BLL = new CLS_BD_BLL();

        //Cls_Contactos_DAL Obj_Contactos_DAL = new Cls_Contactos_DAL();
        //Cls_Contactos_BLL Obj_Contactos_BLL = new Cls_Contactos_BLL();


        public Frm_Historial_PL()
        {
            InitializeComponent();
        }

        private void Frm_Contactos_PL_Load(object sender, EventArgs e)
        {
            
        }


        private void CargarDatos()
        {
           //Cls_Contactos_BLL Obj_Contactos_BLL = new Cls_Contactos_BLL();



            DataSet DS = new DataSet();

            //Obj_Contactos_BLL.ListarFiltrarContactos(ref DS, txtFiltro.Text.Trim());

            if (DS != null)
            {

                dgvContactos.DataSource = null;
                dgvContactos.DataSource = DS.Tables[0];
            }

            //lblTotal.Text = string.Format("Total Registros: {0}", this.dgv_Casos.RowCount);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Crear_Departamentos_PL pantalla = new Frm_Crear_Departamentos_PL();
            pantalla.ShowDialog();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Personal_PL Familiares = new Frm_Modificar_Personal_PL();
            Familiares.ShowDialog();
        }
    }
}
