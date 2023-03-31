namespace Sistemas_Reservas
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            PanelBarraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            PanelMenu = new Panel();
            btnReservas = new FontAwesome.Sharp.IconButton();
            btnCanchas = new FontAwesome.Sharp.IconButton();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            lblEmailApp = new Label();
            lblUsuarioApp = new Label();
            lblNombreApp = new Label();
            linkEditarPerfil = new LinkLabel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            picInicio = new APP.PICTUREREDONDO();
            btnCerrarSesion = new Button();
            PanelContenedor = new Panel();
            PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            SuspendLayout();
            // 
            // PanelBarraTitulo
            // 
            PanelBarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            PanelBarraTitulo.Controls.Add(btnMinimizar);
            PanelBarraTitulo.Controls.Add(btnCerrar);
            PanelBarraTitulo.Controls.Add(btnRestaurar);
            PanelBarraTitulo.Controls.Add(btnMaximizar);
            PanelBarraTitulo.Dock = DockStyle.Top;
            PanelBarraTitulo.Location = new Point(0, 0);
            PanelBarraTitulo.Name = "PanelBarraTitulo";
            PanelBarraTitulo.Size = new Size(1300, 38);
            PanelBarraTitulo.TabIndex = 0;
            PanelBarraTitulo.MouseDown += PanelBarraTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1201, 10);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1263, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1232, 10);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 2;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1232, 10);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(26, 32, 40);
            PanelMenu.Controls.Add(btnReservas);
            PanelMenu.Controls.Add(btnCanchas);
            PanelMenu.Controls.Add(btnClientes);
            PanelMenu.Controls.Add(btnReportes);
            PanelMenu.Controls.Add(lblEmailApp);
            PanelMenu.Controls.Add(lblUsuarioApp);
            PanelMenu.Controls.Add(lblNombreApp);
            PanelMenu.Controls.Add(linkEditarPerfil);
            PanelMenu.Controls.Add(label3);
            PanelMenu.Controls.Add(label1);
            PanelMenu.Controls.Add(label2);
            PanelMenu.Controls.Add(picInicio);
            PanelMenu.Controls.Add(btnCerrarSesion);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 38);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(277, 612);
            PanelMenu.TabIndex = 1;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.FromArgb(26, 32, 40);
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservas.ForeColor = Color.White;
            btnReservas.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            btnReservas.IconColor = Color.White;
            btnReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReservas.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservas.Location = new Point(0, 157);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(271, 63);
            btnReservas.TabIndex = 13;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
            // 
            // btnCanchas
            // 
            btnCanchas.BackColor = Color.FromArgb(26, 32, 40);
            btnCanchas.FlatAppearance.BorderSize = 0;
            btnCanchas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCanchas.FlatStyle = FlatStyle.Flat;
            btnCanchas.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCanchas.ForeColor = Color.White;
            btnCanchas.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnCanchas.IconColor = Color.White;
            btnCanchas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCanchas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCanchas.Location = new Point(0, 98);
            btnCanchas.Name = "btnCanchas";
            btnCanchas.Size = new Size(271, 63);
            btnCanchas.TabIndex = 12;
            btnCanchas.Text = "Canchas";
            btnCanchas.UseVisualStyleBackColor = false;
            btnCanchas.Click += btnCanchas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            btnClientes.IconColor = Color.White;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(3, 32);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(271, 63);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(26, 32, 40);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.White;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            btnReportes.IconColor = Color.White;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(8, 226);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(271, 63);
            btnReportes.TabIndex = 0;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // lblEmailApp
            // 
            lblEmailApp.AutoSize = true;
            lblEmailApp.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmailApp.ForeColor = Color.White;
            lblEmailApp.Location = new Point(53, 472);
            lblEmailApp.Name = "lblEmailApp";
            lblEmailApp.Size = new Size(91, 21);
            lblEmailApp.TabIndex = 11;
            lblEmailApp.Text = "lblEmailApp";
            // 
            // lblUsuarioApp
            // 
            lblUsuarioApp.AutoSize = true;
            lblUsuarioApp.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioApp.ForeColor = Color.White;
            lblUsuarioApp.Location = new Point(81, 442);
            lblUsuarioApp.Name = "lblUsuarioApp";
            lblUsuarioApp.Size = new Size(107, 21);
            lblUsuarioApp.TabIndex = 10;
            lblUsuarioApp.Text = "lblUsuarioApp";
            // 
            // lblNombreApp
            // 
            lblNombreApp.AutoSize = true;
            lblNombreApp.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreApp.ForeColor = Color.White;
            lblNombreApp.Location = new Point(83, 411);
            lblNombreApp.Name = "lblNombreApp";
            lblNombreApp.Size = new Size(110, 21);
            lblNombreApp.TabIndex = 9;
            lblNombreApp.Text = "lblNombreApp";
            // 
            // linkEditarPerfil
            // 
            linkEditarPerfil.AutoSize = true;
            linkEditarPerfil.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkEditarPerfil.LinkColor = Color.White;
            linkEditarPerfil.Location = new Point(8, 520);
            linkEditarPerfil.Name = "linkEditarPerfil";
            linkEditarPerfil.Size = new Size(89, 19);
            linkEditarPerfil.TabIndex = 8;
            linkEditarPerfil.TabStop = true;
            linkEditarPerfil.Text = "Editar Perfil";
            linkEditarPerfil.LinkClicked += linkEditarPerfil_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 472);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 442);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 6;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 411);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            // 
            // picInicio
            // 
            picInicio.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picInicio.BorderColor = Color.RoyalBlue;
            picInicio.BorderColor2 = Color.HotPink;
            picInicio.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picInicio.BorderSize = 2;
            picInicio.GradientAngle = 50F;
            picInicio.Image = (Image)resources.GetObject("picInicio.Image");
            picInicio.Location = new Point(12, 295);
            picInicio.Name = "picInicio";
            picInicio.Size = new Size(99, 99);
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicio.TabIndex = 4;
            picInicio.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(3, 565);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(271, 44);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(49, 66, 82);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(277, 38);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1023, 612);
            PanelContenedor.TabIndex = 2;
            PanelContenedor.Paint += PanelContenedor_Paint;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(PanelContenedor);
            Controls.Add(PanelMenu);
            Controls.Add(PanelBarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBarraTitulo;
        private Panel PanelMenu;
        private Panel PanelContenedor;
        private PictureBox btnMinimizar;
        private PictureBox btnCerrar;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private Button btnCerrarSesion;
        private APP.PICTUREREDONDO picInicio;
        private Label lblEmailApp;
        private Label lblUsuarioApp;
        private Label lblNombreApp;
        private LinkLabel linkEditarPerfil;
        private Label label3;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnReservas;
        private FontAwesome.Sharp.IconButton btnCanchas;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnReportes;
    }
}