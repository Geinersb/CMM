namespace PL.PANTALLAS
{
    partial class Frm_Inicio_PL
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Inicio_PL));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.PanelTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.MenuVertical = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.panelMantenimiento = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PanelAuditoria = new System.Windows.Forms.Panel();
            this.btnArchivados = new System.Windows.Forms.Button();
            this.btn_Historial = new System.Windows.Forms.Button();
            this.btnMantNutricion = new System.Windows.Forms.Button();
            this.btnAuditoriaProcesos = new System.Windows.Forms.Button();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LogoTransition = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.PanelAuditoria.SuspendLayout();
            this.PanelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconRestaurar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.iconMinimizar);
            this.panel2.Controls.Add(this.iconCerrar);
            this.panel2.Controls.Add(this.iconMaximizar);
            this.LogoTransition.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 50);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.iconRestaurar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.iconRestaurar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconRestaurar.Image = global::PL.Properties.Resources.icon_restaurar;
            this.iconRestaurar.Location = new System.Drawing.Point(1039, 12);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(25, 25);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaurar.TabIndex = 4;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            this.iconRestaurar.Click += new System.EventHandler(this.iconRestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Image = global::PL.Properties.Resources.Mobile_Menu_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.iconMinimizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.iconMinimizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconMinimizar.Image = global::PL.Properties.Resources.icon_minimizar;
            this.iconMinimizar.Location = new System.Drawing.Point(999, 12);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.iconCerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.iconCerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconCerrar.Image = global::PL.Properties.Resources.icon_cerrar2;
            this.iconCerrar.Location = new System.Drawing.Point(1081, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(25, 25);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.iconMaximizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.iconMaximizar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.iconMaximizar.Image = global::PL.Properties.Resources.icon_maximizar;
            this.iconMaximizar.Location = new System.Drawing.Point(1039, 12);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximizar.TabIndex = 2;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Controls.Add(this.bunifuGradientPanel2);
            this.LogoTransition.SetDecoration(this.panelChildForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panelChildForm, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 50);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1119, 723);
            this.panelChildForm.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.PanelTransition.SetDecoration(this.pictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox2.Image = global::PL.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(398, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 213);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 1;
            this.bunifuGradientPanel2.Controls.Add(this.lblRol);
            this.bunifuGradientPanel2.Controls.Add(this.lbFecha);
            this.bunifuGradientPanel2.Controls.Add(this.lblHora);
            this.bunifuGradientPanel2.Controls.Add(this.lblNombre);
            this.LogoTransition.SetDecoration(this.bunifuGradientPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuGradientPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(29)))), ((int)(((byte)(69)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(29)))), ((int)(((byte)(69)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(29)))), ((int)(((byte)(69)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 641);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(1119, 82);
            this.bunifuGradientPanel2.TabIndex = 9;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblRol, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblRol, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(17, 37);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(34, 18);
            this.lblRol.TabIndex = 12;
            this.lblRol.Text = "Rol";
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lbFecha, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lbFecha, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(853, 46);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(224, 20);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblHora, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblHora, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(926, 7);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(151, 39);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "21:49:45";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblNombre, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblNombre, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(17, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(163, 18);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombres y Apellidos";
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Transparent;
            this.MenuVertical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuVertical.BackgroundImage")));
            this.MenuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuVertical.BorderRadius = 1;
            this.MenuVertical.Controls.Add(this.panelMantenimiento);
            this.MenuVertical.Controls.Add(this.btnMantenimiento);
            this.MenuVertical.Controls.Add(this.btnSalir);
            this.MenuVertical.Controls.Add(this.PanelAuditoria);
            this.MenuVertical.Controls.Add(this.btnAuditoria);
            this.MenuVertical.Controls.Add(this.PanelAdmin);
            this.MenuVertical.Controls.Add(this.btnAdmin);
            this.MenuVertical.Controls.Add(this.Logo);
            this.LogoTransition.SetDecoration(this.MenuVertical, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.MenuVertical, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(23)))), ((int)(((byte)(57)))));
            this.MenuVertical.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(29)))), ((int)(((byte)(69)))));
            this.MenuVertical.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.MenuVertical.GradientTopRight = System.Drawing.Color.Black;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Quality = 10;
            this.MenuVertical.Size = new System.Drawing.Size(250, 773);
            this.MenuVertical.TabIndex = 7;
            // 
            // panelMantenimiento
            // 
            this.panelMantenimiento.Controls.Add(this.button1);
            this.panelMantenimiento.Controls.Add(this.button2);
            this.LogoTransition.SetDecoration(this.panelMantenimiento, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.panelMantenimiento, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.panelMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMantenimiento.Location = new System.Drawing.Point(0, 565);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(250, 95);
            this.panelMantenimiento.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "DEPARTAMENTOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "PERSONAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnMantenimiento, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMantenimiento, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Image = global::PL.Properties.Resources.gear_2_32;
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 520);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Padding = new System.Windows.Forms.Padding(12, 0, 2, 0);
            this.btnMantenimiento.Size = new System.Drawing.Size(250, 45);
            this.btnMantenimiento.TabIndex = 10;
            this.btnMantenimiento.Text = "Mantenimientos";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PL.Properties.Resources.Power_Log_Off;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelTransition.SetDecoration(this.btnSalir, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnSalir, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(12, 695);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 36);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PanelAuditoria
            // 
            this.PanelAuditoria.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.PanelAuditoria.Controls.Add(this.btnArchivados);
            this.PanelAuditoria.Controls.Add(this.btn_Historial);
            this.PanelAuditoria.Controls.Add(this.btnMantNutricion);
            this.PanelAuditoria.Controls.Add(this.btnAuditoriaProcesos);
            this.LogoTransition.SetDecoration(this.PanelAuditoria, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PanelAuditoria, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAuditoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAuditoria.Location = new System.Drawing.Point(0, 363);
            this.PanelAuditoria.Name = "PanelAuditoria";
            this.PanelAuditoria.Size = new System.Drawing.Size(250, 157);
            this.PanelAuditoria.TabIndex = 8;
            // 
            // btnArchivados
            // 
            this.btnArchivados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnArchivados, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnArchivados, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnArchivados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArchivados.FlatAppearance.BorderSize = 0;
            this.btnArchivados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnArchivados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivados.ForeColor = System.Drawing.Color.White;
            this.btnArchivados.Location = new System.Drawing.Point(0, 120);
            this.btnArchivados.Name = "btnArchivados";
            this.btnArchivados.Size = new System.Drawing.Size(250, 40);
            this.btnArchivados.TabIndex = 14;
            this.btnArchivados.Text = "ARCHIVADOS";
            this.btnArchivados.UseVisualStyleBackColor = true;
            this.btnArchivados.Click += new System.EventHandler(this.btnArchivados_Click);
            // 
            // btn_Historial
            // 
            this.btn_Historial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btn_Historial, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btn_Historial, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btn_Historial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Historial.FlatAppearance.BorderSize = 0;
            this.btn_Historial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historial.ForeColor = System.Drawing.Color.White;
            this.btn_Historial.Location = new System.Drawing.Point(0, 80);
            this.btn_Historial.Name = "btn_Historial";
            this.btn_Historial.Size = new System.Drawing.Size(250, 40);
            this.btn_Historial.TabIndex = 13;
            this.btn_Historial.Text = "AUDITORIAS";
            this.btn_Historial.UseVisualStyleBackColor = true;
            this.btn_Historial.Click += new System.EventHandler(this.btn_Historial_Click);
            // 
            // btnMantNutricion
            // 
            this.btnMantNutricion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnMantNutricion, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnMantNutricion, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnMantNutricion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMantNutricion.FlatAppearance.BorderSize = 0;
            this.btnMantNutricion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMantNutricion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantNutricion.ForeColor = System.Drawing.Color.White;
            this.btnMantNutricion.Location = new System.Drawing.Point(0, 40);
            this.btnMantNutricion.Name = "btnMantNutricion";
            this.btnMantNutricion.Size = new System.Drawing.Size(250, 40);
            this.btnMantNutricion.TabIndex = 12;
            this.btnMantNutricion.Text = "ESTADISTICA";
            this.btnMantNutricion.UseVisualStyleBackColor = true;
            this.btnMantNutricion.Click += new System.EventHandler(this.btnMantNutricion_Click);
            // 
            // btnAuditoriaProcesos
            // 
            this.btnAuditoriaProcesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnAuditoriaProcesos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnAuditoriaProcesos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnAuditoriaProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuditoriaProcesos.FlatAppearance.BorderSize = 0;
            this.btnAuditoriaProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAuditoriaProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditoriaProcesos.ForeColor = System.Drawing.Color.White;
            this.btnAuditoriaProcesos.Location = new System.Drawing.Point(0, 0);
            this.btnAuditoriaProcesos.Name = "btnAuditoriaProcesos";
            this.btnAuditoriaProcesos.Size = new System.Drawing.Size(250, 40);
            this.btnAuditoriaProcesos.TabIndex = 11;
            this.btnAuditoriaProcesos.Text = "PROCESOS";
            this.btnAuditoriaProcesos.UseVisualStyleBackColor = true;
            this.btnAuditoriaProcesos.Click += new System.EventHandler(this.btnMantEnfermeria_Click);
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnAuditoria, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnAuditoria, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnAuditoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuditoria.FlatAppearance.BorderSize = 0;
            this.btnAuditoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditoria.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAuditoria.ForeColor = System.Drawing.Color.White;
            this.btnAuditoria.Image = global::PL.Properties.Resources.pages__2_;
            this.btnAuditoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditoria.Location = new System.Drawing.Point(0, 318);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Padding = new System.Windows.Forms.Padding(9, 0, 5, 0);
            this.btnAuditoria.Size = new System.Drawing.Size(250, 45);
            this.btnAuditoria.TabIndex = 7;
            this.btnAuditoria.Text = "Auditoria";
            this.btnAuditoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAuditoria.UseVisualStyleBackColor = true;
            this.btnAuditoria.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Controls.Add(this.btnEstadistica);
            this.PanelAdmin.Controls.Add(this.btnPacientes);
            this.LogoTransition.SetDecoration(this.PanelAdmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelTransition.SetDecoration(this.PanelAdmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAdmin.Location = new System.Drawing.Point(0, 212);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(250, 106);
            this.PanelAdmin.TabIndex = 3;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnEstadistica, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnEstadistica, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnEstadistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.ForeColor = System.Drawing.Color.White;
            this.btnEstadistica.Location = new System.Drawing.Point(0, 40);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(250, 40);
            this.btnEstadistica.TabIndex = 5;
            this.btnEstadistica.Text = "ARCHIVADOS";
            this.btnEstadistica.UseVisualStyleBackColor = true;
            this.btnEstadistica.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnPacientes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnPacientes, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(250, 40);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "PROCESOS";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.btnAdmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.btnAdmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::PL.Properties.Resources.clientes;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 167);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(8, 5, 5, 0);
            this.btnAdmin.Size = new System.Drawing.Size(250, 45);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Administración";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTransition.SetDecoration(this.Logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Logo, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = global::PL.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Logo.Size = new System.Drawing.Size(250, 167);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Mosaic;
            this.LogoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation2;
            // 
            // Frm_Inicio_PL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1369, 773);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuVertical);
            this.PanelTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.LogoTransition.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Inicio_PL";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Residencia Geriatrica Nuestra Señora de los Angeles";
            this.Load += new System.EventHandler(this.Frm_Inicio_PL_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.MenuVertical.ResumeLayout(false);
            this.panelMantenimiento.ResumeLayout(false);
            this.PanelAuditoria.ResumeLayout(false);
            this.PanelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconCerrar;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmFechaHora;
        private Bunifu.UI.WinForms.BunifuTransition PanelTransition;
        private Bunifu.UI.WinForms.BunifuTransition LogoTransition;
        private Bunifu.UI.WinForms.BunifuGradientPanel MenuVertical;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Panel PanelAdmin;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Panel PanelAuditoria;
        private System.Windows.Forms.Button btnMantNutricion;
        private System.Windows.Forms.Button btnAuditoriaProcesos;
        private System.Windows.Forms.Panel panelMantenimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Historial;
        private System.Windows.Forms.Button btnArchivados;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}