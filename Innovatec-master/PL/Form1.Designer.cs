namespace PL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dato_txt = new System.Windows.Forms.TextBox();
            this.enviarResponse_btn = new System.Windows.Forms.Button();
            this.mensaje_lbl = new System.Windows.Forms.Label();
            this.titulo_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dato_txt
            // 
            this.dato_txt.Location = new System.Drawing.Point(173, 121);
            this.dato_txt.Name = "dato_txt";
            this.dato_txt.Size = new System.Drawing.Size(229, 20);
            this.dato_txt.TabIndex = 0;
            // 
            // enviarResponse_btn
            // 
            this.enviarResponse_btn.Location = new System.Drawing.Point(228, 163);
            this.enviarResponse_btn.Name = "enviarResponse_btn";
            this.enviarResponse_btn.Size = new System.Drawing.Size(106, 23);
            this.enviarResponse_btn.TabIndex = 1;
            this.enviarResponse_btn.Text = "Enviar";
            this.enviarResponse_btn.UseVisualStyleBackColor = true;
            this.enviarResponse_btn.Click += new System.EventHandler(this.enviarResponse_btn_Click);
            // 
            // mensaje_lbl
            // 
            this.mensaje_lbl.AutoSize = true;
            this.mensaje_lbl.Location = new System.Drawing.Point(59, 271);
            this.mensaje_lbl.Name = "mensaje_lbl";
            this.mensaje_lbl.Size = new System.Drawing.Size(58, 13);
            this.mensaje_lbl.TabIndex = 2;
            this.mensaje_lbl.Text = "Respuesta";
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.Location = new System.Drawing.Point(210, 90);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(135, 13);
            this.titulo_lbl.TabIndex = 3;
            this.titulo_lbl.Text = "Ingrese su usuario o correo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 333);
            this.Controls.Add(this.titulo_lbl);
            this.Controls.Add(this.mensaje_lbl);
            this.Controls.Add(this.enviarResponse_btn);
            this.Controls.Add(this.dato_txt);
            this.Name = "Form1";
            this.Text = "Formulario de Recuperaciòn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dato_txt;
        private System.Windows.Forms.Button enviarResponse_btn;
        private System.Windows.Forms.Label mensaje_lbl;
        private System.Windows.Forms.Label titulo_lbl;
    }
}

