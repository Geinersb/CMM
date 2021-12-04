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
            CargarDatos();
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


        public void CargarDatos()
        {
            

                this.dgvProcesos.DataSource = null;
                this.dgvProcesos.Refresh();
                this.dgvProcesos.DataSource = procesosBLL.ListarProcesos();
                this.dgvProcesos.Refresh();

                // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
           
        }

        private void CargarDatosPorDescripcion()
        {


            this.dgvProcesos.DataSource = null;
            this.dgvProcesos.Refresh();
            this.dgvProcesos.DataSource = procesosBLL.FiltrarProcesosDescripcion(txtFiltro.Text);
            this.dgvProcesos.Refresh();

            // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
        }


        private void CargarDatosPorNiveles()
        {
            int vacio;
            if (niveles_cbo.SelectedIndex == -1)
                vacio = 0;
            else
                vacio = niveles_cbo.SelectedIndex + 1;

            this.dgvProcesos.DataSource = null;
            this.dgvProcesos.Refresh();
            this.dgvProcesos.DataSource = procesosBLL.FiltrarProcesosNivel(vacio);
            this.dgvProcesos.Refresh();

            // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
        }


        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            CargarDatosPorDescripcion();
           
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Procesos_PL Procesos = new Frm_Modificar_Procesos_PL();

            if (dgvProcesos.Rows.Count > 0)
            {
                Procesos.txtDepartamento.Text=dgvProcesos.SelectedRows[0].Cells[0].Value.ToString();
                Procesos.txtIdProceso.Text= dgvProcesos.SelectedRows[0].Cells[1].Value.ToString();
                Procesos.txtDescripción.Text = dgvProcesos.SelectedRows[0].Cells[2].Value.ToString();
                Procesos.cmbNivel.SelectedValue = dgvProcesos.SelectedRows[0].Cells[3].Value.ToString();
                Procesos.txtInicial.Text = dgvProcesos.SelectedRows[0].Cells[4].Value.ToString();
                Procesos.txtRepetible.Text = dgvProcesos.SelectedRows[0].Cells[5].Value.ToString();
                Procesos.txtDefinido.Text = dgvProcesos.SelectedRows[0].Cells[6].Value.ToString();
                Procesos.txtGestionado.Text = dgvProcesos.SelectedRows[0].Cells[7].Value.ToString();
                Procesos.txtOptimizado.Text = dgvProcesos.SelectedRows[0].Cells[8].Value.ToString();
                Procesos.txtRealizado.Text = dgvProcesos.SelectedRows[0].Cells[9].Value.ToString();
                Procesos.txtFecha.Text = dgvProcesos.SelectedRows[0].Cells[10].Value.ToString();               

            }
            
            Procesos.ShowDialog();
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

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            niveles_cbo.SelectedItem = null;
            CargarDatos();
        }

        private void niveles_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatosPorNiveles();
        }

        private void niveles_cbo_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            if (niveles_cbo.SelectedIndex > -1)
                niveles_cbo.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nivel = 0;
           

            nivel = Convert.ToInt32(dgvProcesos.SelectedRows[0].Cells[3].Value.ToString());
            if (nivel != 5)
            {
                MessageBox.Show("Sòlo se pueden archivar procesos con valor actual igual a 5");
            }
            else
            {
                //modificar el estado del proceso a 0
                proceso.Id_proceso = Convert.ToInt32(dgvProcesos.SelectedRows[0].Cells[1].Value.ToString());
                proceso.Id_nivel = nivel;
                proceso.Estado = 0;
                procesosBLL.ModificarProceso(proceso);
                txtFiltro.Text = string.Empty;
                niveles_cbo.SelectedItem = null;
                CargarDatos();
                MessageBox.Show("Proceso archivado");
            }
        }

        private void btnAuditorias_Click(object sender, EventArgs e)
        {
            Frm_Historial_Auditorias_Admin_PL Auditorias = new Frm_Historial_Auditorias_Admin_PL();
            int idProceso = Convert.ToInt32(dgvProcesos.SelectedRows[0].Cells[1].Value.ToString());
            Auditorias.idProcesoSeleccionado= idProceso;
            Auditorias.ShowDialog();
        }
    }
}
