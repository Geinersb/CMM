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
using System.Data.SqlClient;



namespace PL.PANTALLAS
{
    public partial class Frm_Crear_Departamentos_PL : Form
    {
        Departamento_BLL DepartamentoBLL = new Departamento_BLL();

        string sMsjError = string.Empty;

        public Frm_Crear_Departamentos_PL()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (txtNombre.Text== string.Empty || txtCodigo.Text==string.Empty)
            {
                MessageBox.Show("TODOS LOS CAMPOS DEBEN ESTAR LLENOS ");
            }
            else
            {
                Departamento EDepartamento = new Departamento();

                EDepartamento.Nombre = txtNombre.Text.ToString();
                EDepartamento.Codigo = txtCodigo.Text.ToString();


                DepartamentoBLL.AgregarDepartamento(EDepartamento);
                MessageBox.Show("SE HA INSERTADO CORRECTAMENTE EL NUEVO DEPARTAMENTO");
                this.Hide();
            }
                       
           

        }      



    }

   

    
}

