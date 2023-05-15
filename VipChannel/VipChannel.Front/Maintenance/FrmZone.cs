using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Enums.MasterTables;

namespace VipChannel.Front.Maintenance
{
    public partial class FrmZone : Form
    {
        private Domain.Entity.Zone _zoneEntity;
        private ZoneApplication _zoneApplication;
        bool flag;

        public FrmZone()
        {
            InitializeComponent();
            CargarDatos();
        }

        #region Abrir formulario solo una vez
        private static FrmZone _mFormDefInstance;
        public static FrmZone DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmZone();
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
            txtDescription.Enabled = !act;
            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                zoneBindingSource.ResumeBinding();
                CargarDatos();
            }
            else
            {
                if (flag)
                {
                    zoneBindingSource.SuspendBinding();
                }
                txtDescription.Focus();
            }
        }
        #endregion

        private void CargarDatos()
        {
            _zoneApplication = new ZoneApplication();
            zoneBindingSource.DataSource = _zoneApplication.SelectList();
        }

        private Domain.Entity.Zone SetFormData()
        {
            _zoneEntity = new Domain.Entity.Zone()
            {
                ZoneId = Guid.NewGuid(),
                Description = txtDescription.Text.Trim(),
                UserRecordCreation = "LOAD",
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if(flag) return _zoneEntity;

            if(dgvDatosRegistrados.CurrentRow != null)
            {
                _zoneApplication = new ZoneApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _zoneApplication.SelectSingle(x=>x.ZoneId == id, true);
                entity.Description = txtDescription.Text.Trim();
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
            _zoneApplication = new ZoneApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _zoneApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _zoneApplication = new ZoneApplication();

            var result = flag
                ? _zoneApplication.Insert(SetFormData())
                : _zoneApplication.Update(SetFormData());

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvDatosRegistrados.Select();
            ControlesFormulario(true);
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            ControlesFormulario(true);
        }

        private void FrmZone_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ControlesFormulario(true);
        }

        private void btnAgregarDirecciones_Click(object sender, EventArgs e)
        {
            if (dgvDatosRegistrados.CurrentRow != null)
            {
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var zone = dgvDatosRegistrados.CurrentRow.Cells[1].Value.ToString();
                var form = new FrmAvenue(id, zone);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
