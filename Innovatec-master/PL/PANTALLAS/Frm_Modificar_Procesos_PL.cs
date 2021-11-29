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
using DAL.BD;




namespace PL.PANTALLAS
{
    public partial class Frm_Modificar_Procesos_PL : Form
    {
       
        Nivel_BLL NivelBll = new Nivel_BLL();

        string sMsjError = string.Empty;

        public Frm_Modificar_Procesos_PL()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            Proceso Pproceso= new Proceso();
            Pproceso.Id_proceso = Convert.ToInt32(txtIdProceso.Text.ToString());


             //editar.ModificarEmpleado(Pempleado);

            MessageBox.Show("SE HA EDITADO CORRECTAMENTE EL PERSONAL");
            this.Hide();



        }

        private void Frm_Modificar_Pacientes_PL_Load(object sender, EventArgs e)
        {
            
           CargarComboNiveles();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void CargarComboNiveles()
        {
            foreach (Nivel nivelito in NivelBll.ListarNiveles())
            {
                cmbNivel.Items.Add(nivelito.Descripcion);
            }


        }
    }
}
