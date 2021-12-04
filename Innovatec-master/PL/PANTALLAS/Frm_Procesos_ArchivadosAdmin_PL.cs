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

namespace PL.PANTALLAS
{
    public partial class Frm_Procesos_ArchivadosAdmin_PL : Form
    {

        Procesos_BLL procesosBLL = new Procesos_BLL();
        Nivel_BLL nivelesBLL = new Nivel_BLL();
        Proceso proceso = new Proceso();
        Nivel nivel = new Nivel();

        public Frm_Procesos_ArchivadosAdmin_PL()
        {
            InitializeComponent();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {

            //llamar al form de editar para cambiar el valor actual de 5 a lo que diga el correo de la auditoria 
            //porque sino no se va a mostar en procesos al tener un nivel 5 estaria archivado





            Frm_Modificar_Procesos_PL Procesos = new Frm_Modificar_Procesos_PL();

            if (dgvProcesos.Rows.Count > 0)
            {
                Procesos.txtDepartamento.Text = dgvProcesos.SelectedRows[0].Cells[0].Value.ToString();
                Procesos.txtIdProceso.Text = dgvProcesos.SelectedRows[0].Cells[1].Value.ToString();
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
            //MessageBox.Show("Proceso activado");







        }

        private void CargarDatos()
        {


            this.dgvProcesos.DataSource = null;
            this.dgvProcesos.Refresh();
            this.dgvProcesos.DataSource = procesosBLL.ListarProcesosArchivados();
            this.dgvProcesos.Refresh();

            // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
        }

        private void CargarDatosProcesosArchivadosPorDescripcion()
        {


            this.dgvProcesos.DataSource = null;
            this.dgvProcesos.Refresh();
            this.dgvProcesos.DataSource = procesosBLL.ListarProcesosArchivadosPorDescripcion(txtFiltro.Text);
            this.dgvProcesos.Refresh();

            // lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
        }



        private void Frm_Procesos_ArchivadosAdmin_PL_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            this.CargarDatosProcesosArchivadosPorDescripcion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
