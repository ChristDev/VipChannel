using System;
using System.Linq;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Principal;

namespace VipChannel.Front.Definitions.Sucursal
{
    public partial class FrmSucursalList : Form
    {
        private CompanyApplication _companyApplication;
        private Company _companyEntity;
        private Guid _idCompany;


        private Domain.Entity.Sucursal _sucursalEntity;
        private SucursalApplication _sucursalApplication;
        bool flag;

        private string _userActive = FrmMenu.IdUserActive;
        public FrmSucursalList()
        {
            InitializeComponent();
            LoadData();
        }

        #region Abrir formulario solo una vez
        private static FrmSucursalList _mFormDefInstance;
        public static FrmSucursalList DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmSucursalList();
                return _mFormDefInstance;
            }
            set
            {
                _mFormDefInstance = value;
            }
        }
        #endregion

        #region Control de las acciones del formulario
        private void ControlesFormulario(bool act)
        {
            txtName.Enabled = !act;
            txtAddressSucursal.Enabled = !act;

            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                sucursalBindingSource.ResumeBinding();
                LoadData();
            }
            else
            {
                if (flag)
                {
                    sucursalBindingSource.SuspendBinding();
                }
                txtName.Focus();
            }
        }
        #endregion

        private Company ObtenerConfiguracion()
        {
            _companyApplication = new CompanyApplication();

            var company = _companyApplication.SelectList(x => x.RecordStatus == ConstantBase.Active);
            if (company.Count == 0)
            {
                return null;
            }
            else
            {
                return company.FirstOrDefault();
            }
        }

        private void LoadData()
        {
            _sucursalApplication = new SucursalApplication();
            sucursalBindingSource.DataSource = _sucursalApplication.SelectList();
        }

        private Domain.Entity.Sucursal SetFormData()
        {
            _sucursalEntity = new Domain.Entity.Sucursal()
            {
                SucursalId = Guid.NewGuid(),
                CompanyId = _idCompany,
                Name = txtName.Text.Trim(),
                AddressSucursal = txtAddressSucursal.Text,
                UserRecordCreation = _userActive,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if (flag) return _sucursalEntity;

            if (dgvDatosRegistrados.CurrentRow != null)
            {
                _sucursalApplication = new SucursalApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _sucursalApplication.SelectSingle(x => x.SucursalId == id, true);

                entity.Name = txtName.Text.Trim();
                entity.AddressSucursal = txtAddressSucursal.Text;
                entity.UserEditRecord = _userActive;
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
            _sucursalApplication = new SucursalApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _sucursalApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _sucursalApplication = new SucursalApplication();

            var result = flag
                ? _sucursalApplication.Insert(SetFormData())
                : _sucursalApplication.Update(SetFormData());

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
        }

        private void FrmCajas_Load(object sender, EventArgs e)
        {
            
            LoadData();
            ControlesFormulario(true);

            _companyEntity = ObtenerConfiguracion();
            if (_companyEntity == null)
            {
                MessageBox.Show("No se ha configurado la empresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                txtCompanyName.Text = _companyEntity.BusinessName;
                _idCompany = _companyEntity.CompanyId;
            }
        }

        private void btnAgregarCajas_Click(object sender, EventArgs e)
        {
            if (dgvDatosRegistrados.CurrentRow != null)
            {
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var sucursal = dgvDatosRegistrados.CurrentRow.Cells[2].Value.ToString();
                var form = new FrmSaleBox(id, sucursal);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
