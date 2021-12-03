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
    public partial class Frm_Depatamentos_PL : Form
    {

        Departamento_BLL Departamentos = new Departamento_BLL();

        Departamento Edepartamento = new Departamento();
        
        public Frm_Depatamentos_PL()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Terapia_PL_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Crear_Departamentos_PL Departamentos = new Frm_Crear_Departamentos_PL();
            Departamentos.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PANTALLAS.Frm_Modificar_Deapartamentos PantModificar = new Frm_Modificar_Deapartamentos();
                                 
            if (dgvDepartamentos.Rows.Count > 0)
            {
                PantModificar.txt_IdDepartamento.Text = dgvDepartamentos.SelectedRows[0].Cells[0].Value.ToString();
                PantModificar.txtNombre.Text= dgvDepartamentos.SelectedRows[0].Cells[1].Value.ToString();
                PantModificar.txtCodigo.Text= dgvDepartamentos.SelectedRows[0].Cells[2].Value.ToString();

            }
                        
            //PantModificar. = Entidadades = Edepartamento;
            PantModificar.ShowDialog();
            CargarDatos();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            //Cls_Personal_BLL Obj_Personal_BLL = new Cls_Personal_BLL();

            //List<Empleado> ls = Empleado.ConsultarEmpleado();

            this.dgvDepartamentos.DataSource = null;
            this.dgvDepartamentos.Refresh();
            this.dgvDepartamentos.DataSource = Departamentos.FiltrarDepartameto(txtFiltro.Text.ToString());
            this.dgvDepartamentos.Refresh();

            lblTotal.Text = string.Format("Total Registros: {0}", this.dgvDepartamentos.RowCount);
        }

        private void tsbtn_Refrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
        }

        private void tsbtn_Exportar_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvDepartamentos);
        }


        private void ExportarDataGridViewExcel(DataGridView dgvDepartamentos)
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
                for (int i = 0; i < dgvDepartamentos.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDepartamentos.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dgvDepartamentos.Rows[i].Cells[j].Value.ToString();
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

