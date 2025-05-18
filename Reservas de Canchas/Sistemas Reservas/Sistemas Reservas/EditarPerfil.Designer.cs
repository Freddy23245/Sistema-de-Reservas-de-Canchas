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
            pDatos.Location = new Point(802, 0);
            pDatos.Margin = new Padding(4, 5, 4, 5);
            pDatos.Name = "pDatos";
            pDatos.Size = new Size(741, 1020);
            pDatos.TabIndex = 0;
            pDatos.Visible = false;
            // 
            // linkCambiarContraseña
            // 
            linkCambiarContraseña.AutoSize = true;
            linkCambiarContraseña.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkCambiarContraseña.ForeColor = Color.White;
            linkCambiarContraseña.LinkColor = Color.White;
            linkCambiarContraseña.Location = new Point(191, 508);
            linkCambiarContraseña.Margin = new Padding(4, 0, 4, 0);
            linkCambiarContraseña.Name = "linkCambiarContraseña";
            linkCambiarContraseña.Size = new Size(108, 35);
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
            btnCancelar.Location = new Point(124, 875);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 57);
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
            btnGuardar.Location = new Point(401, 875);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 57);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseñaActual.Location = new Point(47, 772);
            txtContraseñaActual.Margin = new Padding(4, 5, 4, 5);
            txtContraseñaActual.MaxLength = 255;
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(570, 35);
            txtContraseñaActual.TabIndex = 24;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarContraseña.Location = new Point(47, 655);
            txtConfirmarContraseña.Margin = new Padding(4, 5, 4, 5);
            txtConfirmarContraseña.MaxLength = 255;
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(570, 35);
            txtConfirmarContraseña.TabIndex = 23;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(47, 558);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.MaxLength = 255;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(570, 35);
            txtContraseña.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(47, 457);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(570, 35);
            txtEmail.TabIndex = 21;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(47, 355);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(570, 35);
            txtApellido.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(47, 255);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(570, 35);
            txtNombre.TabIndex = 19;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(47, 160);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 30;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(570, 35);
            txtUsuario.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(47, 718);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(227, 32);
            label12.TabIndex = 17;
            label12.Text = "Contraseña Actual:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(47, 413);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(81, 32);
            label11.TabIndex = 16;
            label11.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(47, 613);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(265, 32);
            label10.TabIndex = 15;
            label10.Text = "Confirmar Contraseña:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(47, 513);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(146, 32);
            label9.TabIndex = 14;
            label9.Text = "Contraseña:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(47, 313);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 32);
            label8.TabIndex = 13;
            label8.Text = "Apellido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(47, 210);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 32);
            label7.TabIndex = 12;
            label7.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(47, 117);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 32);
            label6.TabIndex = 11;
            label6.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(261, 20);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(224, 58);
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
            picPerfil.Location = new Point(17, 20);
            picPerfil.Margin = new Padding(4, 5, 4, 5);
            picPerfil.Name = "picPerfil";
            picPerfil.Size = new Size(300, 300);
            picPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            picPerfil.TabIndex = 1;
            picPerfil.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(391, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(393, 197);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(390, 305);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(399, 405);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 32);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // lblUsuarioApp
            // 
            lblUsuarioApp.AutoSize = true;
            lblUsuarioApp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuarioApp.ForeColor = Color.Black;
            lblUsuarioApp.Location = new Point(397, 135);
            lblUsuarioApp.Margin = new Padding(4, 0, 4, 0);
            lblUsuarioApp.Name = "lblUsuarioApp";
            lblUsuarioApp.Size = new Size(171, 33);
            lblUsuarioApp.TabIndex = 6;
            lblUsuarioApp.Text = "lblUsuarioApp";
            // 
            // lblNombreApp
            // 
            lblNombreApp.AutoSize = true;
            lblNombreApp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreApp.ForeColor = Color.Black;
            lblNombreApp.Location = new Point(391, 253);
            lblNombreApp.Margin = new Padding(4, 0, 4, 0);
            lblNombreApp.Name = "lblNombreApp";
            lblNombreApp.Size = new Size(174, 33);
            lblNombreApp.TabIndex = 7;
            lblNombreApp.Text = "lblNombreApp";
            // 
            // lblApllidoApp
            // 
            lblApllidoApp.AutoSize = true;
            lblApllidoApp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApllidoApp.ForeColor = Color.Black;
            lblApllidoApp.Location = new Point(396, 362);
            lblApllidoApp.Margin = new Padding(4, 0, 4, 0);
            lblApllidoApp.Name = "lblApllidoApp";
            lblApllidoApp.Size = new Size(164, 33);
            lblApllidoApp.TabIndex = 8;
            lblApllidoApp.Text = "lblApllidoApp";
            // 
            // lblEmailApp
            // 
            lblEmailApp.AutoSize = true;
            lblEmailApp.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailApp.ForeColor = Color.Black;
            lblEmailApp.Location = new Point(397, 462);
            lblEmailApp.Margin = new Padding(4, 0, 4, 0);
            lblEmailApp.Name = "lblEmailApp";
            lblEmailApp.Size = new Size(145, 33);
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
            btnAgregarImagen.Location = new Point(29, 413);
            btnAgregarImagen.Margin = new Padding(4, 5, 4, 5);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(289, 57);
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
            linkEditarPerfil.Location = new Point(224, 820);
            linkEditarPerfil.Margin = new Padding(4, 0, 4, 0);
            linkEditarPerfil.Name = "linkEditarPerfil";
            linkEditarPerfil.Size = new Size(193, 40);
            linkEditarPerfil.TabIndex = 26;
            linkEditarPerfil.TabStop = true;
            linkEditarPerfil.Text = "Editar Perfil";
            linkEditarPerfil.LinkClicked += linkEditarPerfil_LinkClicked;
            // 
            // EditarPerfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1543, 1020);
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
            Margin = new Padding(4, 5, 4, 5);
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