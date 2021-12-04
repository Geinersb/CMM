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
        Procesos_BLL ProcesoBLL = new Procesos_BLL();
        Nivel_BLL NivelBLL = new Nivel_BLL();

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
            CargarComboNiveles();

        }


        public void CargarComboDepartamentos()
        {
            Departamento_BLL DepaBLL = new Departamento_BLL();


            foreach (Departamento depa in DepaBLL.ListarDepartamentoCodigo())
            {
                cmbDepartamento.Items.Add(depa.Codigo);
            }
        }

        //private int perfil = 0;
        //private int departamento = 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbDepartamento.SelectedItem==null|| txtDescripcion.Text==string.Empty || cmbNivel.SelectedItem==null || txt_Inicial.Text==string.Empty
                || txt_Repetible.Text == string.Empty || txt_Definido.Text == string.Empty|| txt_Gestionado.Text == string.Empty || txt_Optimizado.Text == string.Empty)
            {
                MessageBox.Show("TODOS LOS CAMPOS DEBEN ESTAR LLENOS ");
            }
            else
            {
                Proceso Pproceso = new Proceso();
                Pproceso.Nombre = cmbDepartamento.GetItemText(cmbDepartamento.SelectedItem);
                Pproceso.Descripcion = txtDescripcion.Text.ToString();
                Pproceso.Id_departamento = cmbDepartamento.SelectedIndex + 1; 
                Pproceso.Id_nivel = cmbNivel.SelectedIndex+1;
                Pproceso.Inicial = txt_Inicial.Text.ToString();
                Pproceso.Repetible = txt_Repetible.Text.ToString();
                Pproceso.Definido = txt_Definido.Text.ToString();
                Pproceso.Gestinado = txt_Gestionado.Text.ToString();
                Pproceso.Optimizado = txt_Optimizado.Text.ToString();
                Pproceso.Id_empleado = (UserCache.Id_empleado);
                Pproceso.Fecha_creacion = Convert.ToDateTime(txt_Fecha.Text);
                Pproceso.Estado = 1;

                //crear los demas variables
                ProcesoBLL.AgregarProceso(Pproceso);
               

                MessageBox.Show("SE HA INSERTADO CORRECTAMENTE EL NUEVO PROCESO");
                this.Hide();

                
            }
          
        }


        public void CargarComboNiveles()
        {
            foreach (Nivel nivelito in NivelBLL.ListarNiveles())
            {
                cmbNivel.Items.Add(nivelito.Descripcion);
            }


        }



    }
}
