using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Principal;

namespace VipChannel.Front.Definitions.Sucursal
{
    public partial class FrmSaleBox : Form
    {
        private Domain.Entity.SaleBox _saleBoxEntity;
        private SaleBoxApplication _saleBoxApplication;
        bool flag;

        private Guid _idSucursal;
        private string _nameSucursal;

        public FrmSaleBox(Guid idSucursal, string nameSucursal)
        {
            InitializeComponent();
            LoadData();
            _idSucursal = idSucursal;
            _nameSucursal = nameSucursal;
            var aaa = FrmMenu.variableCompartida;
        }


        #region Control de las acciones del formulario
        private void ControlesFormulario(bool act)
        {
            txtName.Enabled = !act;

            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                saleBoxBindingSource.ResumeBinding();
                LoadData();
            }
            else
            {
                if (flag)
                {
                    saleBoxBindingSource.SuspendBinding();
                }
                txtName.Focus();
            }
        }
        #endregion

        private void LoadData()
        {
            _saleBoxApplication = new SaleBoxApplication();
            saleBoxBindingSource.DataSource = _saleBoxApplication.SelectList(x=>x.SucursalId == _idSucursal);
        }

        private Domain.Entity.SaleBox SetFormData()
        {
            _saleBoxEntity = new Domain.Entity.SaleBox()
            {
                SaleBoxId = Guid.NewGuid(),
                SucursalId = _idSucursal,
                Name = txtName.Text.Trim(),
                UserRecordCreation = "LOAD",
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if (flag) return _saleBoxEntity;

            if (dgvDatosRegistrados.CurrentRow != null)
            {
                _saleBoxApplication = new SaleBoxApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _saleBoxApplication.SelectSingle(x => x.SaleBoxId == id, true);
                entity.Name = txtName.Text.Trim();
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
            _saleBoxApplication = new SaleBoxApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _saleBoxApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _saleBoxApplication = new SaleBoxApplication();

            var result = flag
                ? _saleBoxApplication.Insert(SetFormData())
                : _saleBoxApplication.Update(SetFormData());

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
            LoadData();
            ControlesFormulario(true);
            txtSucursalName.Text = _nameSucursal;
        }
    }
}
