using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidadades;
using BLL.CAT_MANT;
using DAL.BD;
using System.Globalization;

namespace PL.PANTALLAS
{
    public partial class Frm_Crear_Procesos : Form
    {
        

        string sMsjError = string.Empty;
        public Frm_Crear_Procesos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }





       

        private void Frm_Pacientes_Load(object sender, EventArgs e)
        {
            txt_Realizado.Text = (UserCache.Usuario).ToString();

            txt_Fecha.Text = DateTime.Now.ToShortDateString();

            var cultureInfo = new CultureInfo("de-DE");
            string dateString = txt_Fecha.Text;
            var fecha = DateTime.Parse(dateString, cultureInfo, DateTimeStyles.NoCurrentDateDefault);



            CargarComboDepartamentos();

        }


        public void CargarComboDepartamentos()
        {
            Departamento_BLL DepaBLL = new Departamento_BLL();


            foreach (Departamento depa in DepaBLL.ListarDepartamentoCodigo())
            {
                cmbDepartamento.Items.Add(depa.Codigo);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }





    }
}
