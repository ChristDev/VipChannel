using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Plan;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Definitions.Voucher
{
    public partial class FrmSaleBoxList : Form
    {
        private SucursalPorCajaView _sucursalPorCajaView;

        public FrmSaleBoxList()
        {
            InitializeComponent();
            LoadData();
        }

        #region Abrir formulario solo una vez
        private static FrmSaleBoxList _mFormDefInstance;
        public static FrmSaleBoxList DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmSaleBoxList();
                return _mFormDefInstance;
            }
            set
            {
                _mFormDefInstance = value;
            }
        }
        #endregion

        private void LoadData()
        {
            _sucursalPorCajaView = new SucursalPorCajaView();
            vSucursalPorCajaBindingSource.DataSource = _sucursalPorCajaView.SelectListView();
        }

        private void FrmCajas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConfigurarComprobante_Click(object sender, EventArgs e)
        {
            if (dgvDatosRegistrados.CurrentRow != null)
            {
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var sucursal = dgvDatosRegistrados.CurrentRow.Cells[1].Value.ToString();
                var caja = dgvDatosRegistrados.CurrentRow.Cells[2].Value.ToString();
                var form = new FrmVoucher(id, sucursal, caja);
                if (DialogResult.OK == form.ShowDialog())
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
