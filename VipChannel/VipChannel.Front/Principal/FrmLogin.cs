using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Enums.MasterTables;

namespace VipChannel.Front.Principal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CargarCombo()
        {
            var employeeType = new MasterTableApplication();
            cboEmployeeType.DataSource = employeeType.SelectList(x=>x.IdMasterTableParent == ConstantMasterTable.MasterTable.EmployeeType);
            cboEmployeeType.DisplayMember = "Name";
            cboEmployeeType.ValueMember = "IdMasterTable";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new FrmMenu();
            menuPrincipal.Show();
        }
    }
}
