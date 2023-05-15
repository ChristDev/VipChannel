namespace VipChannel.Front.Plan
{
    partial class FrmPlanInternet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanInternet));
            this.lblTituloFormulario = new Controles_Standar.FLabelBig();
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium2 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium3 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium4 = new Controles_Standar.FLabelMedium();
            this.fLabelMedium6 = new Controles_Standar.FLabelMedium();
            this.txtDescription = new Controles_Standar.FTextBox();
            this.txtCost = new Controles_Standar.FTextBoxDouble();
            this.txtInternetUpload = new Controles_Standar.FTextBoxInt();
            this.cboUploadInternetSpeedType = new Controles_Standar.FComboBox();
            this.UploadInternetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboDownloadInternetSpeedType = new Controles_Standar.FComboBox();
            this.downloadInternetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtInternetDownload = new Controles_Standar.FTextBoxInt();
            this.txtInternalCode = new Controles_Standar.FTextBox();
            this.tipoPlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new Controles_Standar.FButtonGuardar();
            this.btnCancelar = new Controles_Standar.FButtonCancelar();
            this.fGroupBox2 = new Controles_Standar.FGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.UploadInternetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadInternetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPlanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloFormulario.Location = new System.Drawing.Point(5, 5);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(162, 41);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "Nuevo Plan";
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(12, 46);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(645, 15);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(8, 114);
            this.fLabelMedium1.Name = "fLabelMedium1";
            this.fLabelMedium1.Size = new System.Drawing.Size(122, 21);
            this.fLabelMedium1.TabIndex = 6;
            this.fLabelMedium1.Text = "Nombre del Plan";
            // 
            // fLabelMedium2
            // 
            this.fLabelMedium2.AutoSize = true;
            this.fLabelMedium2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium2.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium2.Location = new System.Drawing.Point(507, 114);
            this.fLabelMedium2.Name = "fLabelMedium2";
            this.fLabelMedium2.Size = new System.Drawing.Size(108, 21);
            this.fLabelMedium2.TabIndex = 8;
            this.fLabelMedium2.Text = "Precio del Plan";
            // 
            // fLabelMedium3
            // 
            this.fLabelMedium3.AutoSize = true;
            this.fLabelMedium3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium3.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium3.Location = new System.Drawing.Point(8, 164);
            this.fLabelMedium3.Name = "fLabelMedium3";
            this.fLabelMedium3.Size = new System.Drawing.Size(181, 21);
            this.fLabelMedium3.TabIndex = 10;
            this.fLabelMedium3.Text = "Max. Velocidad de Subida";
            // 
            // fLabelMedium4
            // 
            this.fLabelMedium4.AutoSize = true;
            this.fLabelMedium4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium4.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium4.Location = new System.Drawing.Point(358, 164);
            this.fLabelMedium4.Name = "fLabelMedium4";
            this.fLabelMedium4.Size = new System.Drawing.Size(177, 21);
            this.fLabelMedium4.TabIndex = 13;
            this.fLabelMedium4.Text = "Mín. Velocidad de Bajada";
            // 
            // fLabelMedium6
            // 
            this.fLabelMedium6.AutoSize = true;
            this.fLabelMedium6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium6.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium6.Location = new System.Drawing.Point(8, 64);
            this.fLabelMedium6.Name = "fLabelMedium6";
            this.fLabelMedium6.Size = new System.Drawing.Size(112, 21);
            this.fLabelMedium6.TabIndex = 2;
            this.fLabelMedium6.Text = "Código Interno";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(12, 138);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(435, 23);
            this.txtDescription.TabIndex = 7;
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(511, 138);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(144, 23);
            this.txtCost.TabIndex = 9;
            // 
            // txtInternetUpload
            // 
            this.txtInternetUpload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInternetUpload.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternetUpload.Location = new System.Drawing.Point(12, 188);
            this.txtInternetUpload.Name = "txtInternetUpload";
            this.txtInternetUpload.Size = new System.Drawing.Size(196, 23);
            this.txtInternetUpload.TabIndex = 11;
            this.txtInternetUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboUploadInternetSpeedType
            // 
            this.cboUploadInternetSpeedType.DataSource = this.UploadInternetBindingSource;
            this.cboUploadInternetSpeedType.DisplayMember = "Description";
            this.cboUploadInternetSpeedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUploadInternetSpeedType.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUploadInternetSpeedType.FormattingEnabled = true;
            this.cboUploadInternetSpeedType.Location = new System.Drawing.Point(214, 188);
            this.cboUploadInternetSpeedType.Name = "cboUploadInternetSpeedType";
            this.cboUploadInternetSpeedType.Size = new System.Drawing.Size(91, 23);
            this.cboUploadInternetSpeedType.TabIndex = 12;
            this.cboUploadInternetSpeedType.ValueMember = "Id";
            // 
            // UploadInternetBindingSource
            // 
            this.UploadInternetBindingSource.DataSource = typeof(VipChannel.Domain.Entity.SelectResponse);
            // 
            // cboDownloadInternetSpeedType
            // 
            this.cboDownloadInternetSpeedType.DataSource = this.downloadInternetBindingSource;
            this.cboDownloadInternetSpeedType.DisplayMember = "Description";
            this.cboDownloadInternetSpeedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDownloadInternetSpeedType.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDownloadInternetSpeedType.FormattingEnabled = true;
            this.cboDownloadInternetSpeedType.Location = new System.Drawing.Point(564, 189);
            this.cboDownloadInternetSpeedType.Name = "cboDownloadInternetSpeedType";
            this.cboDownloadInternetSpeedType.Size = new System.Drawing.Size(91, 23);
            this.cboDownloadInternetSpeedType.TabIndex = 15;
            this.cboDownloadInternetSpeedType.ValueMember = "Id";
            // 
            // downloadInternetBindingSource
            // 
            this.downloadInternetBindingSource.DataSource = typeof(VipChannel.Domain.Entity.SelectResponse);
            // 
            // txtInternetDownload
            // 
            this.txtInternetDownload.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInternetDownload.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternetDownload.Location = new System.Drawing.Point(362, 189);
            this.txtInternetDownload.Name = "txtInternetDownload";
            this.txtInternetDownload.Size = new System.Drawing.Size(196, 23);
            this.txtInternetDownload.TabIndex = 14;
            this.txtInternetDownload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInternalCode
            // 
            this.txtInternalCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtInternalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInternalCode.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternalCode.Location = new System.Drawing.Point(12, 88);
            this.txtInternalCode.MaxLength = 10;
            this.txtInternalCode.Name = "txtInternalCode";
            this.txtInternalCode.Size = new System.Drawing.Size(242, 23);
            this.txtInternalCode.TabIndex = 3;
            // 
            // tipoPlanBindingSource
            // 
            this.tipoPlanBindingSource.DataSource = typeof(VipChannel.Domain.Entity.SelectResponse);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(360, 240);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 34);
            this.btnGuardar.TabIndex = 17;
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
            this.btnCancelar.Location = new System.Drawing.Point(516, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 34);
            this.btnCancelar.TabIndex = 18;
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
            this.fGroupBox2.Location = new System.Drawing.Point(12, 219);
            this.fGroupBox2.Name = "fGroupBox2";
            this.fGroupBox2.Size = new System.Drawing.Size(645, 15);
            this.fGroupBox2.TabIndex = 16;
            this.fGroupBox2.TabStop = false;
            // 
            // FrmPlanInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 282);
            this.Controls.Add(this.fGroupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtInternalCode);
            this.Controls.Add(this.cboDownloadInternetSpeedType);
            this.Controls.Add(this.txtInternetDownload);
            this.Controls.Add(this.cboUploadInternetSpeedType);
            this.Controls.Add(this.txtInternetUpload);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.fLabelMedium6);
            this.Controls.Add(this.fLabelMedium4);
            this.Controls.Add(this.fLabelMedium3);
            this.Controls.Add(this.fLabelMedium2);
            this.Controls.Add(this.fLabelMedium1);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.lblTituloFormulario);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlanInternet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPlanInternet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UploadInternetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadInternetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPlanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig lblTituloFormulario;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FLabelMedium fLabelMedium1;
        private Controles_Standar.FLabelMedium fLabelMedium2;
        private Controles_Standar.FLabelMedium fLabelMedium3;
        private Controles_Standar.FLabelMedium fLabelMedium4;
        private Controles_Standar.FLabelMedium fLabelMedium6;
        private Controles_Standar.FTextBox txtDescription;
        private Controles_Standar.FTextBoxDouble txtCost;
        private Controles_Standar.FTextBoxInt txtInternetUpload;
        private Controles_Standar.FComboBox cboUploadInternetSpeedType;
        private Controles_Standar.FComboBox cboDownloadInternetSpeedType;
        private Controles_Standar.FTextBoxInt txtInternetDownload;
        private Controles_Standar.FTextBox txtInternalCode;
        private Controles_Standar.FButtonGuardar btnGuardar;
        private Controles_Standar.FButtonCancelar btnCancelar;
        private Controles_Standar.FGroupBox fGroupBox2;
        private System.Windows.Forms.BindingSource UploadInternetBindingSource;
        private System.Windows.Forms.BindingSource downloadInternetBindingSource;
        private System.Windows.Forms.BindingSource tipoPlanBindingSource;
    }
}