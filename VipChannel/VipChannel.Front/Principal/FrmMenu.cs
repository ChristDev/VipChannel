using System;
using System.Windows.Forms;
using VipChannel.Application;
using VipChannel.Front.Definitions;
using VipChannel.Front.Definitions.Sucursal;
using VipChannel.Front.Definitions.Voucher;
using VipChannel.Front.Maintenance;
using VipChannel.Front.Maintenance.Service;
using VipChannel.Front.Payments;
using VipChannel.Front.Requests;
using VipChannel.Front.Sales;

namespace VipChannel.Front.Principal
{
    public partial class FrmMenu : Form
    {
        private QueryServerApplication _serverN;

        internal static string IdUserActive;
        internal static string UserActive;

        internal static string SucursalId;
        internal static string SaleBoxId;

        public FrmMenu(string idUserActive, string userActive, string sucursalId, string salesBoxId)
        {
            InitializeComponent();
            IdUserActive = idUserActive;
            UserActive = userActive;
            SucursalId = sucursalId;
            SaleBoxId = salesBoxId;
        }

        private void CargarParametros(string usuarioActivo)
        {
            _serverN = new QueryServerApplication();
            lblFecha.Text = _serverN.GetTimeServer().ToLongDateString().ToUpper();
            lblHora.Text = _serverN.GetTimeServer().ToLongTimeString().ToUpper();
            lblUsuario.Text = usuarioActivo.ToUpper();

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

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            CargarParametros(UserActive);
        }

        private void TickSecond_Tick(object sender, EventArgs e)
        {
            CargarParametros(UserActive);
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void gestoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManager.DefInstance.MdiParent = this;
            FrmManager.DefInstance.Show();
        }

        private void instalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRequestList.DefInstance.MdiParent = this;
            FrmRequestList.DefInstance.Show();
        }

        private void registroPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaymentsList.DefInstance.MdiParent = this;
            FrmPaymentsList.DefInstance.Show();
        }

        private void aperturaCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOpening.DefInstance.MdiParent = this;
            FrmOpening.DefInstance.Show();
        }
    }
}
