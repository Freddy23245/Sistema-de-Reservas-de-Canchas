namespace Sistemas_Reservas
{
    partial class Recuperar_Contraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar_Contraseña));
            gbxDatos = new GroupBox();
            btnEnviarMail = new Button();
            txtEmail = new TextBox();
            lblResultado = new Label();
            label1 = new Label();
            btnCerrar = new PictureBox();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // gbxDatos
            // 
            gbxDatos.BackColor = Color.FromArgb(45, 66, 91);
            gbxDatos.Controls.Add(btnEnviarMail);
            gbxDatos.Controls.Add(txtEmail);
            gbxDatos.Controls.Add(lblResultado);
            gbxDatos.Controls.Add(label1);
            gbxDatos.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            gbxDatos.ForeColor = Color.White;
            gbxDatos.Location = new Point(9, 48);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(975, 388);
            gbxDatos.TabIndex = 0;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Ingresar Email";
            // 
            // btnEnviarMail
            // 
            btnEnviarMail.BackColor = Color.SeaGreen;
            btnEnviarMail.FlatAppearance.BorderSize = 0;
            btnEnviarMail.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnEnviarMail.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnEnviarMail.FlatStyle = FlatStyle.Flat;
            btnEnviarMail.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviarMail.ForeColor = Color.White;
            btnEnviarMail.Location = new Point(461, 76);
            btnEnviarMail.Name = "btnEnviarMail";
            btnEnviarMail.Size = new Size(119, 34);
            btnEnviarMail.TabIndex = 27;
            btnEnviarMail.Text = "Enviar Mail";
            btnEnviarMail.UseVisualStyleBackColor = false;
            btnEnviarMail.Click += btnEnviarMail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(26, 82);
            txtEmail.MaxLength = 30;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(400, 26);
            txtEmail.TabIndex = 22;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.White;
            lblResultado.Location = new Point(26, 123);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 21);
            lblResultado.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(962, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Recuperar_Contraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 80, 200);
            ClientSize = new Size(999, 453);
            Controls.Add(btnCerrar);
            Controls.Add(gbxDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Recuperar_Contraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar_Contraseña";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDatos;
        private Label lblResultado;
        private Label label1;
        private TextBox txtEmail;
        private Button btnEnviarMail;
        private PictureBox btnCerrar;
    }
}