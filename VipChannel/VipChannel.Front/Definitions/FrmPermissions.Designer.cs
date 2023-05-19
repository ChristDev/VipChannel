namespace VipChannel.Front.Definitions
{
    partial class FrmPermissions
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("GENERAL");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("SUCURSAL");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("COMPROBANTES");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ROLES");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("EMPLEADOS");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("TECNICOS");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("GESTORES");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("SALIR");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("AJUSTES", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ZONAS");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("SERVICIOS");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("MANTENIMIENTOS", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("INTERNET");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("CABLE");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("PAQUETES");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("PLANES", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("CLIENTE");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("VENTAS", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPermissions));
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("INSTALACION");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("SOLICITUDES", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            this.fGroupBox1 = new Controles_Standar.FGroupBox();
            this.txtDescripcion = new Controles_Standar.FTextBoxRequerido();
            this.fLabelMedium1 = new Controles_Standar.FLabelMedium();
            this.fLabelBig1 = new Controles_Standar.FLabelBig();
            this.treeViewAjustes = new Controles_Standar.FTreeView();
            this.treeViewMantenimientos = new Controles_Standar.FTreeView();
            this.treeViewPlanes = new Controles_Standar.FTreeView();
            this.treeViewVentas = new Controles_Standar.FTreeView();
            this.btnSalir = new Controles_Standar.FButtonSalir();
            this.btnAceptar = new Controles_Standar.FButtonAceptar();
            this.treeViewSolicitudes = new Controles_Standar.FTreeView();
            this.fGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fGroupBox1
            // 
            this.fGroupBox1.Controls.Add(this.txtDescripcion);
            this.fGroupBox1.Controls.Add(this.fLabelMedium1);
            this.fGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fGroupBox1.Location = new System.Drawing.Point(13, 63);
            this.fGroupBox1.Name = "fGroupBox1";
            this.fGroupBox1.Size = new System.Drawing.Size(564, 56);
            this.fGroupBox1.TabIndex = 1;
            this.fGroupBox1.TabStop = false;
            this.fGroupBox1.Text = "Datos del Rol";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(43, 20);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(515, 23);
            this.txtDescripcion.TabIndex = 3;
            // 
            // fLabelMedium1
            // 
            this.fLabelMedium1.AutoSize = true;
            this.fLabelMedium1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelMedium1.ForeColor = System.Drawing.Color.Black;
            this.fLabelMedium1.Location = new System.Drawing.Point(6, 20);
            this.fLabelMedium1.Name = "fLabelMedium1";
            this.fLabelMedium1.Size = new System.Drawing.Size(31, 21);
            this.fLabelMedium1.TabIndex = 0;
            this.fLabelMedium1.Text = "Rol";
            // 
            // fLabelBig1
            // 
            this.fLabelBig1.AutoSize = true;
            this.fLabelBig1.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLabelBig1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fLabelBig1.Location = new System.Drawing.Point(12, 9);
            this.fLabelBig1.Name = "fLabelBig1";
            this.fLabelBig1.Size = new System.Drawing.Size(232, 41);
            this.fLabelBig1.TabIndex = 0;
            this.fLabelBig1.Text = "Gestión Permisos";
            // 
            // treeViewAjustes
            // 
            this.treeViewAjustes.CheckBoxes = true;
            this.treeViewAjustes.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAjustes.Location = new System.Drawing.Point(13, 150);
            this.treeViewAjustes.Name = "treeViewAjustes";
            treeNode1.Name = "Node1";
            treeNode1.Text = "GENERAL";
            treeNode2.Name = "Node0";
            treeNode2.Text = "SUCURSAL";
            treeNode3.Name = "Node1";
            treeNode3.Text = "COMPROBANTES";
            treeNode4.Name = "Node2";
            treeNode4.Text = "ROLES";
            treeNode5.Name = "Node3";
            treeNode5.Text = "EMPLEADOS";
            treeNode6.Name = "Node4";
            treeNode6.Text = "TECNICOS";
            treeNode7.Name = "Node5";
            treeNode7.Text = "GESTORES";
            treeNode8.Name = "Node6";
            treeNode8.Text = "SALIR";
            treeNode9.Name = "Node0";
            treeNode9.Text = "AJUSTES";
            this.treeViewAjustes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeViewAjustes.Size = new System.Drawing.Size(279, 398);
            this.treeViewAjustes.TabIndex = 4;
            this.treeViewAjustes.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAjustes_AfterCheck);
            // 
            // treeViewMantenimientos
            // 
            this.treeViewMantenimientos.CheckBoxes = true;
            this.treeViewMantenimientos.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewMantenimientos.Location = new System.Drawing.Point(298, 150);
            this.treeViewMantenimientos.Name = "treeViewMantenimientos";
            treeNode10.Name = "Node1";
            treeNode10.Text = "ZONAS";
            treeNode11.Name = "Node0";
            treeNode11.Text = "SERVICIOS";
            treeNode12.Name = "Node0";
            treeNode12.Text = "MANTENIMIENTOS";
            this.treeViewMantenimientos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeViewMantenimientos.Size = new System.Drawing.Size(279, 64);
            this.treeViewMantenimientos.TabIndex = 6;
            this.treeViewMantenimientos.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMantenimientos_AfterCheck);
            // 
            // treeViewPlanes
            // 
            this.treeViewPlanes.CheckBoxes = true;
            this.treeViewPlanes.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewPlanes.Location = new System.Drawing.Point(298, 220);
            this.treeViewPlanes.Name = "treeViewPlanes";
            treeNode13.Name = "Node1";
            treeNode13.Text = "INTERNET";
            treeNode14.Name = "Node0";
            treeNode14.Text = "CABLE";
            treeNode15.Name = "Node0";
            treeNode15.Text = "PAQUETES";
            treeNode16.Name = "Node0";
            treeNode16.Text = "PLANES";
            this.treeViewPlanes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeViewPlanes.Size = new System.Drawing.Size(279, 86);
            this.treeViewPlanes.TabIndex = 7;
            this.treeViewPlanes.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPlanes_AfterCheck);
            // 
            // treeViewVentas
            // 
            this.treeViewVentas.CheckBoxes = true;
            this.treeViewVentas.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewVentas.Location = new System.Drawing.Point(298, 312);
            this.treeViewVentas.Name = "treeViewVentas";
            treeNode17.Name = "Node0";
            treeNode17.Text = "CLIENTE";
            treeNode18.Name = "Node0";
            treeNode18.Text = "VENTAS";
            this.treeViewVentas.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeViewVentas.Size = new System.Drawing.Size(279, 64);
            this.treeViewVentas.TabIndex = 8;
            this.treeViewVentas.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewVentas_AfterCheck);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(487, 514);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 34);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(391, 514);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 34);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // treeViewSolicitudes
            // 
            this.treeViewSolicitudes.CheckBoxes = true;
            this.treeViewSolicitudes.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSolicitudes.Location = new System.Drawing.Point(298, 382);
            this.treeViewSolicitudes.Name = "treeViewSolicitudes";
            treeNode19.Name = "Node1";
            treeNode19.Text = "INSTALACION";
            treeNode20.Name = "Node0";
            treeNode20.Text = "SOLICITUDES";
            this.treeViewSolicitudes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeViewSolicitudes.Size = new System.Drawing.Size(279, 64);
            this.treeViewSolicitudes.TabIndex = 14;
            this.treeViewSolicitudes.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSolicitudes_AfterCheck);
            // 
            // FrmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 557);
            this.Controls.Add(this.treeViewSolicitudes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.treeViewVentas);
            this.Controls.Add(this.treeViewPlanes);
            this.Controls.Add(this.treeViewMantenimientos);
            this.Controls.Add(this.treeViewAjustes);
            this.Controls.Add(this.fGroupBox1);
            this.Controls.Add(this.fLabelBig1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPermissions";
            this.fGroupBox1.ResumeLayout(false);
            this.fGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles_Standar.FLabelBig fLabelBig1;
        private Controles_Standar.FGroupBox fGroupBox1;
        private Controles_Standar.FTreeView treeViewAjustes;
        private Controles_Standar.FTreeView treeViewMantenimientos;
        private Controles_Standar.FTreeView treeViewPlanes;
        private Controles_Standar.FTreeView treeViewVentas;
        private Controles_Standar.FButtonSalir btnSalir;
        private Controles_Standar.FButtonAceptar btnAceptar;
        private Controles_Standar.FLabelMedium fLabelMedium1;
        private Controles_Standar.FTextBoxRequerido txtDescripcion;
        private Controles_Standar.FTreeView treeViewSolicitudes;
    }
}