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
            CargarComboNiveles();
            CargarDatos();
        }

        private void CargarDatos()
        {


            this.dgvProcesos.DataSource = null;
            this.dgvProcesos.Refresh();
            this.dgvProcesos.DataSource = procesosBLL.ListarProcesos();
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


        public void CargarComboNiveles()
        {
            foreach (Nivel nivelito in nivelesBLL.ListarNiveles())
            {
                niveles_cbo.Items.Add(nivelito.Id_nivel);
            }


        }
    }
}
