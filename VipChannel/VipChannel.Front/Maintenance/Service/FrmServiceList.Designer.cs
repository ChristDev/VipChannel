namespace VipChannel.Front.Maintenance.Service
{
    partial class FrmServiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiceList));
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            this.dgvDatosRegistrados = new Controles_Standar.FDataGridView();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.btnBuscar = new Controles_Standar.FButtonBuscar();
            this.fTextBox1 = new Controles_Standar.FTextBox();
            this.btnNuevo = new Controles_Standar.FButtonNuevo();
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.btnEditar = new Controles_Standar.FButtonEditar();
            this.btnEliminar = new Controles_Standar.FButtonEliminar();
            this.btnCancelar = new Controles_Standar.FButtonCancelar();
            this.fGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
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
            this.fGroupBox2.Size = new System.Drawing.Size(719, 370);
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
            this.serviceIdDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dgvDatosRegistrados.DataSource = this.serviceBindingSource;
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
            this.dgvDatosRegistrados.Size = new System.Drawing.Size(713, 348);
            this.dgvDatosRegistrados.TabIndex = 0;
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIdDataGridViewTextBoxColumn.Visible = false;
            this.serviceIdDataGridViewTextBoxColumn.Width = 57;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn15.HeaderText = "Descripción Servicio";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn16.HeaderText = "Precio S/.";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 78;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(VipChannel.Domain.Entity.Service);
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGroupBox1.Controls.Add(this.fLabelMedium1);
            this.fGroupBox1.Controls.Add(this.btnBuscar);
            this.fGroupBox1.Controls.Add(this.fTextBox1);
            this.fGroupBox1.Controls.Add(this.btnNuevo);
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(12, 53);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(719, 78);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
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
            this.btnBuscar.Location = new System.Drawing.Point(526, 37);
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
            this.fTextBox1.Size = new System.Drawing.Size(510, 23);
            this.fTextBox1.TabIndex = 1;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(622, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 34);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(5, 9);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(266, 41);
            this.fLabelBig1.TabIndex = 0;
            this.fLabelBig1.Text = "Listado de Servicios";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(442, 513);
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
            this.btnEliminar.Location = new System.Drawing.Point(538, 513);
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
            this.btnCancelar.Location = new System.Drawing.Point(634, 513);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmServiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(743, 559);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.fLabelBig1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmServiceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.fGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
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
        private Controles_Standar.FButtonNuevo btnNuevo;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingSource serviceBindingSource;
    }
}