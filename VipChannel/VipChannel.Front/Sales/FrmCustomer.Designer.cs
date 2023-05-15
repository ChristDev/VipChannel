namespace VipChannel.Front.Sales
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.lblTituloFormulario = new Controles_Standar.FLabelBig();
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.btnGuardar = new Controles_Standar.FButtonGuardar();
            this.btnCancelar = new Controles_Standar.FButtonCancelar();
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            this.txtOptionalCellPhone = new Controles_Standar.FTextBox();
            this.fLabelMedium11 = new Controles_Standar.FLabelMedium();
            this.dtpBirthDate = new Controles_Standar.FDateTimePicker();
            this.cboDocumentType = new Controles_Standar.FComboBox();
            this.selectResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLabelMedium6 = new Controles_Standar.FLabelMedium();
            this.txtCellPhone = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium5 = new Controles_Standar.FLabelMedium();
            this.txtNames = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium4 = new Controles_Standar.FLabelMedium();
            this.txtLastName = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium3 = new Controles_Standar.FLabelMedium();
            this.txtDocumentNumber = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium2 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.txtEmail = new Controles_Standar.FTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloFormulario.Location = new System.Drawing.Point(5, 5);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(345, 41);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "Registro de Nuevo Cliente";
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(12, 47);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(965, 15);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(682, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 34);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar Registro";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(838, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 34);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar Registro";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // fGroupBox2
            // 
            this.fGroupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox2.Location = new System.Drawing.Point(12, 273);
            this.fGroupBox2.Name = "fGroupBox2";
            this.fGroupBox2.Size = new System.Drawing.Size(965, 15);
            this.fGroupBox2.TabIndex = 16;
            this.fGroupBox2.TabStop = false;
            // 
            // txtOptionalCellPhone
            // 
            this.txtOptionalCellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionalCellPhone.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionalCellPhone.Location = new System.Drawing.Point(476, 239);
            this.txtOptionalCellPhone.Name = "txtOptionalCellPhone";
            this.txtOptionalCellPhone.Size = new System.Drawing.Size(456, 23);
            this.txtOptionalCellPhone.TabIndex = 18;
            // 
            // fLabelMedium11
            // 
            this.fLabelMedium11.AutoSize = true;
            this.fLabelMedium11.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium11.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium11.Location = new System.Drawing.Point(8, 165);
            this.fLabelMedium11.Name = "fLabelMedium11";
            this.fLabelMedium11.Size = new System.Drawing.Size(150, 21);
            this.fLabelMedium11.TabIndex = 12;
            this.fLabelMedium11.Text = "Fecha de Nacimiento";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(10, 189);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(251, 23);
            this.dtpBirthDate.TabIndex = 13;
            // 
            // cboDocumentType
            // 
            this.cboDocumentType.DataSource = this.selectResponseBindingSource;
            this.cboDocumentType.DisplayMember = "Description";
            this.cboDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDocumentType.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDocumentType.FormattingEnabled = true;
            this.cboDocumentType.Location = new System.Drawing.Point(12, 89);
            this.cboDocumentType.Name = "cboDocumentType";
            this.cboDocumentType.Size = new System.Drawing.Size(251, 23);
            this.cboDocumentType.TabIndex = 3;
            this.cboDocumentType.ValueMember = "Id";
            // 
            // selectResponseBindingSource
            // 
            this.selectResponseBindingSource.DataSource = typeof(VipChannel.Domain.Entity.SelectResponse);
            // 
            // fLabelMedium6
            // 
            this.fLabelMedium6.AutoSize = true;
            this.fLabelMedium6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium6.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium6.Location = new System.Drawing.Point(267, 165);
            this.fLabelMedium6.Name = "fLabelMedium6";
            this.fLabelMedium6.Size = new System.Drawing.Size(56, 21);
            this.fLabelMedium6.TabIndex = 14;
            this.fLabelMedium6.Text = "Correo";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCellPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCellPhone.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellPhone.Location = new System.Drawing.Point(10, 239);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(456, 23);
            this.txtCellPhone.TabIndex = 17;
            // 
            // fLabelMedium5
            // 
            this.fLabelMedium5.AutoSize = true;
            this.fLabelMedium5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium5.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium5.Location = new System.Drawing.Point(8, 215);
            this.fLabelMedium5.Name = "fLabelMedium5";
            this.fLabelMedium5.Size = new System.Drawing.Size(70, 21);
            this.fLabelMedium5.TabIndex = 16;
            this.fLabelMedium5.Text = "Celulares";
            // 
            // txtNames
            // 
            this.txtNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNames.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNames.Location = new System.Drawing.Point(478, 139);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(456, 23);
            this.txtNames.TabIndex = 9;
            // 
            // fLabelMedium4
            // 
            this.fLabelMedium4.AutoSize = true;
            this.fLabelMedium4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium4.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium4.Location = new System.Drawing.Point(476, 115);
            this.fLabelMedium4.Name = "fLabelMedium4";
            this.fLabelMedium4.Size = new System.Drawing.Size(71, 21);
            this.fLabelMedium4.TabIndex = 8;
            this.fLabelMedium4.Text = "Nombres";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(12, 139);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(456, 23);
            this.txtLastName.TabIndex = 7;
            // 
            // fLabelMedium3
            // 
            this.fLabelMedium3.AutoSize = true;
            this.fLabelMedium3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium3.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium3.Location = new System.Drawing.Point(10, 115);
            this.fLabelMedium3.Name = "fLabelMedium3";
            this.fLabelMedium3.Size = new System.Drawing.Size(70, 21);
            this.fLabelMedium3.TabIndex = 6;
            this.fLabelMedium3.Text = "Apellidos";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumentNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocumentNumber.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentNumber.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentNumber.Location = new System.Drawing.Point(269, 90);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(199, 23);
            this.txtDocumentNumber.TabIndex = 5;
            // 
            // fLabelMedium2
            // 
            this.fLabelMedium2.AutoSize = true;
            this.fLabelMedium2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium2.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium2.Location = new System.Drawing.Point(267, 66);
            this.fLabelMedium2.Name = "fLabelMedium2";
            this.fLabelMedium2.Size = new System.Drawing.Size(149, 21);
            this.fLabelMedium2.TabIndex = 4;
            this.fLabelMedium2.Text = "Número Documento";
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(12, 65);
            this.fLabelMedium1.Name = "fLabelMedium1";
            this.fLabelMedium1.Size = new System.Drawing.Size(123, 21);
            this.fLabelMedium1.TabIndex = 2;
            this.fLabelMedium1.Text = "Tipo Documento";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(269, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(663, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 347);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtOptionalCellPhone);
            this.Controls.Add(this.fLabelMedium11);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cboDocumentType);
            this.Controls.Add(this.fLabelMedium6);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.fLabelMedium5);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.fLabelMedium4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.fLabelMedium3);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.fLabelMedium2);
            this.Controls.Add(this.fLabelMedium1);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.lblTituloFormulario);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPlanCable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig lblTituloFormulario;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FButtonGuardar btnGuardar;
        private Controles_Standar.FButtonCancelar btnCancelar;
        private Controles_Standar.FGroupBox fGroupBox2;
        private Controles_Standar.FTextBox txtOptionalCellPhone;
        private Controles_Standar.FLabelMedium fLabelMedium11;
        private Controles_Standar.FDateTimePicker dtpBirthDate;
        private Controles_Standar.FComboBox cboDocumentType;
        private Controles_Standar.FLabelMedium fLabelMedium6;
        private Controles_Standar.FTextBoxRequerido txtCellPhone;
        private Controles_Standar.FLabelMedium fLabelMedium5;
        private Controles_Standar.FTextBoxRequerido txtNames;
        private Controles_Standar.FLabelMedium fLabelMedium4;
        private Controles_Standar.FTextBoxRequerido txtLastName;
        private Controles_Standar.FLabelMedium fLabelMedium3;
        private Controles_Standar.FTextBoxRequerido txtDocumentNumber;
        private Controles_Standar.FLabelMedium fLabelMedium2;
        private Controles_Standar.FLabelMedium fLabelMedium1;
        private System.Windows.Forms.BindingSource selectResponseBindingSource;
        private Controles_Standar.FTextBox txtEmail;
    }
}