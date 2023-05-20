namespace VipChannel.Front.Payments
{
    partial class FrmPaymentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentsList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uspListarClientesActivosResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fGroupBox4 = new Controles_Standar.FGroupBox();
            this.dtpPayDay = new Controles_Standar.FDateTimePicker();
            this.fLabelMedium6 = new Controles_Standar.FLabelMedium();
            this.cboManagerId = new Controles_Standar.FComboBox();
            this.vGestoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPay = new Controles_Standar.FTextBox();
            this.fLabelMedium5 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium3 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium2 = new Controles_Standar.FLabelMedium();
            this.fGroupBox3 = new Controles_Standar.FGroupBox();
            this.dgvPendientePago = new Controles_Standar.FDataGridView();
            this.scheduleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCronogramaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.btnBuscar = new Controles_Standar.FButtonBuscar();
            this.txtBuscarCliente = new Controles_Standar.FTextBox();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.btnCancelar = new Controles_Standar.FButtonCancelar();
            this.btnEditar = new Controles_Standar.FButtonEditar();
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            this.dgvDatosRegistrados = new Controles_Standar.FDataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.fComboBox1 = new Controles_Standar.FComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uspListarClientesActivosResultBindingSource)).BeginInit();
            this.fGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGestoreBindingSource)).BeginInit();
            this.fGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCronogramaPagoBindingSource)).BeginInit();
            this.fGroupBox1.SuspendLayout();
            this.fGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // uspListarClientesActivosResultBindingSource
            // 
            this.uspListarClientesActivosResultBindingSource.DataSource = typeof(VipChannel.Domain.Entity.usp_ListarClientesActivos_Result);
            // 
            // fGroupBox4
            // 
            this.fGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGroupBox4.Controls.Add(this.fComboBox1);
            this.fGroupBox4.Controls.Add(this.dtpPayDay);
            this.fGroupBox4.Controls.Add(this.fLabelMedium6);
            this.fGroupBox4.Controls.Add(this.cboManagerId);
            this.fGroupBox4.Controls.Add(this.txtPay);
            this.fGroupBox4.Controls.Add(this.fLabelMedium5);
            this.fGroupBox4.Controls.Add(this.fLabelMedium3);
            this.fGroupBox4.Controls.Add(this.fLabelMedium2);
            this.fGroupBox4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox4.Location = new System.Drawing.Point(980, 141);
            this.fGroupBox4.Name = "fGroupBox4";
            this.fGroupBox4.Size = new System.Drawing.Size(402, 237);
            this.fGroupBox4.TabIndex = 4;
            this.fGroupBox4.TabStop = false;
            this.fGroupBox4.Text = "Pagos";
            // 
            // dtpPayDay
            // 
            this.dtpPayDay.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPayDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPayDay.Location = new System.Drawing.Point(10, 45);
            this.dtpPayDay.Name = "dtpPayDay";
            this.dtpPayDay.Size = new System.Drawing.Size(300, 23);
            this.dtpPayDay.TabIndex = 1;
            // 
            // fLabelMedium6
            // 
            this.fLabelMedium6.AutoSize = true;
            this.fLabelMedium6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium6.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium6.Location = new System.Drawing.Point(6, 71);
            this.fLabelMedium6.Name = "fLabelMedium6";
            this.fLabelMedium6.Size = new System.Drawing.Size(54, 21);
            this.fLabelMedium6.TabIndex = 2;
            this.fLabelMedium6.Text = "Gestor";
            // 
            // cboManagerId
            // 
            this.cboManagerId.DataSource = this.vGestoreBindingSource;
            this.cboManagerId.DisplayMember = "EmployeeName";
            this.cboManagerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManagerId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManagerId.FormattingEnabled = true;
            this.cboManagerId.Location = new System.Drawing.Point(10, 95);
            this.cboManagerId.Name = "cboManagerId";
            this.cboManagerId.Size = new System.Drawing.Size(384, 23);
            this.cboManagerId.TabIndex = 3;
            this.cboManagerId.ValueMember = "ManagerId";
            // 
            // vGestoreBindingSource
            // 
            this.vGestoreBindingSource.DataSource = typeof(VipChannel.Domain.Entity.vGestore);
            // 
            // txtPay
            // 
            this.txtPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPay.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.Location = new System.Drawing.Point(250, 145);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(144, 23);
            this.txtPay.TabIndex = 7;
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fLabelMedium5
            // 
            this.fLabelMedium5.AutoSize = true;
            this.fLabelMedium5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium5.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium5.Location = new System.Drawing.Point(246, 121);
            this.fLabelMedium5.Name = "fLabelMedium5";
            this.fLabelMedium5.Size = new System.Drawing.Size(55, 21);
            this.fLabelMedium5.TabIndex = 6;
            this.fLabelMedium5.Text = "Monto";
            // 
            // fLabelMedium3
            // 
            this.fLabelMedium3.AutoSize = true;
            this.fLabelMedium3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium3.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium3.Location = new System.Drawing.Point(6, 121);
            this.fLabelMedium3.Name = "fLabelMedium3";
            this.fLabelMedium3.Size = new System.Drawing.Size(42, 21);
            this.fLabelMedium3.TabIndex = 4;
            this.fLabelMedium3.Text = "Serie";
            // 
            // fLabelMedium2
            // 
            this.fLabelMedium2.AutoSize = true;
            this.fLabelMedium2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium2.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium2.Location = new System.Drawing.Point(6, 19);
            this.fLabelMedium2.Name = "fLabelMedium2";
            this.fLabelMedium2.Size = new System.Drawing.Size(108, 21);
            this.fLabelMedium2.TabIndex = 0;
            this.fLabelMedium2.Text = "Fecha de Pago";
            // 
            // fGroupBox3
            // 
            this.fGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGroupBox3.Controls.Add(this.dgvPendientePago);
            this.fGroupBox3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox3.Location = new System.Drawing.Point(600, 141);
            this.fGroupBox3.Name = "fGroupBox3";
            this.fGroupBox3.Size = new System.Drawing.Size(374, 432);
            this.fGroupBox3.TabIndex = 3;
            this.fGroupBox3.TabStop = false;
            // 
            // dgvPendientePago
            // 
            this.dgvPendientePago.AllowUserToAddRows = false;
            this.dgvPendientePago.AllowUserToDeleteRows = false;
            this.dgvPendientePago.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPendientePago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPendientePago.AutoGenerateColumns = false;
            this.dgvPendientePago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPendientePago.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPendientePago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            this.dgvPendientePago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPendientePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientePago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleIdDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.totalPendingDataGridViewTextBoxColumn});
            this.dgvPendientePago.DataSource = this.vCronogramaPagoBindingSource;
            this.dgvPendientePago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendientePago.EnableHeadersVisualStyles = false;
            this.dgvPendientePago.Location = new System.Drawing.Point(3, 19);
            this.dgvPendientePago.MultiSelect = false;
            this.dgvPendientePago.Name = "dgvPendientePago";
            this.dgvPendientePago.ReadOnly = true;
            this.dgvPendientePago.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPendientePago.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPendientePago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendientePago.Size = new System.Drawing.Size(368, 410);
            this.dgvPendientePago.TabIndex = 0;
            this.dgvPendientePago.SelectionChanged += new System.EventHandler(this.dgvPendientePago_SelectionChanged);
            // 
            // scheduleIdDataGridViewTextBoxColumn
            // 
            this.scheduleIdDataGridViewTextBoxColumn.DataPropertyName = "ScheduleId";
            this.scheduleIdDataGridViewTextBoxColumn.HeaderText = "ScheduleId";
            this.scheduleIdDataGridViewTextBoxColumn.Name = "scheduleIdDataGridViewTextBoxColumn";
            this.scheduleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.scheduleIdDataGridViewTextBoxColumn.Visible = false;
            this.scheduleIdDataGridViewTextBoxColumn.Width = 66;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "Fecha Vencimiento";
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPendingDataGridViewTextBoxColumn
            // 
            this.totalPendingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPendingDataGridViewTextBoxColumn.DataPropertyName = "TotalPending";
            this.totalPendingDataGridViewTextBoxColumn.HeaderText = "Pendiente Pago";
            this.totalPendingDataGridViewTextBoxColumn.Name = "totalPendingDataGridViewTextBoxColumn";
            this.totalPendingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vCronogramaPagoBindingSource
            // 
            this.vCronogramaPagoBindingSource.DataSource = typeof(VipChannel.Domain.Entity.vCronogramaPago);
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGroupBox1.Controls.Add(this.btnBuscar);
            this.fGroupBox1.Controls.Add(this.txtBuscarCliente);
            this.fGroupBox1.Controls.Add(this.fLabelMedium1);
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(16, 57);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(958, 78);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(871, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(6, 34);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(859, 23);
            this.txtBuscarCliente.TabIndex = 1;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(6, 12);
            this.fLabelMedium1.Name = "fLabelMedium1";
            this.fLabelMedium1.Size = new System.Drawing.Size(54, 21);
            this.fLabelMedium1.TabIndex = 0;
            this.fLabelMedium1.Text = "Buscar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(1292, 536);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(1196, 536);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 34);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Pagar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // fGroupBox2
            // 
            this.fGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fGroupBox2.Controls.Add(this.dgvDatosRegistrados);
            this.fGroupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox2.Location = new System.Drawing.Point(16, 141);
            this.fGroupBox2.Name = "fGroupBox2";
            this.fGroupBox2.Size = new System.Drawing.Size(578, 432);
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
            this.customerDataGridViewTextBoxColumn,
            this.ExpirationDate});
            this.dgvDatosRegistrados.DataSource = this.uspListarClientesActivosResultBindingSource;
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
            this.dgvDatosRegistrados.Size = new System.Drawing.Size(572, 410);
            this.dgvDatosRegistrados.TabIndex = 0;
            this.dgvDatosRegistrados.SelectionChanged += new System.EventHandler(this.dgvDatosRegistrados_SelectionChanged);
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
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Cliente - Dirección";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "ExpirationDate";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            this.ExpirationDate.Visible = false;
            this.ExpirationDate.Width = 104;
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(9, 13);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(254, 41);
            this.fLabelBig1.TabIndex = 0;
            this.fLabelBig1.Text = "Listado de Clientes";
            // 
            // fComboBox1
            // 
            this.fComboBox1.DataSource = this.vGestoreBindingSource;
            this.fComboBox1.DisplayMember = "EmployeeName";
            this.fComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fComboBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fComboBox1.FormattingEnabled = true;
            this.fComboBox1.Location = new System.Drawing.Point(10, 145);
            this.fComboBox1.Name = "fComboBox1";
            this.fComboBox1.Size = new System.Drawing.Size(213, 23);
            this.fComboBox1.TabIndex = 5;
            this.fComboBox1.ValueMember = "ManagerId";
            // 
            // FrmPaymentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 590);
            this.Controls.Add(this.fGroupBox4);
            this.Controls.Add(this.fGroupBox3);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.fLabelBig1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPaymentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspListarClientesActivosResultBindingSource)).EndInit();
            this.fGroupBox4.ResumeLayout(false);
            this.fGroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGestoreBindingSource)).EndInit();
            this.fGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCronogramaPagoBindingSource)).EndInit();
            this.fGroupBox1.ResumeLayout(false);
            this.fGroupBox1.PerformLayout();
            this.fGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosRegistrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn planTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource uspListarClientesActivosResultBindingSource;
        private Controles_Standar.FGroupBox fGroupBox4;
        private Controles_Standar.FGroupBox fGroupBox3;
        private Controles_Standar.FDataGridView dgvPendientePago;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FTextBox txtBuscarCliente;
        private Controles_Standar.FLabelMedium fLabelMedium1;
        private Controles_Standar.FButtonCancelar btnCancelar;
        private Controles_Standar.FButtonEditar btnEditar;
        private Controles_Standar.FGroupBox fGroupBox2;
        private Controles_Standar.FDataGridView dgvDatosRegistrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private Controles_Standar.FLabelBig fLabelBig1;
        private Controles_Standar.FDateTimePicker dtpPayDay;
        private Controles_Standar.FLabelMedium fLabelMedium6;
        private Controles_Standar.FComboBox cboManagerId;
        private Controles_Standar.FTextBox txtPay;
        private Controles_Standar.FLabelMedium fLabelMedium5;
        private Controles_Standar.FLabelMedium fLabelMedium3;
        private Controles_Standar.FLabelMedium fLabelMedium2;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vCronogramaPagoBindingSource;
        private Controles_Standar.FButtonBuscar btnBuscar;
        private System.Windows.Forms.BindingSource vGestoreBindingSource;
        private Controles_Standar.FComboBox fComboBox1;
    }
}