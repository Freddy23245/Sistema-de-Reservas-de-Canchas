﻿namespace Sistemas_Reservas
{
    partial class Reservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservas));
            mcFechas = new MonthCalendar();
            cboClientes = new ComboBox();
            cboCanchas = new ComboBox();
            cboHorarios = new ComboBox();
            lblCliente = new Label();
            lblCanchas = new Label();
            lblHorarios = new Label();
            ListHorarios = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lblId_Reserva = new Label();
            lblFecha = new Label();
            gbxAcciones = new GroupBox();
            btnEditar = new Button();
            chkConcluido = new CheckBox();
            label1 = new Label();
            txtAnticipo = new TextBox();
            dt_reservas = new DataGridView();
            ListCanchas = new ListBox();
            label2 = new Label();
            btnCerrar = new PictureBox();
            errorReserva = new ErrorProvider(components);
            lblTotalAPAgar = new Label();
            label3 = new Label();
            gbxAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt_reservas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorReserva).BeginInit();
            SuspendLayout();
            // 
            // mcFechas
            // 
            mcFechas.BackColor = Color.FromArgb(45, 66, 91);
            mcFechas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mcFechas.Location = new Point(52, 297);
            mcFechas.Margin = new Padding(13, 15, 13, 15);
            mcFechas.Name = "mcFechas";
            mcFechas.TabIndex = 0;
            mcFechas.DateChanged += mcFechas_DateChanged;
            mcFechas.DateSelected += mcFechas_DateSelected;
            // 
            // cboClientes
            // 
            cboClientes.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(124, 20);
            cboClientes.Margin = new Padding(4, 5, 4, 5);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(225, 37);
            cboClientes.TabIndex = 1;
            // 
            // cboCanchas
            // 
            cboCanchas.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboCanchas.FormattingEnabled = true;
            cboCanchas.Location = new Point(124, 128);
            cboCanchas.Margin = new Padding(4, 5, 4, 5);
            cboCanchas.Name = "cboCanchas";
            cboCanchas.Size = new Size(225, 37);
            cboCanchas.TabIndex = 2;
            cboCanchas.SelectedIndexChanged += cboCanchas_SelectedIndexChanged;
            // 
            // cboHorarios
            // 
            cboHorarios.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboHorarios.FormattingEnabled = true;
            cboHorarios.Location = new Point(124, 75);
            cboHorarios.Margin = new Padding(4, 5, 4, 5);
            cboHorarios.Name = "cboHorarios";
            cboHorarios.Size = new Size(225, 37);
            cboHorarios.TabIndex = 3;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.White;
            lblCliente.Location = new Point(29, 25);
            lblCliente.Margin = new Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(99, 32);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente:";
            // 
            // lblCanchas
            // 
            lblCanchas.AutoSize = true;
            lblCanchas.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCanchas.ForeColor = Color.White;
            lblCanchas.Location = new Point(14, 135);
            lblCanchas.Margin = new Padding(4, 0, 4, 0);
            lblCanchas.Name = "lblCanchas";
            lblCanchas.Size = new Size(112, 32);
            lblCanchas.TabIndex = 5;
            lblCanchas.Text = "Canchas:";
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorarios.ForeColor = Color.White;
            lblHorarios.Location = new Point(10, 80);
            lblHorarios.Margin = new Padding(4, 0, 4, 0);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(118, 32);
            lblHorarios.TabIndex = 6;
            lblHorarios.Text = "Horarios:";
            // 
            // ListHorarios
            // 
            ListHorarios.BackColor = Color.FromArgb(45, 66, 91);
            ListHorarios.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ListHorarios.ForeColor = Color.White;
            ListHorarios.FormattingEnabled = true;
            ListHorarios.ItemHeight = 45;
            ListHorarios.Location = new Point(926, 25);
            ListHorarios.Margin = new Padding(4, 5, 4, 5);
            ListHorarios.Name = "ListHorarios";
            ListHorarios.Size = new Size(372, 409);
            ListHorarios.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.CheckedBackColor = Color.LightGreen;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(17, 63);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 63);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.SeaGreen;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.CheckedBackColor = Color.LightGreen;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(327, 63);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 63);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblId_Reserva
            // 
            lblId_Reserva.AutoSize = true;
            lblId_Reserva.Location = new Point(1586, 985);
            lblId_Reserva.Margin = new Padding(4, 0, 4, 0);
            lblId_Reserva.Name = "lblId_Reserva";
            lblId_Reserva.Size = new Size(114, 25);
            lblId_Reserva.TabIndex = 12;
            lblId_Reserva.Text = "lblId_Reserva";
            lblId_Reserva.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(1639, 1032);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(57, 25);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha";
            lblFecha.Visible = false;
            // 
            // gbxAcciones
            // 
            gbxAcciones.Controls.Add(btnEditar);
            gbxAcciones.Controls.Add(btnEliminar);
            gbxAcciones.Controls.Add(btnAgregar);
            gbxAcciones.ForeColor = Color.White;
            gbxAcciones.Location = new Point(380, 19);
            gbxAcciones.Margin = new Padding(4, 5, 4, 5);
            gbxAcciones.Name = "gbxAcciones";
            gbxAcciones.Padding = new Padding(4, 5, 4, 5);
            gbxAcciones.Size = new Size(500, 167);
            gbxAcciones.TabIndex = 14;
            gbxAcciones.TabStop = false;
            gbxAcciones.Text = "Acciones";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SeaGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.CheckedBackColor = Color.LightGreen;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(174, 63);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(144, 63);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // chkConcluido
            // 
            chkConcluido.AutoSize = true;
            chkConcluido.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkConcluido.ForeColor = Color.White;
            chkConcluido.Location = new Point(124, 245);
            chkConcluido.Margin = new Padding(4, 5, 4, 5);
            chkConcluido.Name = "chkConcluido";
            chkConcluido.Size = new Size(169, 44);
            chkConcluido.TabIndex = 15;
            chkConcluido.Text = "Concluido";
            chkConcluido.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 190);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 16;
            label1.Text = "Anticipo:";
            // 
            // txtAnticipo
            // 
            txtAnticipo.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAnticipo.Location = new Point(124, 183);
            txtAnticipo.Margin = new Padding(4, 5, 4, 5);
            txtAnticipo.MaxLength = 5;
            txtAnticipo.Name = "txtAnticipo";
            txtAnticipo.Size = new Size(225, 39);
            txtAnticipo.TabIndex = 17;
            txtAnticipo.Text = "0.00";
            txtAnticipo.Click += txtAnticipo_Click;
            txtAnticipo.TextChanged += txtAnticipo_TextChanged;
            txtAnticipo.KeyPress += txtAnticipo_KeyPress;
            txtAnticipo.Validating += txtAnticipo_Validating;
            txtAnticipo.Validated += txtAnticipo_Validated;
            // 
            // dt_reservas
            // 
            dt_reservas.AllowUserToAddRows = false;
            dt_reservas.AllowUserToDeleteRows = false;
            dt_reservas.BackgroundColor = Color.FromArgb(45, 66, 91);
            dt_reservas.BorderStyle = BorderStyle.None;
            dt_reservas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dt_reservas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dt_reservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dt_reservas.ColumnHeadersHeight = 30;
            dt_reservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dt_reservas.EnableHeadersVisualStyles = false;
            dt_reservas.GridColor = Color.SteelBlue;
            dt_reservas.Location = new Point(11, 570);
            dt_reservas.Margin = new Padding(4, 5, 4, 5);
            dt_reservas.Name = "dt_reservas";
            dt_reservas.ReadOnly = true;
            dt_reservas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dt_reservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dt_reservas.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dt_reservas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dt_reservas.RowTemplate.Height = 25;
            dt_reservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt_reservas.Size = new Size(1139, 323);
            dt_reservas.TabIndex = 18;
            dt_reservas.CellContentClick += dt_reservas_CellContentClick;
            // 
            // ListCanchas
            // 
            ListCanchas.BackColor = Color.FromArgb(45, 66, 91);
            ListCanchas.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ListCanchas.ForeColor = Color.White;
            ListCanchas.FormattingEnabled = true;
            ListCanchas.ItemHeight = 40;
            ListCanchas.Location = new Point(514, 257);
            ListCanchas.Margin = new Padding(4, 5, 4, 5);
            ListCanchas.Name = "ListCanchas";
            ListCanchas.SelectionMode = SelectionMode.None;
            ListCanchas.Size = new Size(337, 124);
            ListCanchas.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(510, 200);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(349, 35);
            label2.TabIndex = 20;
            label2.Text = "Cancha - Capacidad - Precio";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1494, 10);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 42);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 23;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // errorReserva
            // 
            errorReserva.ContainerControl = this;
            // 
            // lblTotalAPAgar
            // 
            lblTotalAPAgar.AutoSize = true;
            lblTotalAPAgar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAPAgar.ForeColor = Color.White;
            lblTotalAPAgar.Location = new Point(749, 491);
            lblTotalAPAgar.Margin = new Padding(4, 0, 4, 0);
            lblTotalAPAgar.Name = "lblTotalAPAgar";
            lblTotalAPAgar.Size = new Size(42, 45);
            lblTotalAPAgar.TabIndex = 25;
            lblTotalAPAgar.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(510, 491);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(251, 45);
            label3.TabIndex = 24;
            label3.Text = "Total A Pagar:";
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 70);
            ClientSize = new Size(1543, 1020);
            Controls.Add(lblTotalAPAgar);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(label2);
            Controls.Add(ListCanchas);
            Controls.Add(dt_reservas);
            Controls.Add(txtAnticipo);
            Controls.Add(label1);
            Controls.Add(chkConcluido);
            Controls.Add(gbxAcciones);
            Controls.Add(lblFecha);
            Controls.Add(lblId_Reserva);
            Controls.Add(ListHorarios);
            Controls.Add(lblHorarios);
            Controls.Add(lblCanchas);
            Controls.Add(lblCliente);
            Controls.Add(cboHorarios);
            Controls.Add(cboCanchas);
            Controls.Add(cboClientes);
            Controls.Add(mcFechas);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Reservas";
            Text = "Reservas";
            Load += Reservas_Load;
            gbxAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dt_reservas).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar mcFechas;
        private ComboBox cboClientes;
        private ComboBox cboCanchas;
        private ComboBox cboHorarios;
        private Label lblCliente;
        private Label lblCanchas;
        private Label lblHorarios;
        private ListBox ListHorarios;
        private Button btnAgregar;
        private Button btnEliminar;
        private Label lblId_Reserva;
        private Label lblFecha;
        private GroupBox gbxAcciones;
        private Button btnEditar;
        private CheckBox chkConcluido;
        private Label label1;
        private TextBox txtAnticipo;
        private DataGridView dt_reservas;
        private ListBox ListCanchas;
        private Label label2;
        private PictureBox btnCerrar;
        private ErrorProvider errorReserva;
        private Label lblTotalAPAgar;
        private Label label3;
    }
}