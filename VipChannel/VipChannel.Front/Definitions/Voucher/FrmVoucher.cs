using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;

namespace VipChannel.Front.Definitions.Voucher
{
    public partial class FrmVoucher : Form
    {
        private Domain.Entity.Voucher _voucherEntity;
        private VoucherApplication _voucherApplication;
        private MasterTableApplication _masterTableApplication;
        private TipoComprobantePorCajaView _tipoComprobantePorCajaView;

        bool flag;

        private Guid _idSaleBox;
        private string _nameSucursal;
        private string _nameSaleBox;


        public FrmVoucher(Guid idSaleBox, string nameSucursal, string nameSaleBox)
        {
            InitializeComponent();
            LoadData();
            _idSaleBox = idSaleBox;
            _nameSucursal = nameSucursal;
            _nameSaleBox = nameSaleBox;
        }


        #region Control de las acciones del formulario
        private void ControlesFormulario(bool act)
        {
            cboVoucherType.Enabled = !act;
            txtSerie.Enabled = !act;

            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                vTipoComprobantePorCajaBindingSource.ResumeBinding();
                LoadData();
            }
            else
            {
                if (flag)
                {
                    vTipoComprobantePorCajaBindingSource.SuspendBinding();
                }
                cboVoucherType.Focus();
            }
        }
        #endregion

        private void CargarCombo()
        {
            _masterTableApplication = new MasterTableApplication();
            cboVoucherType.DataSource = _masterTableApplication.SelectList(x => x.IdMasterTableParent == ConstantMasterTable.MasterTable.VoucherType);
            cboVoucherType.DisplayMember = "Name";
            cboVoucherType.ValueMember = "IdMasterTable";
        }

        private void LoadData()
        {
            _tipoComprobantePorCajaView = new TipoComprobantePorCajaView();
            vTipoComprobantePorCajaBindingSource.DataSource = _tipoComprobantePorCajaView.SelectListView(x=>x.SaleBoxId == _idSaleBox);
        }

        private Domain.Entity.Voucher SetFormData()
        {
            _voucherEntity = new Domain.Entity.Voucher()
            {
                VoucherId = Guid.NewGuid(),
                SaleBoxId = _idSaleBox,
                VoucherType = cboVoucherType.SelectedValue.ToString(),
                Serie = txtSerie.Text.Trim(),
                Number = int.Parse(txtNumber.Text.Trim()),
                UserRecordCreation = "LOAD",
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if (flag) return _voucherEntity;

            if (dgvDatosRegistrados.CurrentRow != null)
            {
                _voucherApplication = new VoucherApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _voucherApplication.SelectSingle(x => x.SaleBoxId == id, true);
                entity.VoucherType = cboVoucherType.SelectedValue.ToString();
                entity.Serie = txtSerie.Text.Trim();
                entity.Number = int.Parse(txtNumber.Text.Trim());
                entity.UserEditRecord = "LOAD";
                entity.RecordEditDate = DateTime.Now;

                return entity;
            }

            return null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            flag = true;
            ControlesFormulario(false);
            txtNumber.Text = "0";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            flag = false;
            ControlesFormulario(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _voucherApplication = new VoucherApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _voucherApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _voucherApplication = new VoucherApplication();

            var result = flag
                ? _voucherApplication.Insert(SetFormData())
                : _voucherApplication.Update(SetFormData());

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvDatosRegistrados.Select();
            ControlesFormulario(true);
            LoadData();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvDatosRegistrados.Select();
            ControlesFormulario(true);
            LoadData();
            txtSucursalName.Text = _nameSucursal;
        }

        private void FrmCajas_Load(object sender, EventArgs e)
        {
            CargarCombo();
            LoadData();
            ControlesFormulario(true);
            txtSucursalName.Text = _nameSucursal;
            txtSaleBoxName.Text = _nameSaleBox;
        }
    }
}
