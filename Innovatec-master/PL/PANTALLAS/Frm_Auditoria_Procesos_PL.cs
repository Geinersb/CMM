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
            txtFiltro.Text = string.Empty;
            CargarDatosPorNiveles();


        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            if (niveles_cbo.SelectedIndex > -1)
                niveles_cbo.SelectedIndex = -1;
        }

        private void niveles_cbo_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Crear_Auditoria_PL pantallaAuditar = new Frm_Crear_Auditoria_PL();



            if (dgvPacientes.Rows.Count > 0)
            {
                //pantallaAuditar
                //pantalla.txtIdEmpleado.Text = dgvPersonal.SelectedRows[0].Cells[0].Value.ToString();
                //pantalla.txtNombre.Text = dgvPersonal.SelectedRows[0].Cells[1].Value.ToString();
                //pantalla.txtPrimerApellido.Text = dgvPersonal.SelectedRows[0].Cells[2].Value.ToString();
                //pantalla.txt_SegundoApellido.Text = dgvPersonal.SelectedRows[0].Cells[3].Value.ToString();
                //pantalla.txt_Cedula.Text = dgvPersonal.SelectedRows[0].Cells[4].Value.ToString();
                //pantalla.txtTelefono.Text = dgvPersonal.SelectedRows[0].Cells[5].Value.ToString();
                //pantalla.txtCorreo.Text = dgvPersonal.SelectedRows[0].Cells[6].Value.ToString();
                //pantalla.txtUsuario.Text = dgvPersonal.SelectedRows[0].Cells[7].Value.ToString();
                //pantalla.txtPassword.Text = dgvPersonal.SelectedRows[0].Cells[8].Value.ToString();
                //pantalla.cmbPersonal.SelectedText = dgvPersonal.SelectedRows[0].Cells[9].Value.ToString();
                //pantalla.cmbDepartamento.SelectedText = dgvPersonal.SelectedRows[0].Cells[10].Value.ToString();

            }


            pantalla.ShowDialog();
        }
    }
}
