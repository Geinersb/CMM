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
    public partial class Frm_Crear_Auditoria_PL : Form
    {
        Auditoria auditoria = new Auditoria();
        Auditorias_BLL auditoriaBLL = new Auditorias_BLL();


        public Frm_Crear_Auditoria_PL()
        {
            InitializeComponent();
        }

        private void idproceso_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Crear_Auditoria_PL_Load(object sender, EventArgs e)
        {

        }

        private void guardarAuditoria_btn_Click(object sender, EventArgs e)
        {
                        
        }

        private void usuario_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (hallazgos_txt.Text==string.Empty || recomendaciones_txt.Text==string.Empty)
            {
                MessageBox.Show("TODOS LOS CAMPOS DEBEN ESTAR LLENOS ");
            }
            else
            {
                //faltan validaciones
                auditoria.Usuario = usuario_txt.Text;
                auditoria.Codigo_departamento = codigo_txt.Text;
                auditoria.Id_proceso = Convert.ToInt32(idProceso_txt.Text);
                auditoria.Hallasgoz01 = hallazgos_txt.Text;
                auditoria.Recomendaciones = recomendaciones_txt.Text;
                auditoria.Fecha_limite = Convert.ToDateTime(FechaLimite_dtp.Value.Date);
                //auditoria.Fecha_auditoria = Convert.ToDateTime(fechaAuditoria_txt.Text);
                auditoria.Fecha_auditoria = DateTime.Now;

                auditoriaBLL.AgregarAuditoria(auditoria);
                MessageBox.Show("SE HA INSERTADO CORRECTAMENTE LA AUDITORIA");
                this.Hide();
            }     
                      
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
