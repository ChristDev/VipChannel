using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Principal;

namespace VipChannel.Front.Definitions.Manager
{
    public partial class FrmManagerZone : Form
    {
        private bool flag;
        private ZonaView _zonaView;
        private ManagerZone _managerZoneEntity;

        private ManagerZoneApplication _managerZoneApplication;
        private CobradorPorZonaView _cobradorPorZonaView;
        private string _userActive = FrmMenu.IdUserActive;

        private Guid _id;
        private string _employee;

        public FrmManagerZone(Guid id, string employee)
        {
            _id = id;
            _employee = employee;
            
            InitializeComponent();
            LoadData();
        }

        #region Control de las acciones del formulario
        private void ControlesFormulario(bool act)
        {            
            cboZone.Enabled = !act;

            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                vCobradorPorZonaBindingSource.ResumeBinding();
                LoadData();
            }
            else
            {
                if (flag)
                {
                    vCobradorPorZonaBindingSource.SuspendBinding();
                }
                cboZone.Focus();
            }
        }
        #endregion

        private void LoadData()
        {
            CargarCombos();
            txtCobrador.Text = _employee;

            _cobradorPorZonaView = new CobradorPorZonaView();
            vCobradorPorZonaBindingSource.DataSource = _cobradorPorZonaView.SelectListView(x => x.ManagerId == _id && x.RecordStatus == ConstantBase.Active);
        }

        public void CargarCombos()
        {
            _zonaView = new ZonaView();
            vZonaBindingSource.DataSource = _zonaView.SelectListView();
        }

        private ManagerZone SetFormData()
        {
            _managerZoneEntity = new ManagerZone()
            {
                ManagerZoneId = Guid.NewGuid(),
                ManagerId = _id,
                ZoneId = Guid.Parse(cboZone.SelectedValue.ToString()),
                UserRecordCreation = _userActive,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if (flag) return _managerZoneEntity;

            if (dgvDatosRegistrados.CurrentRow != null)
            {
                _managerZoneApplication = new ManagerZoneApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _managerZoneApplication.SelectSingle(x => x.ManagerZoneId == id, true);

                entity.ManagerId = entity.ManagerId;
                entity.ZoneId = entity.ZoneId;
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
            _managerZoneApplication = new ManagerZoneApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _managerZoneApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _managerZoneApplication = new ManagerZoneApplication();
            
            var result = flag
                ? _managerZoneApplication.Insert(SetFormData())
                : _managerZoneApplication.Update(SetFormData());

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
            this.dgvDatosRegistrados.Columns[0].Visible = false;
            LoadData();
            CargarCombos();
            ControlesFormulario(true);
        }
    }
}
