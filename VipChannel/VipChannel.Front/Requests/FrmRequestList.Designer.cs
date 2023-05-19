namespace VipChannel.Front.Requests
{
    partial class FrmRequestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequestList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.btnBuscar = new Controles_Standar.FButtonBuscar();
            this.fTextBox1 = new Controles_Standar.FTextBox();
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            this.dgvDatosRegistrados = new Controles_Standar.FDataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installationRequestIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneAvenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAttentionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSolicitudesInstalacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.btnCancelarSolicitud = new Controles_Standar.FButtonEliminar();
            this.btnAtenderSolicitud = new Controles_Standar.FButtonEditar();
            this.fGroupBox1.SuspendLayout();
            this.fGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSolicitudesInstalacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGroupBox1.Controls.Add(this.fLabelMedium1);
            this.fGroupBox1.Controls.Add(this.btnBuscar);
            this.fGroupBox1.Controls.Add(this.fTextBox1);
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(12, 53);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(1070, 78);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(6, 14);
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
            this.btnBuscar.Location = new System.Drawing.Point(974, 32);
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
            this.fTextBox1.Location = new System.Drawing.Point(10, 38);
            this.fTextBox1.Name = "fTextBox1";
            this.fTextBox1.Size = new System.Drawing.Size(943, 23);
            this.fTextBox1.TabIndex = 1;
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatosRegistrados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatosRegistrados.AutoGenerateColumns = false;
            this.dgvDatosRegistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosRegistrados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDatosRegistrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            this.dgvDatosRegistrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosRegistrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerAddressIdDataGridViewTextBoxColumn,
            this.installationRequestIdDataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn,
            this.businessNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.namesDataGridViewTextBoxColumn,
            this.cellPhonesDataGridViewTextBoxColumn,
            this.zoneAvenueDataGridViewTextBoxColumn,
            this.adressDetailDataGridViewTextBoxColumn,
            this.dateAttentionDataGridViewTextBoxColumn,
            this.customerAddressStatusDataGridViewTextBoxColumn});
            this.dgvDatosRegistrados.DataSource = this.vSolicitudesInstalacionBindingSource;
            this.dgvDatosRegistrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosRegistrados.EnableHeadersVisualStyles = false;
            this.dgvDatosRegistrados.Location = new System.Drawing.Point(3, 19);
            this.dgvDatosRegistrados.MultiSelect = false;
            this.dgvDatosRegistrados.Name = "dgvDatosRegistrados";
            this.dgvDatosRegistrados.ReadOnly = true;
            this.dgvDatosRegistrados.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatosRegistrados.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            // customerAddressIdDataGridViewTextBoxColumn
            // 
            this.customerAddressIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddressId";
            this.customerAddressIdDataGridViewTextBoxColumn.HeaderText = "CustomerAddressId";
            this.customerAddressIdDataGridViewTextBoxColumn.Name = "customerAddressIdDataGridViewTextBoxColumn";
            this.customerAddressIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerAddressIdDataGridViewTextBoxColumn.Visible = false;
            this.customerAddressIdDataGridViewTextBoxColumn.Width = 113;
            // 
            // installationRequestIdDataGridViewTextBoxColumn
            // 
            this.installationRequestIdDataGridViewTextBoxColumn.DataPropertyName = "InstallationRequestId";
            this.installationRequestIdDataGridViewTextBoxColumn.HeaderText = "InstallationRequestId";
            this.installationRequestIdDataGridViewTextBoxColumn.Name = "installationRequestIdDataGridViewTextBoxColumn";
            this.installationRequestIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.installationRequestIdDataGridViewTextBoxColumn.Visible = false;
            this.installationRequestIdDataGridViewTextBoxColumn.Width = 116;
            // 
            // documentNumberDataGridViewTextBoxColumn
            // 
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.Name = "documentNumberDataGridViewTextBoxColumn";
            this.documentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // businessNameDataGridViewTextBoxColumn
            // 
            this.businessNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.businessNameDataGridViewTextBoxColumn.DataPropertyName = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.HeaderText = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.Name = "businessNameDataGridViewTextBoxColumn";
            this.businessNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // namesDataGridViewTextBoxColumn
            // 
            this.namesDataGridViewTextBoxColumn.DataPropertyName = "Names";
            this.namesDataGridViewTextBoxColumn.HeaderText = "Names";
            this.namesDataGridViewTextBoxColumn.Name = "namesDataGridViewTextBoxColumn";
            this.namesDataGridViewTextBoxColumn.ReadOnly = true;
            this.namesDataGridViewTextBoxColumn.Width = 67;
            // 
            // cellPhonesDataGridViewTextBoxColumn
            // 
            this.cellPhonesDataGridViewTextBoxColumn.DataPropertyName = "CellPhones";
            this.cellPhonesDataGridViewTextBoxColumn.HeaderText = "CellPhones";
            this.cellPhonesDataGridViewTextBoxColumn.Name = "cellPhonesDataGridViewTextBoxColumn";
            this.cellPhonesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellPhonesDataGridViewTextBoxColumn.Width = 85;
            // 
            // zoneAvenueDataGridViewTextBoxColumn
            // 
            this.zoneAvenueDataGridViewTextBoxColumn.DataPropertyName = "ZoneAvenue";
            this.zoneAvenueDataGridViewTextBoxColumn.HeaderText = "ZoneAvenue";
            this.zoneAvenueDataGridViewTextBoxColumn.Name = "zoneAvenueDataGridViewTextBoxColumn";
            this.zoneAvenueDataGridViewTextBoxColumn.ReadOnly = true;
            this.zoneAvenueDataGridViewTextBoxColumn.Width = 94;
            // 
            // adressDetailDataGridViewTextBoxColumn
            // 
            this.adressDetailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adressDetailDataGridViewTextBoxColumn.DataPropertyName = "AdressDetail";
            this.adressDetailDataGridViewTextBoxColumn.HeaderText = "AdressDetail";
            this.adressDetailDataGridViewTextBoxColumn.Name = "adressDetailDataGridViewTextBoxColumn";
            this.adressDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAttentionDataGridViewTextBoxColumn
            // 
            this.dateAttentionDataGridViewTextBoxColumn.DataPropertyName = "DateAttention";
            this.dateAttentionDataGridViewTextBoxColumn.HeaderText = "DateAttention";
            this.dateAttentionDataGridViewTextBoxColumn.Name = "dateAttentionDataGridViewTextBoxColumn";
            this.dateAttentionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAttentionDataGridViewTextBoxColumn.Width = 102;
            // 
            // customerAddressStatusDataGridViewTextBoxColumn
            // 
            this.customerAddressStatusDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddressStatus";
            this.customerAddressStatusDataGridViewTextBoxColumn.HeaderText = "CustomerAddressStatus";
            this.customerAddressStatusDataGridViewTextBoxColumn.Name = "customerAddressStatusDataGridViewTextBoxColumn";
            this.customerAddressStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerAddressStatusDataGridViewTextBoxColumn.Visible = false;
            this.customerAddressStatusDataGridViewTextBoxColumn.Width = 153;
            // 
            // vSolicitudesInstalacionBindingSource
            // 
            this.vSolicitudesInstalacionBindingSource.DataSource = typeof(VipChannel.Domain.Entity.vSolicitudesInstalacion);
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(5, 9);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(288, 41);
            this.fLabelBig1.TabIndex = 0;
            this.fLabelBig1.Text = "Listado de Solicitudes";
            // 
            // btnCancelarSolicitud
            // 
            this.btnCancelarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarSolicitud.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarSolicitud.Image")));
            this.btnCancelarSolicitud.Location = new System.Drawing.Point(880, 575);
            this.btnCancelarSolicitud.Name = "btnCancelarSolicitud";
            this.btnCancelarSolicitud.Size = new System.Drawing.Size(202, 34);
            this.btnCancelarSolicitud.TabIndex = 4;
            this.btnCancelarSolicitud.Text = "Cancelar Solicitud";
            this.btnCancelarSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarSolicitud.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelarSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnAtenderSolicitud
            // 
            this.btnAtenderSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtenderSolicitud.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtenderSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnAtenderSolicitud.Image")));
            this.btnAtenderSolicitud.Location = new System.Drawing.Point(672, 575);
            this.btnAtenderSolicitud.Name = "btnAtenderSolicitud";
            this.btnAtenderSolicitud.Size = new System.Drawing.Size(202, 34);
            this.btnAtenderSolicitud.TabIndex = 3;
            this.btnAtenderSolicitud.Text = "Atender Solicitud";
            this.btnAtenderSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtenderSolicitud.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtenderSolicitud.UseVisualStyleBackColor = true;
            this.btnAtenderSolicitud.Click += new System.EventHandler(this.btnAtenderSolicitud_Click);
            // 
            // FrmRequestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 621);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.btnCancelarSolicitud);
            this.Controls.Add(this.btnAtenderSolicitud);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.fLabelBig1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRequestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.fGroupBox1.ResumeLayout(false);
            this.fGroupBox1.PerformLayout();
            this.fGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSolicitudesInstalacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig fLabelBig1;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FButtonBuscar btnBuscar;
        private Controles_Standar.FTextBox fTextBox1;
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
        private Controles_Standar.FButtonEditar btnAtenderSolicitud;
        private Controles_Standar.FButtonEliminar btnCancelarSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn planTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource vSolicitudesInstalacionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn installationRequestIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneAvenueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAttentionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressStatusDataGridViewTextBoxColumn;
    }
}