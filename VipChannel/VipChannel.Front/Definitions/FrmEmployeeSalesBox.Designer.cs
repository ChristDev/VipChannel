namespace VipChannel.Front.Definitions
{
    partial class FrmEmployeeSalesBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeSalesBox));
            this.btnCancelar = new Controles_Standar.FButtonCancelar();
            this.btnGuardar = new Controles_Standar.FButtonGuardar();
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.cboSaleBoxId = new Controles_Standar.FComboBox();
            this.saleBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboSucursalId = new Controles_Standar.FComboBox();
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLabelMedium3 = new Controles_Standar.FLabelMedium();
            this.txtEmployee = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium2 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.fGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(387, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 34);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(291, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 34);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Controls.Add(this.cboSaleBoxId);
            this.fGroupBox1.Controls.Add(this.cboSucursalId);
            this.fGroupBox1.Controls.Add(this.fLabelMedium3);
            this.fGroupBox1.Controls.Add(this.txtEmployee);
            this.fGroupBox1.Controls.Add(this.fLabelMedium2);
            this.fGroupBox1.Controls.Add(this.fLabelMedium1);
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(13, 63);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(475, 182);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
            this.fGroupBox1.Text = "Datos del Empleado";
            // 
            // cboSaleBoxId
            // 
            this.cboSaleBoxId.DataSource = this.saleBoxBindingSource;
            this.cboSaleBoxId.DisplayMember = "Name";
            this.cboSaleBoxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaleBoxId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSaleBoxId.FormattingEnabled = true;
            this.cboSaleBoxId.Location = new System.Drawing.Point(10, 143);
            this.cboSaleBoxId.Name = "cboSaleBoxId";
            this.cboSaleBoxId.Size = new System.Drawing.Size(351, 23);
            this.cboSaleBoxId.TabIndex = 5;
            this.cboSaleBoxId.ValueMember = "SaleBoxId";
            // 
            // saleBoxBindingSource
            // 
            this.saleBoxBindingSource.DataSource = typeof(VipChannel.Domain.Entity.SaleBox);
            // 
            // cboSucursalId
            // 
            this.cboSucursalId.DataSource = this.sucursalBindingSource;
            this.cboSucursalId.DisplayMember = "Name";
            this.cboSucursalId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursalId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSucursalId.FormattingEnabled = true;
            this.cboSucursalId.Location = new System.Drawing.Point(8, 93);
            this.cboSucursalId.Name = "cboSucursalId";
            this.cboSucursalId.Size = new System.Drawing.Size(351, 23);
            this.cboSucursalId.TabIndex = 3;
            this.cboSucursalId.ValueMember = "SucursalId";
            this.cboSucursalId.SelectedIndexChanged += new System.EventHandler(this.cboSucursalId_SelectedIndexChanged);
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(VipChannel.Domain.Entity.Sucursal);
            // 
            // fLabelMedium3
            // 
            this.fLabelMedium3.AutoSize = true;
            this.fLabelMedium3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium3.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium3.Location = new System.Drawing.Point(6, 119);
            this.fLabelMedium3.Name = "fLabelMedium3";
            this.fLabelMedium3.Size = new System.Drawing.Size(39, 21);
            this.fLabelMedium3.TabIndex = 4;
            this.fLabelMedium3.Text = "Caja";
            // 
            // txtEmployee
            // 
            this.txtEmployee.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmployee.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(8, 43);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(456, 23);
            this.txtEmployee.TabIndex = 1;
            this.txtEmployee.TabStop = false;
            // 
            // fLabelMedium2
            // 
            this.fLabelMedium2.AutoSize = true;
            this.fLabelMedium2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium2.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium2.Location = new System.Drawing.Point(6, 69);
            this.fLabelMedium2.Name = "fLabelMedium2";
            this.fLabelMedium2.Size = new System.Drawing.Size(65, 21);
            this.fLabelMedium2.TabIndex = 2;
            this.fLabelMedium2.Text = "Sucursal";
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(6, 19);
            this.fLabelMedium1.Name = "fLabelMedium1";
            this.fLabelMedium1.Size = new System.Drawing.Size(77, 21);
            this.fLabelMedium1.TabIndex = 0;
            this.fLabelMedium1.Text = "Empleado";
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(12, 9);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(258, 41);
            this.fLabelBig1.TabIndex = 0;
            this.fLabelBig1.Text = "Asignación de Caja";
            // 
            // FrmEmployeeSalesBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 301);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.fLabelBig1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEmployeeSalesBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.fGroupBox1.ResumeLayout(false);
            this.fGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleBoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig fLabelBig1;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FLabelMedium fLabelMedium1;
        private Controles_Standar.FButtonCancelar btnCancelar;
        private Controles_Standar.FButtonGuardar btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn descipcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private Controles_Standar.FLabelMedium fLabelMedium3;
        private Controles_Standar.FTextBoxRequerido txtEmployee;
        private Controles_Standar.FLabelMedium fLabelMedium2;
        private Controles_Standar.FComboBox cboSucursalId;
        private Controles_Standar.FComboBox cboSaleBoxId;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private System.Windows.Forms.BindingSource saleBoxBindingSource;
    }
}