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
    public partial class Frm_Auditoria_Procesos_PL : Form
    {

        Procesos_BLL procesosBLL = new Procesos_BLL();
        Nivel_BLL nivelesBLL = new Nivel_BLL();
        Proceso proceso = new Proceso();
        Nivel nivel = new Nivel();



        public Frm_Auditoria_Procesos_PL()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Nutricion_PL_Load(object sender, EventArgs e)
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



        public void CargarComboNiveles()
        {   
            foreach (Nivel nivelito in nivelesBLL.ListarNiveles())
            {
                niveles_cbo.Items.Add(nivelito.Id_nivel);
            }


        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            
            CargarDatosPorDescripcion();

        }

        private void niveles_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            if (niveles_cbo.SelectedIndex > -1)
                niveles_cbo.SelectedIndex = -1;
        }

        private void niveles_cbo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Crear_Auditoria_PL pantallaAuditar = new Frm_Crear_Auditoria_PL();
            

            if (dgvPacientes.Rows.Count > 0)
            {
                
                 pantallaAuditar.codigo_txt.Text = dgvPacientes.SelectedRows[0].Cells[0].Value.ToString();
                 pantallaAuditar.idProceso_txt.Text= dgvPacientes.SelectedRows[0].Cells[1].Value.ToString();
                pantallaAuditar.usuario_txt.Text = UserCache.Usuario;
                pantallaAuditar.fechaAuditoria_txt.Text= DateTime.Now.ToLongDateString();
            }

            pantallaAuditar.ShowDialog();

        }

        private void niveles_cbo_Click_1(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
        }

        private void niveles_cbo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatosPorNiveles();
        }

        private void tsbtnRefrescar_Click(object sender, EventArgs e)
        {
                    
            txtFiltro.Text = string.Empty;
            niveles_cbo.SelectedItem = null;
            CargarDatos();
        }
    }
}



