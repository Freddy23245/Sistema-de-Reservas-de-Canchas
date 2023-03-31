namespace Sistemas_Reservas
{
    partial class EditarPerfil
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
            pDatos = new Panel();
            linkCambiarContraseña = new LinkLabel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtContraseñaActual = new TextBox();
            txtConfirmarContraseña = new TextBox();
            txtContraseña = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            picPerfil = new APP.PICTUREREDONDO();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblUsuarioApp = new Label();
            lblNombreApp = new Label();
            lblApllidoApp = new Label();
            lblEmailApp = new Label();
            btnAgregarImagen = new Button();
            linkEditarPerfil = new LinkLabel();
            pDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPerfil).BeginInit();
            SuspendLayout();
            // 
            // pDatos
            // 
            pDatos.BackColor = Color.FromArgb(45, 66, 91);
            pDatos.Controls.Add(linkCambiarContraseña);
            pDatos.Controls.Add(btnCancelar);
            pDatos.Controls.Add(btnGuardar);
            pDatos.Controls.Add(txtContraseñaActual);
            pDatos.Controls.Add(txtConfirmarContraseña);
            pDatos.Controls.Add(txtContraseña);
            pDatos.Controls.Add(txtEmail);
            pDatos.Controls.Add(txtApellido);
            pDatos.Controls.Add(txtNombre);
            pDatos.Controls.Add(txtUsuario);
            pDatos.Controls.Add(label12);
            pDatos.Controls.Add(label11);
            pDatos.Controls.Add(label10);
            pDatos.Controls.Add(label9);
            pDatos.Controls.Add(label8);
            pDatos.Controls.Add(label7);
            pDatos.Controls.Add(label6);
            pDatos.Controls.Add(label5);
            pDatos.Dock = DockStyle.Right;
            pDatos.Location = new Point(561, 0);
            pDatos.Name = "pDatos";
            pDatos.Size = new Size(519, 612);
            pDatos.TabIndex = 0;
            pDatos.Visible = false;
            // 
            // linkCambiarContraseña
            // 
            linkCambiarContraseña.AutoSize = true;
            linkCambiarContraseña.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkCambiarContraseña.ForeColor = Color.White;
            linkCambiarContraseña.LinkColor = Color.White;
            linkCambiarContraseña.Location = new Point(134, 305);
            linkCambiarContraseña.Name = "linkCambiarContraseña";
            linkCambiarContraseña.Size = new Size(72, 23);
            linkCambiarContraseña.TabIndex = 27;
            linkCambiarContraseña.TabStop = true;
            linkCambiarContraseña.Text = "Cambiar";
            linkCambiarContraseña.LinkClicked += linkCambiarContraseña_LinkClicked;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(87, 525);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 34);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SeaGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(281, 525);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 34);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseñaActual.Location = new Point(33, 463);
            txtContraseñaActual.MaxLength = 255;
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(400, 26);
            txtContraseñaActual.TabIndex = 24;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarContraseña.Location = new Point(33, 393);
            txtConfirmarContraseña.MaxLength = 255;
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(400, 26);
            txtConfirmarContraseña.TabIndex = 23;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(33, 335);
            txtContraseña.MaxLength = 255;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(400, 26);
            txtContraseña.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(33, 274);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 26);
            txtEmail.TabIndex = 21;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(33, 213);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(400, 26);
            txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(33, 153);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 26);
            txtNombre.TabIndex = 19;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(33, 96);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(400, 26);
            txtUsuario.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(33, 431);
            label12.Name = "label12";
            label12.Size = new Size(148, 21);
            label12.TabIndex = 17;
            label12.Text = "Contraseña Actual:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(33, 248);
            label11.Name = "label11";
            label11.Size = new Size(54, 21);
            label11.TabIndex = 16;
            label11.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(33, 368);
            label10.Name = "label10";
            label10.Size = new Size(173, 21);
            label10.TabIndex = 15;
            label10.Text = "Confirmar Contraseña:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(33, 308);
            label9.Name = "label9";
            label9.Size = new Size(95, 21);
            label9.TabIndex = 14;
            label9.Text = "Contraseña:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(33, 188);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 13;
            label8.Text = "Apellido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(33, 126);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 12;
            label7.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(33, 70);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 11;
            label6.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(183, 12);
            label5.Name = "label5";
            label5.Size = new Size(148, 38);
            label5.TabIndex = 10;
            label5.Text = "Mis Datos";
            // 
            // picPerfil
            // 
            picPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picPerfil.BorderColor = Color.RoyalBlue;
            picPerfil.BorderColor2 = Color.HotPink;
            picPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picPerfil.BorderSize = 2;
            picPerfil.GradientAngle = 50F;
            picPerfil.Location = new Point(12, 12);
            picPerfil.Name = "picPerfil";
            picPerfil.Size = new Size(210, 210);
            picPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            picPerfil.TabIndex = 1;
            picPerfil.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(274, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(275, 118);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(273, 183);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(279, 243);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // lblUsuarioApp
            // 
            lblUsuarioApp.AutoSize = true;
            lblUsuarioApp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuarioApp.ForeColor = Color.Black;
            lblUsuarioApp.Location = new Point(278, 81);
            lblUsuarioApp.Name = "lblUsuarioApp";
            lblUsuarioApp.Size = new Size(116, 23);
            lblUsuarioApp.TabIndex = 6;
            lblUsuarioApp.Text = "lblUsuarioApp";
            // 
            // lblNombreApp
            // 
            lblNombreApp.AutoSize = true;
            lblNombreApp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreApp.ForeColor = Color.Black;
            lblNombreApp.Location = new Point(274, 152);
            lblNombreApp.Name = "lblNombreApp";
            lblNombreApp.Size = new Size(118, 23);
            lblNombreApp.TabIndex = 7;
            lblNombreApp.Text = "lblNombreApp";
            // 
            // lblApllidoApp
            // 
            lblApllidoApp.AutoSize = true;
            lblApllidoApp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApllidoApp.ForeColor = Color.Black;
            lblApllidoApp.Location = new Point(277, 217);
            lblApllidoApp.Name = "lblApllidoApp";
            lblApllidoApp.Size = new Size(113, 23);
            lblApllidoApp.TabIndex = 8;
            lblApllidoApp.Text = "lblApllidoApp";
            // 
            // lblEmailApp
            // 
            lblEmailApp.AutoSize = true;
            lblEmailApp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailApp.ForeColor = Color.Black;
            lblEmailApp.Location = new Point(278, 277);
            lblEmailApp.Name = "lblEmailApp";
            lblEmailApp.Size = new Size(99, 23);
            lblEmailApp.TabIndex = 9;
            lblEmailApp.Text = "lblEmailApp";
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.BackColor = Color.SeaGreen;
            btnAgregarImagen.FlatAppearance.BorderSize = 0;
            btnAgregarImagen.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnAgregarImagen.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnAgregarImagen.FlatStyle = FlatStyle.Flat;
            btnAgregarImagen.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarImagen.ForeColor = Color.White;
            btnAgregarImagen.Location = new Point(20, 248);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(202, 34);
            btnAgregarImagen.TabIndex = 25;
            btnAgregarImagen.Text = "Agregar Imagen";
            btnAgregarImagen.UseVisualStyleBackColor = false;
            btnAgregarImagen.Visible = false;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // linkEditarPerfil
            // 
            linkEditarPerfil.AutoSize = true;
            linkEditarPerfil.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkEditarPerfil.LinkColor = Color.Black;
            linkEditarPerfil.Location = new Point(157, 492);
            linkEditarPerfil.Name = "linkEditarPerfil";
            linkEditarPerfil.Size = new Size(127, 27);
            linkEditarPerfil.TabIndex = 26;
            linkEditarPerfil.TabStop = true;
            linkEditarPerfil.Text = "Editar Perfil";
            linkEditarPerfil.LinkClicked += linkEditarPerfil_LinkClicked;
            // 
            // EditarPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 612);
            Controls.Add(linkEditarPerfil);
            Controls.Add(btnAgregarImagen);
            Controls.Add(lblEmailApp);
            Controls.Add(lblApllidoApp);
            Controls.Add(lblNombreApp);
            Controls.Add(lblUsuarioApp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(picPerfil);
            Controls.Add(pDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarPerfil";
            Text = "EditarPerfil";
            Load += EditarPerfil_Load;
            pDatos.ResumeLayout(false);
            pDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pDatos;
        private APP.PICTUREREDONDO picPerfil;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblUsuarioApp;
        private Label lblNombreApp;
        private Label lblApllidoApp;
        private Label lblEmailApp;
        private TextBox txtContraseñaActual;
        private TextBox txtConfirmarContraseña;
        private TextBox txtContraseña;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnAgregarImagen;
        private LinkLabel linkEditarPerfil;
        private LinkLabel linkCambiarContraseña;
    }
}