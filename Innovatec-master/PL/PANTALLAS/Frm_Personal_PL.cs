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

//using DAL.CAT_MANT;

//using BLL.CAT_MANT;

namespace PL.PANTALLAS
{
    public partial class Frm_Personal_PL : Form
    {
        Empleado_BLL Empleado = new Empleado_BLL();

        Empleado Personal = new Empleado();
        
       

        public Frm_Personal_PL()
        {
            InitializeComponent();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Personal_PL_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }


        public void CargarDatos()
        {
            //Cls_Personal_BLL Obj_Personal_BLL = new Cls_Personal_BLL();

            //List<Empleado> ls = Empleado.ConsultarEmpleado();

            this.dgvPersonal.DataSource = null;
            this.dgvPersonal.Refresh();
            this.dgvPersonal.DataSource = Empleado.FiltrarEmpleado(txtFiltro.Text.ToString());
            this.dgvPersonal.Refresh();         
                                 
            lblTotal.Text = string.Format("Total Registros: {0}", this.dgvPersonal.RowCount);
        }



        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Crear_Personal_PL pantalla = new Frm_Crear_Personal_PL();
            pantalla.ShowDialog();
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Personal_PL pantalla = new Frm_Modificar_Personal_PL();

            

            if (dgvPersonal.Rows.Count > 0)
            {
                pantalla.txtIdEmpleado.Text= dgvPersonal.SelectedRows[0].Cells[0].Value.ToString();
                pantalla.txtNombre.Text = dgvPersonal.SelectedRows[0].Cells[1].Value.ToString();
                pantalla.txtPrimerApellido.Text = dgvPersonal.SelectedRows[0].Cells[2].Value.ToString();
                pantalla.txt_SegundoApellido.Text = dgvPersonal.SelectedRows[0].Cells[3].Value.ToString();
                pantalla.txt_Cedula.Text= dgvPersonal.SelectedRows[0].Cells[4].Value.ToString();
                pantalla.txtTelefono.Text= dgvPersonal.SelectedRows[0].Cells[5].Value.ToString();
                pantalla.txtCorreo.Text= dgvPersonal.SelectedRows[0].Cells[6].Value.ToString();
                pantalla.txtUsuario.Text= dgvPersonal.SelectedRows[0].Cells[7].Value.ToString();                
                pantalla.cmbPersonal.SelectedText= dgvPersonal.SelectedRows[0].Cells[8].Value.ToString();
                pantalla.cmbDepartamento.SelectedText = dgvPersonal.SelectedRows[0].Cells[9].Value.ToString();

            }

            //Frm_Personal_PL personal = new Frm_Personal_PL();           
            pantalla.ShowDialog();
            CargarDatos();

        }

        private void dgvPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                //numeroCamillatxt.Text = this.CamilladataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //this.camillaEstadocbo.Text = this.CamilladataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                               

            


        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatos();
            //CargarDatos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvPersonal);
        }


        private void ExportarDataGridViewExcel(DataGridView dgvPersonal)
        {

            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dgvPersonal.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPersonal.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dgvPersonal.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }

            MessageBox.Show("DOCUMENTO GENERADO CON ÉXITO!!", "GENIAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
