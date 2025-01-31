namespace Sistemas_Reservas
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnIngresar = new Button();
            txt_usuario = new TextBox();
            txt_contraseña = new TextBox();
            picLogin = new APP.PICTUREREDONDO();
            lblErrorMensaje = new Label();
            pLogin = new Panel();
            label1 = new Label();
            btnCerrar = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.SeaGreen;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(269, 154);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(364, 51);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_usuario.ForeColor = Color.Silver;
            txt_usuario.Location = new Point(274, 48);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(359, 28);
            txt_usuario.TabIndex = 2;
            txt_usuario.Text = "USUARIO";
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            txt_usuario.Enter += txt_usuario_Enter;
            txt_usuario.Leave += txt_usuario_Leave;
            txt_usuario.Validating += txt_usuario_Validating;
            // 
            // txt_contraseña
            // 
            txt_contraseña.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_contraseña.ForeColor = Color.Silver;
            txt_contraseña.Location = new Point(274, 77);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(359, 28);
            txt_contraseña.TabIndex = 3;
            txt_contraseña.Text = "CONTRASEÑA";
            txt_contraseña.Enter += txt_contraseña_Enter;
            txt_contraseña.Leave += txt_contraseña_Leave;
            // 
            // picLogin
            // 
            picLogin.BackColor = Color.FromArgb(45, 66, 91);
            picLogin.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picLogin.BorderColor = Color.RoyalBlue;
            picLogin.BorderColor2 = Color.HotPink;
            picLogin.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picLogin.BorderSize = 2;
            picLogin.GradientAngle = 50F;
            picLogin.Location = new Point(45, 31);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(129, 129);
            picLogin.SizeMode = PictureBoxSizeMode.Zoom;
            picLogin.TabIndex = 6;
            picLogin.TabStop = false;
            // 
            // lblErrorMensaje
            // 
            lblErrorMensaje.AutoSize = true;
            lblErrorMensaje.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorMensaje.ForeColor = Color.White;
            lblErrorMensaje.ImageAlign = ContentAlignment.MiddleRight;
            lblErrorMensaje.Location = new Point(251, 108);
            lblErrorMensaje.Name = "lblErrorMensaje";
            lblErrorMensaje.RightToLeft = RightToLeft.No;
            lblErrorMensaje.Size = new Size(123, 21);
            lblErrorMensaje.TabIndex = 7;
            lblErrorMensaje.Text = "lblErrorMensaje";
            lblErrorMensaje.Visible = false;
            // 
            // pLogin
            // 
            pLogin.BackColor = Color.FromArgb(0, 80, 200);
            pLogin.Controls.Add(label1);
            pLogin.Controls.Add(picLogin);
            pLogin.Dock = DockStyle.Left;
            pLogin.Location = new Point(0, 0);
            pLogin.Name = "pLogin";
            pLogin.Size = new Size(245, 298);
            pLogin.TabIndex = 8;
            pLogin.MouseDown += pLogin_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 191);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 9;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(645, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 13;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(340, 225);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(215, 27);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar Contraseña";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(682, 298);
            Controls.Add(linkLabel1);
            Controls.Add(btnCerrar);
            Controls.Add(pLogin);
            Controls.Add(lblErrorMensaje);
            Controls.Add(txt_contraseña);
            Controls.Add(txt_usuario);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            pLogin.ResumeLayout(false);
            pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txt_usuario;
        private TextBox txt_contraseña;
        private APP.PICTUREREDONDO picLogin;
        private Label lblErrorMensaje;
        private Panel pLogin;
        private Label label1;
        private PictureBox btnCerrar;
        private LinkLabel linkLabel1;
    }
}