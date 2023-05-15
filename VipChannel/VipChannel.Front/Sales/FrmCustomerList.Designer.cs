namespace VipChannel.Front.Sales
{
    partial class FrmCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerList));
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            this.dgvDatosRegistrados = new Controles_Standar.FDataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generarSolicitudInstalacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.btnAgregarCliente = new Controles_Standar.FButtonNuevo();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.btnBuscar = new Controles_Standar.FButtonBuscar();
            this.fTextBox1 = new Controles_Standar.FTextBox();
            this.btnAgregarEmpresa = new Controles_Standar.FButtonNuevo();
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.btnEditar = new Controles_Standar.FButtonEditar();
            this.btnEliminar = new Controles_Standar.FButtonEliminar();
            this.btnCancelar = new Controles_Standar.FButtonCancelar();
            this.fGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vClienteBindingSource)).BeginInit();
            this.fGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fGroupBox2
            // 
            this.fGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGroupBox2.Controls.Add(this.dgvDatosRegistrados);
            this.fGroupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox2.Location = new System.Drawing.Point(12, 137);
            this.fGroupBox2.Name = "fGroupBox2";
            this.fGroupBox2.Size = new System.Drawing.Size(1070, 432);
            this.fGroupBox2.TabIndex = 2;
            this.fGroupBox2.TabStop = false;
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            this.dgvDatosRegistrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosRegistrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.personTypeDataGridViewTextBoxColumn,
            this.documentTypeDataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn,
            this.businessNameDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn});
            this.dgvDatosRegistrados.ContextMenuStrip = this.contextMenuStrip;
            this.dgvDatosRegistrados.DataSource = this.vClienteBindingSource;
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
            this.dgvDatosRegistrados.Size = new System.Drawing.Size(1064, 410);
            this.dgvDatosRegistrados.TabIndex = 0;
            this.dgvDatosRegistrados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosRegistrados_CellContentDoubleClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Visible = false;
            this.customerIdDataGridViewTextBoxColumn.Width = 71;
            // 
            // personTypeDataGridViewTextBoxColumn
            // 
            this.personTypeDataGridViewTextBoxColumn.DataPropertyName = "PersonType";
            this.personTypeDataGridViewTextBoxColumn.HeaderText = "Tipo Persona";
            this.personTypeDataGridViewTextBoxColumn.Name = "personTypeDataGridViewTextBoxColumn";
            this.personTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.personTypeDataGridViewTextBoxColumn.Width = 96;
            // 
            // documentTypeDataGridViewTextBoxColumn
            // 
            this.documentTypeDataGridViewTextBoxColumn.DataPropertyName = "DocumentType";
            this.documentTypeDataGridViewTextBoxColumn.HeaderText = "Tipo Documento";
            this.documentTypeDataGridViewTextBoxColumn.Name = "documentTypeDataGridViewTextBoxColumn";
            this.documentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentTypeDataGridViewTextBoxColumn.Width = 115;
            // 
            // documentNumberDataGridViewTextBoxColumn
            // 
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "Número Documento";
            this.documentNumberDataGridViewTextBoxColumn.Name = "documentNumberDataGridViewTextBoxColumn";
            this.documentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentNumberDataGridViewTextBoxColumn.Width = 135;
            // 
            // businessNameDataGridViewTextBoxColumn
            // 
            this.businessNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.businessNameDataGridViewTextBoxColumn.DataPropertyName = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.HeaderText = "Nombre Empresa";
            this.businessNameDataGridViewTextBoxColumn.Name = "businessNameDataGridViewTextBoxColumn";
            this.businessNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Cliente ";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            this.cellPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellPhoneDataGridViewTextBoxColumn.Width = 64;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarSolicitudInstalacionToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(225, 48);
            // 
            // generarSolicitudInstalacionToolStripMenuItem
            // 
            this.generarSolicitudInstalacionToolStripMenuItem.Name = "generarSolicitudInstalacionToolStripMenuItem";
            this.generarSolicitudInstalacionToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.generarSolicitudInstalacionToolStripMenuItem.Text = "Generar Solicitud Instalación";
            this.generarSolicitudInstalacionToolStripMenuItem.Click += new System.EventHandler(this.generarSolicitudInstalacionToolStripMenuItem_Click);
            // 
            // vClienteBindingSource
            // 
            this.vClienteBindingSource.DataSource = typeof(VipChannel.Domain.Entity.vCliente);
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGroupBox1.Controls.Add(this.btnAgregarCliente);
            this.fGroupBox1.Controls.Add(this.fLabelMedium1);
            this.fGroupBox1.Controls.Add(this.btnBuscar);
            this.fGroupBox1.Controls.Add(this.fTextBox1);
            this.fGroupBox1.Controls.Add(this.btnAgregarEmpresa);
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(12, 53);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(1070, 78);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCliente.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCliente.Image")));
            this.btnAgregarCliente.Location = new System.Drawing.Point(877, 36);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(90, 34);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Cliente";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(6, 19);
            this.fLabelMedium1.Name = "fLabelMedium1";
            this.fLabelMedium1.Size = new System.Drawing.Size(54, 21);
            this.fLabelMedium1.TabIndex = 0;
            this.fLabelMedium1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(781, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // fTextBox1
            // 
            this.fTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fTextBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fTextBox1.Location = new System.Drawing.Point(10, 43);
            this.fTextBox1.Name = "fTextBox1";
            this.fTextBox1.Size = new System.Drawing.Size(765, 23);
            this.fTextBox1.TabIndex = 1;
            // 
            // btnAgregarEmpresa
            // 
            this.btnAgregarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEmpresa.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEmpresa.Image")));
            this.btnAgregarEmpresa.Location = new System.Drawing.Point(973, 36);
            this.btnAgregarEmpresa.Name = "btnAgregarEmpresa";
            this.btnAgregarEmpresa.Size = new System.Drawing.Size(90, 34);
            this.btnAgregarEmpresa.TabIndex = 3;
            this.btnAgregarEmpresa.Text = "Empresa";
            this.btnAgregarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarEmpresa.UseVisualStyleBackColor = true;
            this.btnAgregarEmpresa.Click += new System.EventHandler(this.btnAgregarEmpresa_Click);
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(5, 9);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(254, 41);
            this.fLabelBig1.TabIndex = 0;
            this.fLabelBig1.Text = "Listado de Clientes";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(793, 575);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 34);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(889, 575);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 34);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(985, 575);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 621);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.fLabelBig1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmCustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.fGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vClienteBindingSource)).EndInit();
            this.fGroupBox1.ResumeLayout(false);
            this.fGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig fLabelBig1;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FButtonBuscar btnBuscar;
        private Controles_Standar.FTextBox fTextBox1;
        private Controles_Standar.FButtonNuevo btnAgregarEmpresa;
        private Controles_Standar.FGroupBox fGroupBox2;
        private Controles_Standar.FDataGridView dgvDatosRegistrados;
        private Controles_Standar.FLabelMedium fLabelMedium1;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetUploadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uploadInternetSpeedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDownloadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn downloadInternetSpeedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Controles_Standar.FButtonEditar btnEditar;
        private Controles_Standar.FButtonEliminar btnEliminar;
        private Controles_Standar.FButtonCancelar btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn planTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vClienteBindingSource;
        private Controles_Standar.FButtonNuevo btnAgregarCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem generarSolicitudInstalacionToolStripMenuItem;
    }
}