namespace VipChannel.Front.Definitions.Voucher
{
    partial class FrmSaleBoxList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleBoxList));
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            this.dgvDatosRegistrados = new Controles_Standar.FDataGridView();
            this.saleBoxIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSucursalPorCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.btnConfigurarComprobante = new Controles_Standar.FButtonActualizar();
            this.fGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSucursalPorCajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fGroupBox2
            // 
            this.fGroupBox2.Controls.Add(this.dgvDatosRegistrados);
            this.fGroupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox2.Location = new System.Drawing.Point(13, 65);
            this.fGroupBox2.Name = "fGroupBox2";
            this.fGroupBox2.Size = new System.Drawing.Size(491, 314);
            this.fGroupBox2.TabIndex = 4;
            this.fGroupBox2.TabStop = false;
            this.fGroupBox2.Text = "Repositorio de Datos";
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
            this.dgvDatosRegistrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDatosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosRegistrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleBoxIdDataGridViewTextBoxColumn,
            this.nameSucursalDataGridViewTextBoxColumn,
            this.nameCajaDataGridViewTextBoxColumn});
            this.dgvDatosRegistrados.DataSource = this.vSucursalPorCajaBindingSource;
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
            this.dgvDatosRegistrados.Size = new System.Drawing.Size(485, 292);
            this.dgvDatosRegistrados.TabIndex = 0;
            // 
            // saleBoxIdDataGridViewTextBoxColumn
            // 
            this.saleBoxIdDataGridViewTextBoxColumn.DataPropertyName = "SaleBoxId";
            this.saleBoxIdDataGridViewTextBoxColumn.HeaderText = "SaleBoxId";
            this.saleBoxIdDataGridViewTextBoxColumn.Name = "saleBoxIdDataGridViewTextBoxColumn";
            this.saleBoxIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleBoxIdDataGridViewTextBoxColumn.Visible = false;
            this.saleBoxIdDataGridViewTextBoxColumn.Width = 61;
            // 
            // nameSucursalDataGridViewTextBoxColumn
            // 
            this.nameSucursalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameSucursalDataGridViewTextBoxColumn.DataPropertyName = "NameSucursal";
            this.nameSucursalDataGridViewTextBoxColumn.HeaderText = "Nombre Sucursal";
            this.nameSucursalDataGridViewTextBoxColumn.Name = "nameSucursalDataGridViewTextBoxColumn";
            this.nameSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameCajaDataGridViewTextBoxColumn
            // 
            this.nameCajaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameCajaDataGridViewTextBoxColumn.DataPropertyName = "NameCaja";
            this.nameCajaDataGridViewTextBoxColumn.HeaderText = "Nombre Caja";
            this.nameCajaDataGridViewTextBoxColumn.Name = "nameCajaDataGridViewTextBoxColumn";
            this.nameCajaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameCajaDataGridViewTextBoxColumn.Width = 98;
            // 
            // vSucursalPorCajaBindingSource
            // 
            this.vSucursalPorCajaBindingSource.DataSource = typeof(VipChannel.Domain.Entity.vSucursalPorCaja);
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(12, 9);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(386, 41);
            this.fLabelBig1.TabIndex = 1;
            this.fLabelBig1.Text = "Listado de Cajas por Sucursal";
            // 
            // btnConfigurarComprobante
            // 
            this.btnConfigurarComprobante.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarComprobante.Image = ((System.Drawing.Image)(resources.GetObject("btnConfigurarComprobante.Image")));
            this.btnConfigurarComprobante.Location = new System.Drawing.Point(294, 385);
            this.btnConfigurarComprobante.Name = "btnConfigurarComprobante";
            this.btnConfigurarComprobante.Size = new System.Drawing.Size(207, 34);
            this.btnConfigurarComprobante.TabIndex = 9;
            this.btnConfigurarComprobante.Text = "Configuración Comprobantes";
            this.btnConfigurarComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfigurarComprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfigurarComprobante.UseVisualStyleBackColor = true;
            this.btnConfigurarComprobante.Click += new System.EventHandler(this.btnConfigurarComprobante_Click);
            // 
            // FrmSaleBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 428);
            this.Controls.Add(this.btnConfigurarComprobante);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.fLabelBig1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSaleBoxList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCajas_Load);
            this.fGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSucursalPorCajaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig fLabelBig1;
        private Controles_Standar.FGroupBox fGroupBox2;
        private Controles_Standar.FDataGridView dgvDatosRegistrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn descipcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajaDiariasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleBoxIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vSucursalPorCajaBindingSource;
        private Controles_Standar.FButtonActualizar btnConfigurarComprobante;
    }
}