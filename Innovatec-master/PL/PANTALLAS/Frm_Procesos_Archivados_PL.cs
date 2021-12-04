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
    public partial class Frm_Procesos_Archivados_PL : Form
    {

        Procesos_BLL procesosBLL = new Procesos_BLL();
        Nivel_BLL nivelesBLL = new Nivel_BLL();
        Proceso proceso = new Proceso();
        Nivel nivel = new Nivel();

        public Frm_Procesos_Archivados_PL()
        {
            InitializeComponent();
        }

        private void btnAuditar_Click(object sender, EventArgs e)
        {
            Frm_Crear_Auditoria_PL pantallaAuditar = new Frm_Crear_Auditoria_PL();

            if (dgvProcesos.Rows.Count > 0)
            {

                pantallaAuditar.codigo_txt.Text = dgvProcesos.SelectedRows[0].Cells[0].Value.ToString();
                pantallaAuditar.idProceso_txt.Text = dgvProcesos.SelectedRows[0].Cells[1].Value.ToString();
                pantallaAuditar.usuario_txt.Text = UserCache.Usuario;
                pantallaAuditar.fechaAuditoria_txt.Text = DateTime.Now.ToLongDateString();
            }




            pantallaAuditar.ShowDialog();
        }

        private void Frm_Procesos_Archivados_PL_Load(object sender, EventArgs e)
        {
           
            CargarDatos();
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

        private void txtFiltro_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            this.CargarDatosProcesosArchivadosPorDescripcion();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
