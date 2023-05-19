using System;
using System.Linq;
using System.Windows.Forms;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Definitions;
using VipChannel.Front.Definitions.Sucursal;
using VipChannel.Front.Definitions.Voucher;
using VipChannel.Front.Maintenance;
using VipChannel.Front.Maintenance.Service;
using VipChannel.Front.Requests;
using VipChannel.Front.Requests.Serve;
using VipChannel.Front.Sales;

namespace VipChannel.Front.Principal
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan.FrmPlanInternetList.DefInstance.MdiParent = this;
            Plan.FrmPlanInternetList.DefInstance.Show();
        }

        private void cableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan.FrmPlanCableList.DefInstance.MdiParent = this;
            Plan.FrmPlanCableList.DefInstance.Show();
        }

        private void paquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plan.FrmPlanPersonalizadoList.DefInstance.MdiParent = this;
            Plan.FrmPlanPersonalizadoList.DefInstance.Show();
        }

        private void zonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmZone.DefInstance.MdiParent = this;
            FrmZone.DefInstance.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServiceList.DefInstance.MdiParent = this;
            FrmServiceList.DefInstance.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeneral.DefInstance.MdiParent = this;
            FrmGeneral.DefInstance.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSucursalList.DefInstance.MdiParent = this;
            FrmSucursalList.DefInstance.Show();
        }

        private void comprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaleBoxList.DefInstance.MdiParent = this;
            FrmSaleBoxList.DefInstance.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRole.DefInstance.MdiParent = this;
            FrmRole.DefInstance.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee.DefInstance.MdiParent = this;
            FrmEmployee.DefInstance.Show();
        }

        private void tecnicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTechnical.DefInstance.MdiParent = this;
            FrmTechnical.DefInstance.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCustomerList.DefInstance.MdiParent = this;
            FrmCustomerList.DefInstance.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRequestList.DefInstance.MdiParent = this;
            FrmRequestList.DefInstance.Show();
        }
    }
}
