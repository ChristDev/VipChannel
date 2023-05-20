namespace VipChannel.Front.Definitions
{
    partial class FrmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            this.dgvDatosRegistrados = new Controles_Standar.FDataGridView();
            this.vEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fGroupBox3 = new Controles_Standar.FGroupBox();
            this.btnAsignarCaja = new Controles_Standar.FButtonReporte();
            this.btnEliminar = new Controles_Standar.FButtonEliminar();
            this.btnCancelar = new Controles_Standar.FButtonCancelar();
            this.btnGuardar = new Controles_Standar.FButtonGuardar();
            this.btnEditar = new Controles_Standar.FButtonEditar();
            this.btnNuevo = new Controles_Standar.FButtonNuevo();
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.chkCambiarPassword = new Controles_Standar.FCheckBox();
            this.txtPassword = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium6 = new Controles_Standar.FLabelMedium();
            this.cboRole = new Controles_Standar.FComboBox();
            this.fLabelMedium5 = new Controles_Standar.FLabelMedium();
            this.cboTypeDocument = new Controles_Standar.FComboBox();
            this.selectResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNames = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium4 = new Controles_Standar.FLabelMedium();
            this.txtLastName = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium3 = new Controles_Standar.FLabelMedium();
            this.txtDocumentNumber = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium2 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.fGroupBox3.SuspendLayout();
            this.fGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fGroupBox2
            // 
            this.fGroupBox2.Controls.Add(this.dgvDatosRegistrados);
            this.fGroupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox2.Location = new System.Drawing.Point(510, 63);
            this.fGroupBox2.Name = "fGroupBox2";
            this.fGroupBox2.Size = new System.Drawing.Size(622, 312);
            this.fGroupBox2.TabIndex = 4;
            this.fGroupBox2.TabStop = false;
            this.fGroupBox2.Text = "Repositorio de Datos";
            // 
            // dgvDatosRegistrados
            // 
            this.dgvDatosRegistrados.AllowUserToAddRows = false;
            this.dgvDatosRegistrados.AllowUserToDeleteRows = false;
            this.dgvDatosRegistrados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatosRegistrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosRegistrados.AutoGenerateColumns = false;
            this.dgvDatosRegistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosRegistrados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDatosRegistrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvDatosRegistrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosRegistrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn});
            this.dgvDatosRegistrados.DataSource = this.vEmpleadoBindingSource;
            this.dgvDatosRegistrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosRegistrados.EnableHeadersVisualStyles = false;
            this.dgvDatosRegistrados.Location = new System.Drawing.Point(3, 19);
            this.dgvDatosRegistrados.MultiSelect = false;
            this.dgvDatosRegistrados.Name = "dgvDatosRegistrados";
            this.dgvDatosRegistrados.ReadOnly = true;
            this.dgvDatosRegistrados.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatosRegistrados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosRegistrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosRegistrados.Size = new System.Drawing.Size(616, 290);
            this.dgvDatosRegistrados.TabIndex = 0;
            // 
            // vEmpleadoBindingSource
            // 
            this.vEmpleadoBindingSource.DataSource = typeof(VipChannel.Domain.Entity.vEmpleado);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(VipChannel.Domain.Entity.Role);
            // 
            // fGroupBox3
            // 
            this.fGroupBox3.Controls.Add(this.btnAsignarCaja);
            this.fGroupBox3.Controls.Add(this.btnEliminar);
            this.fGroupBox3.Controls.Add(this.btnCancelar);
            this.fGroupBox3.Controls.Add(this.btnGuardar);
            this.fGroupBox3.Controls.Add(this.btnEditar);
            this.fGroupBox3.Controls.Add(this.btnNuevo);
            this.fGroupBox3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox3.Location = new System.Drawing.Point(513, 381);
            this.fGroupBox3.Name = "fGroupBox3";
            this.fGroupBox3.Size = new System.Drawing.Size(619, 64);
            this.fGroupBox3.TabIndex = 3;
            this.fGroupBox3.TabStop = false;
            this.fGroupBox3.Text = "Acciones del Formulario";
            // 
            // btnAsignarCaja
            // 
            this.btnAsignarCaja.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarCaja.Image")));
            this.btnAsignarCaja.Location = new System.Drawing.Point(492, 22);
            this.btnAsignarCaja.Name = "btnAsignarCaja";
            this.btnAsignarCaja.Size = new System.Drawing.Size(114, 34);
            this.btnAsignarCaja.TabIndex = 6;
            this.btnAsignarCaja.Text = "Asignar Cajas";
            this.btnAsignarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsignarCaja.UseVisualStyleBackColor = true;
            this.btnAsignarCaja.Click += new System.EventHandler(this.btnAsignarCaja_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(204, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "El&iminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(396, 22);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(300, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 34);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(108, 22);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 34);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 34);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Controls.Add(this.chkCambiarPassword);
            this.fGroupBox1.Controls.Add(this.txtPassword);
            this.fGroupBox1.Controls.Add(this.fLabelMedium6);
            this.fGroupBox1.Controls.Add(this.cboRole);
            this.fGroupBox1.Controls.Add(this.fLabelMedium5);
            this.fGroupBox1.Controls.Add(this.cboTypeDocument);
            this.fGroupBox1.Controls.Add(this.txtNames);
            this.fGroupBox1.Controls.Add(this.fLabelMedium4);
            this.fGroupBox1.Controls.Add(this.txtLastName);
            this.fGroupBox1.Controls.Add(this.fLabelMedium3);
            this.fGroupBox1.Controls.Add(this.txtDocumentNumber);
            this.fGroupBox1.Controls.Add(this.fLabelMedium2);
            this.fGroupBox1.Controls.Add(this.fLabelMedium1);
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(13, 63);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(491, 382);
            this.fGroupBox1.TabIndex = 2;
            this.fGroupBox1.TabStop = false;
            this.fGroupBox1.Text = "Datos del Empleado";
            // 
            // chkCambiarPassword
            // 
            this.chkCambiarPassword.AutoSize = true;
            this.chkCambiarPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkCambiarPassword.FlatAppearance.BorderSize = 0;
            this.chkCambiarPassword.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCambiarPassword.ForeColor = System.Drawing.Color.Black;
            this.chkCambiarPassword.Location = new System.Drawing.Point(338, 322);
            this.chkCambiarPassword.Name = "chkCambiarPassword";
            this.chkCambiarPassword.Size = new System.Drawing.Size(126, 19);
            this.chkCambiarPassword.TabIndex = 15;
            this.chkCambiarPassword.Text = "Cambiar contraseña";
            this.chkCambiarPassword.UseVisualStyleBackColor = false;
            this.chkCambiarPassword.CheckedChanged += new System.EventHandler(this.chkCambiarPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(8, 293);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(456, 23);
            this.txtPassword.TabIndex = 13;
            // 
            // fLabelMedium6
            // 
            this.fLabelMedium6.AutoSize = true;
            this.fLabelMedium6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium6.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium6.Location = new System.Drawing.Point(6, 269);
            this.fLabelMedium6.Name = "fLabelMedium6";
            this.fLabelMedium6.Size = new System.Drawing.Size(87, 21);
            this.fLabelMedium6.TabIndex = 12;
            this.fLabelMedium6.Text = "Contraseña";
            // 
            // cboRole
            // 
            this.cboRole.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vEmpleadoBindingSource, "RoleId", true));
            this.cboRole.DataSource = this.roleBindingSource;
            this.cboRole.DisplayMember = "Name";
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(8, 243);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(251, 23);
            this.cboRole.TabIndex = 11;
            this.cboRole.ValueMember = "RoleId";
            // 
            // fLabelMedium5
            // 
            this.fLabelMedium5.AutoSize = true;
            this.fLabelMedium5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium5.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium5.Location = new System.Drawing.Point(6, 219);
            this.fLabelMedium5.Name = "fLabelMedium5";
            this.fLabelMedium5.Size = new System.Drawing.Size(31, 21);
            this.fLabelMedium5.TabIndex = 10;
            this.fLabelMedium5.Text = "Rol";
            // 
            // cboTypeDocument
            // 
            this.cboTypeDocument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vEmpleadoBindingSource, "TypeDocumentId", true));
            this.cboTypeDocument.DataSource = this.selectResponseBindingSource;
            this.cboTypeDocument.DisplayMember = "Description";
            this.cboTypeDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeDocument.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTypeDocument.FormattingEnabled = true;
            this.cboTypeDocument.Location = new System.Drawing.Point(8, 43);
            this.cboTypeDocument.Name = "cboTypeDocument";
            this.cboTypeDocument.Size = new System.Drawing.Size(251, 23);
            this.cboTypeDocument.TabIndex = 9;
            this.cboTypeDocument.ValueMember = "Id";
            // 
            // selectResponseBindingSource
            // 
            this.selectResponseBindingSource.DataSource = typeof(VipChannel.Domain.Entity.SelectResponse);
            // 
            // txtNames
            // 
            this.txtNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNames.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmpleadoBindingSource, "Names", true));
            this.txtNames.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNames.Location = new System.Drawing.Point(8, 193);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(456, 23);
            this.txtNames.TabIndex = 8;
            // 
            // fLabelMedium4
            // 
            this.fLabelMedium4.AutoSize = true;
            this.fLabelMedium4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium4.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium4.Location = new System.Drawing.Point(6, 169);
            this.fLabelMedium4.Name = "fLabelMedium4";
            this.fLabelMedium4.Size = new System.Drawing.Size(71, 21);
            this.fLabelMedium4.TabIndex = 7;
            this.fLabelMedium4.Text = "Nombres";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmpleadoBindingSource, "LastName", true));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(8, 143);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(456, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // fLabelMedium3
            // 
            this.fLabelMedium3.AutoSize = true;
            this.fLabelMedium3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium3.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium3.Location = new System.Drawing.Point(6, 119);
            this.fLabelMedium3.Name = "fLabelMedium3";
            this.fLabelMedium3.Size = new System.Drawing.Size(70, 21);
            this.fLabelMedium3.TabIndex = 5;
            this.fLabelMedium3.Text = "Apellidos";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumentNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocumentNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmpleadoBindingSource, "DocumentNumber", true));
            this.txtDocumentNumber.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentNumber.Location = new System.Drawing.Point(8, 93);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(251, 23);
            this.txtDocumentNumber.TabIndex = 4;
            // 
            // fLabelMedium2
            // 
            this.fLabelMedium2.AutoSize = true;
            this.fLabelMedium2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium2.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium2.Location = new System.Drawing.Point(6, 69);
            this.fLabelMedium2.Name = "fLabelMedium2";
            this.fLabelMedium2.Size = new System.Drawing.Size(149, 21);
            this.fLabelMedium2.TabIndex = 3;
            this.fLabelMedium2.Text = "Número Documento";
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(6, 19);
            this.fLabelMedium1.Name = "fLabelMedium1";
            this.fLabelMedium1.Size = new System.Drawing.Size(123, 21);
            this.fLabelMedium1.TabIndex = 0;
            this.fLabelMedium1.Text = "Tipo Documento";
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(12, 9);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(260, 41);
            this.fLabelBig1.TabIndex = 1;
            this.fLabelBig1.Text = "Gestión Empleados";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Visible = false;
            this.employeeIdDataGridViewTextBoxColumn.Width = 71;
            // 
            // documentNumberDataGridViewTextBoxColumn
            // 
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "Nro Documento";
            this.documentNumberDataGridViewTextBoxColumn.Name = "documentNumberDataGridViewTextBoxColumn";
            this.documentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentNumberDataGridViewTextBoxColumn.Width = 113;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 454);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.fGroupBox3);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.fLabelBig1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCajas_Load);
            this.fGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.fGroupBox3.ResumeLayout(false);
            this.fGroupBox1.ResumeLayout(false);
            this.fGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig fLabelBig1;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FLabelMedium fLabelMedium1;
        private Controles_Standar.FGroupBox fGroupBox3;
        private Controles_Standar.FButtonEliminar btnEliminar;
        private Controles_Standar.FButtonCancelar btnCancelar;
        private Controles_Standar.FButtonGuardar btnGuardar;
        private Controles_Standar.FButtonEditar btnEditar;
        private Controles_Standar.FButtonNuevo btnNuevo;
        private Controles_Standar.FGroupBox fGroupBox2;
        private Controles_Standar.FDataGridView dgvDatosRegistrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn descipcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private Controles_Standar.FTextBoxRequerido txtNames;
        private Controles_Standar.FLabelMedium fLabelMedium4;
        private Controles_Standar.FTextBoxRequerido txtLastName;
        private Controles_Standar.FLabelMedium fLabelMedium3;
        private Controles_Standar.FTextBoxRequerido txtDocumentNumber;
        private Controles_Standar.FLabelMedium fLabelMedium2;
        private Controles_Standar.FComboBox cboTypeDocument;
        private Controles_Standar.FTextBoxRequerido txtPassword;
        private Controles_Standar.FLabelMedium fLabelMedium6;
        private Controles_Standar.FComboBox cboRole;
        private Controles_Standar.FLabelMedium fLabelMedium5;
        private Controles_Standar.FCheckBox chkCambiarPassword;
        private System.Windows.Forms.BindingSource selectResponseBindingSource;
        private System.Windows.Forms.BindingSource vEmpleadoBindingSource;
        private Controles_Standar.FButtonReporte btnAsignarCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
    }
}