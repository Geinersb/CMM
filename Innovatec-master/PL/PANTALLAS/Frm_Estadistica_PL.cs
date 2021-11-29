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
            Frm_Procesos_PL Procesos = new Frm_Procesos_PL();


            ExportarDataGridViewExcel(Procesos.dgvProcesos);
        }


        private void ExportarDataGridViewExcel(DataGridView dgvProcesos)
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
                for (int i = 0; i < dgvProcesos.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvProcesos.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = dgvProcesos.Rows[i].Cells[j].Value.ToString();
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
