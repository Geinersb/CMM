namespace PL.PANTALLAS
{
    partial class Frm_Crear_Auditoria_PL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idproceso_lbl = new System.Windows.Forms.Label();
            this.codigo_lbl = new System.Windows.Forms.Label();
            this.hallazgos_lbl = new System.Windows.Forms.Label();
            this.Recomendaciones_lbl = new System.Windows.Forms.Label();
            this.FechaLimite_lbl = new System.Windows.Forms.Label();
            this.FechaAuditoria_lb = new System.Windows.Forms.Label();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.FechaLimite_dtp = new System.Windows.Forms.DateTimePicker();
            this.idProceso_txt = new System.Windows.Forms.TextBox();
            this.codigo_txt = new System.Windows.Forms.TextBox();
            this.hallazgos_txt = new System.Windows.Forms.TextBox();
            this.recomendaciones_txt = new System.Windows.Forms.TextBox();
            this.fechaAuditoria_txt = new System.Windows.Forms.TextBox();
            this.usuario_txt = new System.Windows.Forms.TextBox();
            this.guardarAuditoria_btn = new System.Windows.Forms.Button();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idproceso_lbl
            // 
            this.idproceso_lbl.AutoSize = true;
            this.idproceso_lbl.Location = new System.Drawing.Point(157, 55);
            this.idproceso_lbl.Name = "idproceso_lbl";
            this.idproceso_lbl.Size = new System.Drawing.Size(58, 13);
            this.idproceso_lbl.TabIndex = 0;
            this.idproceso_lbl.Text = "Id Proceso";
            this.idproceso_lbl.Click += new System.EventHandler(this.idproceso_lbl_Click);
            // 
            // codigo_lbl
            // 
            this.codigo_lbl.AutoSize = true;
            this.codigo_lbl.Location = new System.Drawing.Point(157, 90);
            this.codigo_lbl.Name = "codigo_lbl";
            this.codigo_lbl.Size = new System.Drawing.Size(40, 13);
            this.codigo_lbl.TabIndex = 1;
            this.codigo_lbl.Text = "Còdigo";
            // 
            // hallazgos_lbl
            // 
            this.hallazgos_lbl.AutoSize = true;
            this.hallazgos_lbl.Location = new System.Drawing.Point(157, 124);
            this.hallazgos_lbl.Name = "hallazgos_lbl";
            this.hallazgos_lbl.Size = new System.Drawing.Size(53, 13);
            this.hallazgos_lbl.TabIndex = 2;
            this.hallazgos_lbl.Text = "Hallazgos";
            // 
            // Recomendaciones_lbl
            // 
            this.Recomendaciones_lbl.AutoSize = true;
            this.Recomendaciones_lbl.Location = new System.Drawing.Point(152, 187);
            this.Recomendaciones_lbl.Name = "Recomendaciones_lbl";
            this.Recomendaciones_lbl.Size = new System.Drawing.Size(96, 13);
            this.Recomendaciones_lbl.TabIndex = 3;
            this.Recomendaciones_lbl.Text = "Recomendaciones";
            // 
            // FechaLimite_lbl
            // 
            this.FechaLimite_lbl.AutoSize = true;
            this.FechaLimite_lbl.Location = new System.Drawing.Point(152, 264);
            this.FechaLimite_lbl.Name = "FechaLimite_lbl";
            this.FechaLimite_lbl.Size = new System.Drawing.Size(67, 13);
            this.FechaLimite_lbl.TabIndex = 4;
            this.FechaLimite_lbl.Text = "Fecha Limite";
            // 
            // FechaAuditoria_lb
            // 
            this.FechaAuditoria_lb.AutoSize = true;
            this.FechaAuditoria_lb.Location = new System.Drawing.Point(152, 311);
            this.FechaAuditoria_lb.Name = "FechaAuditoria_lb";
            this.FechaAuditoria_lb.Size = new System.Drawing.Size(81, 13);
            this.FechaAuditoria_lb.TabIndex = 5;
            this.FechaAuditoria_lb.Text = "Fecha Auditoria";
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Location = new System.Drawing.Point(152, 352);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(43, 13);
            this.usuario_lbl.TabIndex = 6;
            this.usuario_lbl.Text = "Usuario";
            // 
            // FechaLimite_dtp
            // 
            this.FechaLimite_dtp.Location = new System.Drawing.Point(254, 258);
            this.FechaLimite_dtp.Name = "FechaLimite_dtp";
            this.FechaLimite_dtp.Size = new System.Drawing.Size(213, 20);
            this.FechaLimite_dtp.TabIndex = 8;
            // 
            // idProceso_txt
            // 
            this.idProceso_txt.Location = new System.Drawing.Point(253, 52);
            this.idProceso_txt.Name = "idProceso_txt";
            this.idProceso_txt.ReadOnly = true;
            this.idProceso_txt.Size = new System.Drawing.Size(69, 20);
            this.idProceso_txt.TabIndex = 9;
            // 
            // codigo_txt
            // 
            this.codigo_txt.Location = new System.Drawing.Point(253, 90);
            this.codigo_txt.Name = "codigo_txt";
            this.codigo_txt.ReadOnly = true;
            this.codigo_txt.Size = new System.Drawing.Size(67, 20);
            this.codigo_txt.TabIndex = 10;
            // 
            // hallazgos_txt
            // 
            this.hallazgos_txt.Location = new System.Drawing.Point(253, 121);
            this.hallazgos_txt.Multiline = true;
            this.hallazgos_txt.Name = "hallazgos_txt";
            this.hallazgos_txt.Size = new System.Drawing.Size(212, 47);
            this.hallazgos_txt.TabIndex = 11;
            // 
            // recomendaciones_txt
            // 
            this.recomendaciones_txt.Location = new System.Drawing.Point(254, 187);
            this.recomendaciones_txt.Multiline = true;
            this.recomendaciones_txt.Name = "recomendaciones_txt";
            this.recomendaciones_txt.Size = new System.Drawing.Size(213, 49);
            this.recomendaciones_txt.TabIndex = 12;
            // 
            // fechaAuditoria_txt
            // 
            this.fechaAuditoria_txt.Location = new System.Drawing.Point(254, 311);
            this.fechaAuditoria_txt.Name = "fechaAuditoria_txt";
            this.fechaAuditoria_txt.ReadOnly = true;
            this.fechaAuditoria_txt.Size = new System.Drawing.Size(213, 20);
            this.fechaAuditoria_txt.TabIndex = 13;
            // 
            // usuario_txt
            // 
            this.usuario_txt.Location = new System.Drawing.Point(255, 357);
            this.usuario_txt.Name = "usuario_txt";
            this.usuario_txt.ReadOnly = true;
            this.usuario_txt.Size = new System.Drawing.Size(100, 20);
            this.usuario_txt.TabIndex = 14;
            this.usuario_txt.TextChanged += new System.EventHandler(this.usuario_txt_TextChanged);
            // 
            // guardarAuditoria_btn
            // 
            this.guardarAuditoria_btn.Location = new System.Drawing.Point(172, 421);
            this.guardarAuditoria_btn.Name = "guardarAuditoria_btn";
            this.guardarAuditoria_btn.Size = new System.Drawing.Size(124, 31);
            this.guardarAuditoria_btn.TabIndex = 15;
            this.guardarAuditoria_btn.Text = "Guardar";
            this.guardarAuditoria_btn.UseVisualStyleBackColor = true;
            this.guardarAuditoria_btn.Click += new System.EventHandler(this.guardarAuditoria_btn_Click);
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(369, 420);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(137, 33);
            this.cancelar_btn.TabIndex = 16;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // Frm_Crear_Auditoria_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.guardarAuditoria_btn);
            this.Controls.Add(this.usuario_txt);
            this.Controls.Add(this.fechaAuditoria_txt);
            this.Controls.Add(this.recomendaciones_txt);
            this.Controls.Add(this.hallazgos_txt);
            this.Controls.Add(this.codigo_txt);
            this.Controls.Add(this.idProceso_txt);
            this.Controls.Add(this.FechaLimite_dtp);
            this.Controls.Add(this.usuario_lbl);
            this.Controls.Add(this.FechaAuditoria_lb);
            this.Controls.Add(this.FechaLimite_lbl);
            this.Controls.Add(this.Recomendaciones_lbl);
            this.Controls.Add(this.hallazgos_lbl);
            this.Controls.Add(this.codigo_lbl);
            this.Controls.Add(this.idproceso_lbl);
            this.Name = "Frm_Crear_Auditoria_PL";
            this.Text = "Frm_Crear_Auditoria_PL";
            this.Load += new System.EventHandler(this.Frm_Crear_Auditoria_PL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idproceso_lbl;
        private System.Windows.Forms.Label codigo_lbl;
        private System.Windows.Forms.Label hallazgos_lbl;
        private System.Windows.Forms.Label Recomendaciones_lbl;
        private System.Windows.Forms.Label FechaLimite_lbl;
        private System.Windows.Forms.Label FechaAuditoria_lb;
        private System.Windows.Forms.Label usuario_lbl;
        private System.Windows.Forms.DateTimePicker FechaLimite_dtp;
        public System.Windows.Forms.TextBox idProceso_txt;
        public System.Windows.Forms.TextBox codigo_txt;
        public System.Windows.Forms.TextBox hallazgos_txt;
        public System.Windows.Forms.TextBox recomendaciones_txt;
        public System.Windows.Forms.TextBox fechaAuditoria_txt;
        public System.Windows.Forms.TextBox usuario_txt;
        private System.Windows.Forms.Button guardarAuditoria_btn;
        private System.Windows.Forms.Button cancelar_btn;
    }
}