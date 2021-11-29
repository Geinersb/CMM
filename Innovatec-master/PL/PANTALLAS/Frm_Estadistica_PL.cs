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
    public partial class Frm_Estadistica_PL : Form
    {
        public Frm_Estadistica_PL()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Enfermeria_PL_Load(object sender, EventArgs e)
        {

            CargarCantidadProcesos();
            CargarCantidadActivos();
            CargarCantidadArchivados();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void CargarCantidadProcesos()
        {
            Procesos_BLL DepaBLL = new Procesos_BLL();


            foreach (Proceso depa in DepaBLL.ListarCantidadProcesos())
            {
                lblProcesos.Text = depa.Id_proceso.ToString();
                
            }
        }

        public void CargarCantidadActivos()
        {
            Procesos_BLL DepaBLL = new Procesos_BLL();


            foreach (Proceso depa in DepaBLL.ListarCantidadProcesosActivos())
            {
                lblActivos.Text = depa.Id_proceso.ToString();

            }
        }

        public void CargarCantidadArchivados()
        {
            Procesos_BLL DepaBLL = new Procesos_BLL();


            foreach (Proceso depa in DepaBLL.ListarCantidadProcesosArchivados())
            {
                lblArchivados.Text = depa.Id_proceso.ToString();

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
