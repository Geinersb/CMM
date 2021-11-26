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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mensaje_lbl = new System.Windows.Forms.Label();
            this.titulo_lbl = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.dato_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mensaje_lbl
            // 
            this.mensaje_lbl.AutoSize = true;
            this.mensaje_lbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.mensaje_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.mensaje_lbl.Location = new System.Drawing.Point(96, 222);
            this.mensaje_lbl.Name = "mensaje_lbl";
            this.mensaje_lbl.Size = new System.Drawing.Size(0, 21);
            this.mensaje_lbl.TabIndex = 2;
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.titulo_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.titulo_lbl.Location = new System.Drawing.Point(184, 37);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(253, 22);
            this.titulo_lbl.TabIndex = 3;
            this.titulo_lbl.Text = "Ingrese su usuario o correo";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogin.Location = new System.Drawing.Point(100, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(408, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ENVIAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.Enabled = false;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(100, 102);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(408, 14);
            this.bunifuSeparator2.TabIndex = 5;
            // 
            // dato_txt
            // 
            this.dato_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
            this.dato_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dato_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato_txt.ForeColor = System.Drawing.Color.DimGray;
            this.dato_txt.Location = new System.Drawing.Point(100, 85);
            this.dato_txt.Name = "dato_txt";
            this.dato_txt.Size = new System.Drawing.Size(416, 20);
            this.dato_txt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(599, 333);
            this.Controls.Add(this.dato_txt);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.titulo_lbl);
            this.Controls.Add(this.mensaje_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Recuperaciòn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mensaje_lbl;
        private System.Windows.Forms.Label titulo_lbl;
        private System.Windows.Forms.Button btnLogin;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox dato_txt;
    }
}

