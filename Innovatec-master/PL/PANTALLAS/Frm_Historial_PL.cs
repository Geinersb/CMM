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


//using DAL.CAT_MANT;

//using BLL.CAT_MANT;

namespace PL.PANTALLAS
{
    public partial class Frm_Historial_PL : Form
    {
        

        Auditorias_BLL auditoriabll = new Auditorias_BLL();

        public Frm_Historial_PL()
        {
            InitializeComponent();
        }

        private void Frm_Contactos_PL_Load(object sender, EventArgs e)
        {
            CargarDatos();
            this.CargarComboCodigos();
            
        }


        private void CargarDatos()
        {

            this.dgvContactos.DataSource = null;
            this.dgvContactos.Refresh();
            this.dgvContactos.DataSource = auditoriabll.ListarAuditorias();
            this.dgvContactos.Refresh();
            

        }



        public void CargarComboCodigos()
        {
            foreach (Departamento depa in auditoriabll.ListarCodigosDepartamento())
            {
                toolStripComboBox1.Items.Add(depa.Codigo);
            }


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
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Personal_PL Familiares = new Frm_Modificar_Personal_PL();
            Familiares.ShowDialog();
        }

        private void codigoDepartamento_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
                        
        }


        private void CargarAuditoriasPorCodigo(string codigo)
        {
           

            this.dgvContactos.DataSource = null;
            this.dgvContactos.Refresh();
            this.dgvContactos.DataSource = auditoriabll.FiltarAuditoriasCodigo(codigo);
            this.dgvContactos.Refresh();

            // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
            this.toolStripComboBox1.SelectedItem = null;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = this.toolStripComboBox1.ComboBox.GetItemText(this.toolStripComboBox1.SelectedItem);

            //string valor = this.toolStripComboBox1.GetItemText(this.toolStripComboBox1.SelectedItem);
            CargarAuditoriasPorCodigo(valor);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.CargarDatos();
            this.toolStripComboBox1.SelectedItem = null;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.toolStripComboBox1.SelectedItem = null;
            this.CargarDatos();
           
        }
    }
}
