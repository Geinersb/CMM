using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.CAT_MANT;

namespace PL.PANTALLAS
{
    public partial class Frm_Historial_Auditorias_Admin_PL : Form
    {

        Auditorias_BLL auditoriasbll = new Auditorias_BLL();
        public Frm_Historial_Auditorias_Admin_PL()
        {
            InitializeComponent();
        }

        private void Frm_Historial_Auditorias_Admin_PL_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }


        private void cargarDatos(){
            this.dgvContactos.DataSource = null;
            this.dgvContactos.Refresh();
            this.dgvContactos.DataSource = auditoriasbll.FiltarAuditoriasPorIdProceso(this.idProcesoSeleccionado);
            this.dgvContactos.Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
