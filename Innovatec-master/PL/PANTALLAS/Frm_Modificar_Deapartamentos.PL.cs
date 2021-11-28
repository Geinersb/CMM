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
using Entidadades;

namespace PL.PANTALLAS
{
    public partial class Frm_Modificar_Deapartamentos : Form
    {
        Departamento_BLL Departamentobll = new Departamento_BLL();
        Departamento departamento = new Departamento();
        public Frm_Modificar_Deapartamentos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == string.Empty || txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("TODOS LOS CAMPOS DEBEN ESTAR LLENOS ");
            }
            else
            {
                departamento.Id_departamento = Convert.ToInt32(txt_IdDepartamento.Text.ToString());
                departamento.Nombre = txtNombre.Text.ToString();
                departamento.Codigo = txtCodigo.Text.ToString();
                //empleado.Nombre = txtnombre;
                Departamentobll.ModificarDepartamento(departamento);

                MessageBox.Show("SE HA EDITADO CORRECTAMENTE EL DEPARTAMENTO");
                this.Hide();
            }
                                            

        }

        private void Frm_Modificar_Deapartamentos_Load(object sender, EventArgs e)
        {

        }

        public void CargarDepartamentos()
        {

            txtNombre.Text = departamento.Nombre.ToString();
            txtCodigo.Text = departamento.Codigo.ToString();
        }
    }
}
