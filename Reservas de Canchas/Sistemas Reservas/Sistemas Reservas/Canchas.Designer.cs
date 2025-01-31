namespace Sistemas_Reservas
{
    partial class Canchas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Canchas));
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumero = new TextBox();
            txtCapacidad = new TextBox();
            txtPrecio = new TextBox();
            dt_canchas = new DataGridView();
            lblId_cancha = new Label();
            errorCanchas = new ErrorProvider(components);
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dt_canchas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCanchas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(538, 35);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SeaGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(770, 35);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 34);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(655, 75);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 3;
            label1.Text = "Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 64);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 4;
            label2.Text = "Capacidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 93);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 5;
            label3.Text = "Precio:";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(103, 32);
            txtNumero.MaxLength = 4;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(127, 26);
            txtNumero.TabIndex = 6;
            txtNumero.KeyPress += txtNumero_KeyPress;
            txtNumero.Validating += txtNumero_Validating;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapacidad.Location = new Point(103, 61);
            txtCapacidad.MaxLength = 2;
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(127, 26);
            txtCapacidad.TabIndex = 7;
            txtCapacidad.KeyPress += txtCapacidad_KeyPress;
            txtCapacidad.Validating += txtCapacidad_Validating;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(103, 90);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(127, 26);
            txtPrecio.TabIndex = 8;
            txtPrecio.Text = "0.00";
            txtPrecio.Click += txtPrecio_Click;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            txtPrecio.Validating += txtPrecio_Validating;
            txtPrecio.Validated += txtPrecio_Validated;
            // 
            // dt_canchas
            // 
            dt_canchas.AllowUserToAddRows = false;
            dt_canchas.AllowUserToDeleteRows = false;
            dt_canchas.BackgroundColor = Color.FromArgb(45, 66, 91);
            dt_canchas.BorderStyle = BorderStyle.None;
            dt_canchas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dt_canchas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dt_canchas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dt_canchas.ColumnHeadersHeight = 30;
            dt_canchas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dt_canchas.EnableHeadersVisualStyles = false;
            dt_canchas.GridColor = Color.SteelBlue;
            dt_canchas.Location = new Point(25, 194);
            dt_canchas.Name = "dt_canchas";
            dt_canchas.ReadOnly = true;
            dt_canchas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dt_canchas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dt_canchas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dt_canchas.RowTemplate.Height = 25;
            dt_canchas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_canchas.Size = new Size(864, 279);
            dt_canchas.TabIndex = 9;
            dt_canchas.CellContentClick += dt_canchas_CellContentClick;
            // 
            // lblId_cancha
            // 
            lblId_cancha.AutoSize = true;
            lblId_cancha.Location = new Point(995, 588);
            lblId_cancha.Name = "lblId_cancha";
            lblId_cancha.Size = new Size(73, 15);
            lblId_cancha.TabIndex = 10;
            lblId_cancha.Text = "lblId_cancha";
            lblId_cancha.Visible = false;
            // 
            // errorCanchas
            // 
            errorCanchas.ContainerControl = this;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1043, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 11;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Canchas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 70);
            ClientSize = new Size(1080, 612);
            Controls.Add(btnCerrar);
            Controls.Add(lblId_cancha);
            Controls.Add(dt_canchas);
            Controls.Add(txtPrecio);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Canchas";
            Text = "Canchas";
            Load += Canchas_Load;
            ((System.ComponentModel.ISupportInitialize)dt_canchas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCanchas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero;
        private TextBox txtCapacidad;
        private TextBox txtPrecio;
        private DataGridView dt_canchas;
        private Label lblId_cancha;
        private ErrorProvider errorCanchas;
        private PictureBox btnCerrar;
    }
}