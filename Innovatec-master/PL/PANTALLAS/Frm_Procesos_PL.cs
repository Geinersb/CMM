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
using Entidadades;
using BLL.CAT_MANT;



namespace PL.PANTALLAS
{
    public partial class Frm_Procesos_PL : Form
    {
        Procesos_BLL procesosBLL = new Procesos_BLL();
        Nivel_BLL nivelesBLL = new Nivel_BLL();
        Proceso proceso = new Proceso();
        Nivel nivel = new Nivel();


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
            CargarComboNiveles();
            CargarDatos();
        }


        private void CargarDatos()
        {
            

                this.dgvPacientes.DataSource = null;
                this.dgvPacientes.Refresh();
                this.dgvPacientes.DataSource = procesosBLL.ListarProcesos();
                this.dgvPacientes.Refresh();

                // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
           
        }

        private void CargarDatosPorDescripcion()
        {


            this.dgvPacientes.DataSource = null;
            this.dgvPacientes.Refresh();
            this.dgvPacientes.DataSource = procesosBLL.FiltrarProcesosDescripcion(txtFiltro.Text);
            this.dgvPacientes.Refresh();

            // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
        }


        private void CargarDatosPorNiveles()
        {
            int vacio;
            if (niveles_cbo.SelectedIndex == -1)
                vacio = 0;
            else
                vacio = niveles_cbo.SelectedIndex + 1;

            this.dgvPacientes.DataSource = null;
            this.dgvPacientes.Refresh();
            this.dgvPacientes.DataSource = procesosBLL.FiltrarProcesosNivel(vacio);
            this.dgvPacientes.Refresh();

            // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
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

                    

            CargarDatos();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void CargarComboNiveles()
        {
            foreach (Nivel nivelito in nivelesBLL.ListarNiveles())
            {
                niveles_cbo.Items.Add(nivelito.Id_nivel);
            }


        }




    }
}
