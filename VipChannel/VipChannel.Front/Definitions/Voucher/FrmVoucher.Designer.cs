namespace VipChannel.Front.Definitions.Voucher
{
    partial class FrmVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVoucher));
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            this.dgvDatosRegistrados = new Controles_Standar.FDataGridView();
            this.voucherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTipoComprobantePorCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fGroupBox3 = new Controles_Standar.FGroupBox();
            this.btnEliminar = new Controles_Standar.FButtonEliminar();
            this.btnCancelar = new Controles_Standar.FButtonCancelar();
            this.btnGuardar = new Controles_Standar.FButtonGuardar();
            this.btnEditar = new Controles_Standar.FButtonEditar();
            this.btnNuevo = new Controles_Standar.FButtonNuevo();
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.cboVoucherType = new Controles_Standar.FComboBox();
            this.txtSaleBoxName = new Controles_Standar.FTextBoxRequerido();
            this.txtNumber = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium5 = new Controles_Standar.FLabelMedium();
            this.txtSerie = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium6 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium3 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium2 = new Controles_Standar.FLabelMedium();
            this.txtSucursalName = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.fGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTipoComprobantePorCajaBindingSource)).BeginInit();
            this.fGroupBox3.SuspendLayout();
            this.fGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fGroupBox2
            // 
            this.fGroupBox2.Controls.Add(this.dgvDatosRegistrados);
            this.fGroupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox2.Location = new System.Drawing.Point(13, 298);
            this.fGroupBox2.Name = "fGroupBox2";
            this.fGroupBox2.Size = new System.Drawing.Size(491, 182);
            this.fGroupBox2.TabIndex = 2;
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
            this.voucherIdDataGridViewTextBoxColumn,
            this.voucherTypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dgvDatosRegistrados.DataSource = this.vTipoComprobantePorCajaBindingSource;
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
            this.dgvDatosRegistrados.Size = new System.Drawing.Size(485, 160);
            this.dgvDatosRegistrados.TabIndex = 0;
            // 
            // voucherIdDataGridViewTextBoxColumn
            // 
            this.voucherIdDataGridViewTextBoxColumn.DataPropertyName = "VoucherId";
            this.voucherIdDataGridViewTextBoxColumn.HeaderText = "VoucherId";
            this.voucherIdDataGridViewTextBoxColumn.Name = "voucherIdDataGridViewTextBoxColumn";
            this.voucherIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.voucherIdDataGridViewTextBoxColumn.Visible = false;
            this.voucherIdDataGridViewTextBoxColumn.Width = 62;
            // 
            // voucherTypeDataGridViewTextBoxColumn
            // 
            this.voucherTypeDataGridViewTextBoxColumn.DataPropertyName = "VoucherType";
            this.voucherTypeDataGridViewTextBoxColumn.HeaderText = "VoucherType";
            this.voucherTypeDataGridViewTextBoxColumn.Name = "voucherTypeDataGridViewTextBoxColumn";
            this.voucherTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.voucherTypeDataGridViewTextBoxColumn.Visible = false;
            this.voucherTypeDataGridViewTextBoxColumn.Width = 75;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tipo de Comprobante";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.Width = 55;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Correlativo";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 85;
            // 
            // vTipoComprobantePorCajaBindingSource
            // 
            this.vTipoComprobantePorCajaBindingSource.DataSource = typeof(VipChannel.Domain.Entity.vTipoComprobantePorCaja);
            // 
            // fGroupBox3
            // 
            this.fGroupBox3.Controls.Add(this.btnEliminar);
            this.fGroupBox3.Controls.Add(this.btnCancelar);
            this.fGroupBox3.Controls.Add(this.btnGuardar);
            this.fGroupBox3.Controls.Add(this.btnEditar);
            this.fGroupBox3.Controls.Add(this.btnNuevo);
            this.fGroupBox3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox3.Location = new System.Drawing.Point(13, 486);
            this.fGroupBox3.Name = "fGroupBox3";
            this.fGroupBox3.Size = new System.Drawing.Size(491, 64);
            this.fGroupBox3.TabIndex = 3;
            this.fGroupBox3.TabStop = false;
            this.fGroupBox3.Text = "Acciones del Formulario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(200, 22);
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
            this.btnCancelar.Location = new System.Drawing.Point(392, 22);
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
            this.btnGuardar.Location = new System.Drawing.Point(296, 22);
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
            this.btnEditar.Location = new System.Drawing.Point(104, 22);
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
            this.btnNuevo.Location = new System.Drawing.Point(8, 22);
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
            this.fGroupBox1.Controls.Add(this.cboVoucherType);
            this.fGroupBox1.Controls.Add(this.txtSaleBoxName);
            this.fGroupBox1.Controls.Add(this.txtNumber);
            this.fGroupBox1.Controls.Add(this.fLabelMedium5);
            this.fGroupBox1.Controls.Add(this.txtSerie);
            this.fGroupBox1.Controls.Add(this.fLabelMedium6);
            this.fGroupBox1.Controls.Add(this.fLabelMedium3);
            this.fGroupBox1.Controls.Add(this.fLabelMedium2);
            this.fGroupBox1.Controls.Add(this.txtSucursalName);
            this.fGroupBox1.Controls.Add(this.fLabelMedium1);
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(13, 63);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(491, 229);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
            this.fGroupBox1.Text = "Datos del Comprobante";
            // 
            // cboVoucherType
            // 
            this.cboVoucherType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vTipoComprobantePorCajaBindingSource, "VoucherType", true));
            this.cboVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoucherType.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVoucherType.FormattingEnabled = true;
            this.cboVoucherType.Location = new System.Drawing.Point(8, 143);
            this.cboVoucherType.Name = "cboVoucherType";
            this.cboVoucherType.Size = new System.Drawing.Size(477, 23);
            this.cboVoucherType.TabIndex = 5;
            // 
            // txtSaleBoxName
            // 
            this.txtSaleBoxName.BackColor = System.Drawing.SystemColors.Control;
            this.txtSaleBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaleBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaleBoxName.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleBoxName.Location = new System.Drawing.Point(8, 93);
            this.txtSaleBoxName.Name = "txtSaleBoxName";
            this.txtSaleBoxName.ReadOnly = true;
            this.txtSaleBoxName.Size = new System.Drawing.Size(477, 23);
            this.txtSaleBoxName.TabIndex = 3;
            this.txtSaleBoxName.TabStop = false;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vTipoComprobantePorCajaBindingSource, "Number", true));
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(265, 193);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(220, 23);
            this.txtNumber.TabIndex = 9;
            this.txtNumber.TabStop = false;
            this.txtNumber.Text = "0";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fLabelMedium5
            // 
            this.fLabelMedium5.AutoSize = true;
            this.fLabelMedium5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium5.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium5.Location = new System.Drawing.Point(263, 169);
            this.fLabelMedium5.Name = "fLabelMedium5";
            this.fLabelMedium5.Size = new System.Drawing.Size(82, 21);
            this.fLabelMedium5.TabIndex = 8;
            this.fLabelMedium5.Text = "Correlativo";
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSerie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vTipoComprobantePorCajaBindingSource, "Serie", true));
            this.txtSerie.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(8, 193);
            this.txtSerie.MaxLength = 5;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(220, 23);
            this.txtSerie.TabIndex = 7;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fLabelMedium6
            // 
            this.fLabelMedium6.AutoSize = true;
            this.fLabelMedium6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium6.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium6.Location = new System.Drawing.Point(6, 169);
            this.fLabelMedium6.Name = "fLabelMedium6";
            this.fLabelMedium6.Size = new System.Drawing.Size(42, 21);
            this.fLabelMedium6.TabIndex = 6;
            this.fLabelMedium6.Text = "Serie";
            // 
            // fLabelMedium3
            // 
            this.fLabelMedium3.AutoSize = true;
            this.fLabelMedium3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium3.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium3.Location = new System.Drawing.Point(6, 119);
            this.fLabelMedium3.Name = "fLabelMedium3";
            this.fLabelMedium3.Size = new System.Drawing.Size(137, 21);
            this.fLabelMedium3.TabIndex = 4;
            this.fLabelMedium3.Text = "Tipo Comprobante";
            // 
            // fLabelMedium2
            // 
            this.fLabelMedium2.AutoSize = true;
            this.fLabelMedium2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium2.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium2.Location = new System.Drawing.Point(6, 69);
            this.fLabelMedium2.Name = "fLabelMedium2";
            this.fLabelMedium2.Size = new System.Drawing.Size(98, 21);
            this.fLabelMedium2.TabIndex = 2;
            this.fLabelMedium2.Text = "Nombre Caja";
            // 
            // txtSucursalName
            // 
            this.txtSucursalName.BackColor = System.Drawing.SystemColors.Control;
            this.txtSucursalName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSucursalName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSucursalName.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursalName.Location = new System.Drawing.Point(8, 43);
            this.txtSucursalName.Name = "txtSucursalName";
            this.txtSucursalName.ReadOnly = true;
            this.txtSucursalName.Size = new System.Drawing.Size(477, 23);
            this.txtSucursalName.TabIndex = 1;
            this.txtSucursalName.TabStop = false;
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(6, 19);
            this.fLabelMedium1.Name = "fLabelMedium1";
            this.fLabelMedium1.Size = new System.Drawing.Size(124, 21);
            this.fLabelMedium1.TabIndex = 0;
            this.fLabelMedium1.Text = "Nombre Sucursal";
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(12, 9);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(309, 41);
            this.fLabelBig1.TabIndex = 0;
            this.fLabelBig1.Text = "Gestión Comprobantes";
            // 
            // FrmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 562);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.fGroupBox3);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.fLabelBig1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmVoucher";
            this.Load += new System.EventHandler(this.FrmCajas_Load);
            this.fGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTipoComprobantePorCajaBindingSource)).EndInit();
            this.fGroupBox3.ResumeLayout(false);
            this.fGroupBox1.ResumeLayout(false);
            this.fGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig fLabelBig1;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FTextBoxRequerido txtSucursalName;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cajaDiariasDataGridViewTextBoxColumn;
        private Controles_Standar.FLabelMedium fLabelMedium2;
        private Controles_Standar.FComboBox cboVoucherType;
        private Controles_Standar.FLabelMedium fLabelMedium3;
        private Controles_Standar.FTextBoxRequerido txtNumber;
        private Controles_Standar.FLabelMedium fLabelMedium5;
        private Controles_Standar.FTextBoxRequerido txtSerie;
        private Controles_Standar.FLabelMedium fLabelMedium6;
        private Controles_Standar.FTextBoxRequerido txtSaleBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vTipoComprobantePorCajaBindingSource;
    }
}