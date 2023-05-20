using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Constants;
using VipChannel.Front.Principal;
using VipChannel.Front.Sales;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Payments
{
    public partial class FrmPaymentsList : Form
    {
        private CronogramaPagosView _cronogramaPagos;
        private CustomerAddressApplication _customerAddressApplication;
        private VoucherApplication _voucherApplication;

        private GestorView _gestorView;
        public FrmPaymentsList()
        {
            InitializeComponent();
            Text = FormListNames.FrmCustomerList;
        }

        #region Abrir formulario solo una vez
        private static FrmPaymentsList _mFormDefInstance;
        public static FrmPaymentsList DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmPaymentsList();
                return _mFormDefInstance;
            }
            set
            {
                _mFormDefInstance = value;
            }
        }
        #endregion

        private void FrmList_Load(object sender, EventArgs e)
        {
            dgvDatosRegistrados.Select();
        }

        private void CargarDatos(string val)
        {
            _customerAddressApplication = new CustomerAddressApplication();
            uspListarClientesActivosResultBindingSource.DataSource = _customerAddressApplication.ListarClientesActivos().Where(x=>x.Customer.Contains(val)).ToList();


            _gestorView = new GestorView();
            vGestoreBindingSource.DataSource = _gestorView.SelectListView().ToList();

            _voucherApplication = new VoucherApplication();
            var id = Guid.Parse(FrmMenu.SaleBoxId);
            var dt = _voucherApplication.SelectList(x => x.SaleBoxId == id);
            cboVoucherId.DataSource = dt;
            cboVoucherId.DisplayMember = "Serie";
            cboVoucherId.ValueMember = "VoucherId";

            cboVoucherId.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarCliente.Text.Trim()))
            {
                uspListarClientesActivosResultBindingSource.DataSource = null;
                return;
            }

            CargarDatos(txtBuscarCliente.Text.Trim().ToUpper());    
        }


        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);

        }

        private void dgvDatosRegistrados_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDatosRegistrados.CurrentRow == null)
            {
                vCronogramaPagoBindingSource.DataSource = null;
                return;
            }

            _cronogramaPagos = new CronogramaPagosView();
            var customerAddressId = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[1].Value.ToString());

            vCronogramaPagoBindingSource.DataSource = _cronogramaPagos
                .SelectListView(x => x.CustomerAddressId == customerAddressId)
                .OrderBy(x => x.ExpirationDate);
        }

        private void dgvPendientePago_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPendientePago.CurrentRow == null)
            {
                txtPay.Text = string.Empty;
                return;
            }

            var pendiente = decimal.Parse(dgvPendientePago.CurrentRow.Cells[2].Value.ToString());

            txtPay.Text = pendiente.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

        }
    }
}
