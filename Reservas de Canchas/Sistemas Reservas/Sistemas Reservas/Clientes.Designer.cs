namespace Sistemas_Reservas
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            lblId_Cliente = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            chkFijo = new CheckBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            errorCliente = new ErrorProvider(components);
            dt_clientes = new DataGridView();
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dt_clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // lblId_Cliente
            // 
            lblId_Cliente.AutoSize = true;
            lblId_Cliente.Location = new Point(996, 588);
            lblId_Cliente.Name = "lblId_Cliente";
            lblId_Cliente.Size = new Size(72, 15);
            lblId_Cliente.TabIndex = 0;
            lblId_Cliente.Text = "lblId_Cliente";
            lblId_Cliente.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 50);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 79);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 108);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 47);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 23);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(103, 76);
            txtApellido.MaxLength = 50;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(129, 23);
            txtApellido.TabIndex = 5;
            txtApellido.KeyPress += txtApellido_KeyPress;
            txtApellido.Validating += txtApellido_Validating;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(103, 105);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(129, 23);
            txtTelefono.TabIndex = 6;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            txtTelefono.Validating += txtTelefono_Validating;
            // 
            // chkFijo
            // 
            chkFijo.AutoSize = true;
            chkFijo.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkFijo.ForeColor = Color.White;
            chkFijo.Location = new Point(103, 134);
            chkFijo.Name = "chkFijo";
            chkFijo.Size = new Size(56, 25);
            chkFijo.TabIndex = 7;
            chkFijo.Text = "Fijo";
            chkFijo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(750, 97);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 34);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SeaGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnEditar.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(849, 50);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 34);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(632, 47);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 34);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // errorCliente
            // 
            errorCliente.ContainerControl = this;
            // 
            // dt_clientes
            // 
            dt_clientes.AllowUserToAddRows = false;
            dt_clientes.AllowUserToDeleteRows = false;
            dt_clientes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dt_clientes.BorderStyle = BorderStyle.None;
            dt_clientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dt_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dt_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dt_clientes.ColumnHeadersHeight = 30;
            dt_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dt_clientes.EnableHeadersVisualStyles = false;
            dt_clientes.GridColor = Color.SteelBlue;
            dt_clientes.Location = new Point(12, 229);
            dt_clientes.Name = "dt_clientes";
            dt_clientes.ReadOnly = true;
            dt_clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dt_clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dt_clientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dt_clientes.RowTemplate.Height = 25;
            dt_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_clientes.Size = new Size(755, 279);
            dt_clientes.TabIndex = 11;
            dt_clientes.CellContentClick += dt_clientes_CellContentClick;
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
            btnCerrar.TabIndex = 12;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 70);
            ClientSize = new Size(1080, 612);
            Controls.Add(btnCerrar);
            Controls.Add(dt_clientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(chkFijo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblId_Cliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)errorCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dt_clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId_Cliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private CheckBox chkFijo;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private ErrorProvider errorCliente;
        private DataGridView dt_clientes;
        private PictureBox btnCerrar;
    }
}