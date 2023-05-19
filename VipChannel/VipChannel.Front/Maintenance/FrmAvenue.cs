using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Principal;

namespace VipChannel.Front.Maintenance
{
    public partial class FrmAvenue : Form
    {
        private Domain.Entity.Avenue _avenueEntity;
        private AvenueApplication _avenueApplication;

        private Guid _idZone;
        private string _descriptionZone;
        bool flag;

        private string _userActive = FrmMenu.IdUserActive;

        public FrmAvenue(Guid id, string zone)
        {
            InitializeComponent();
            _idZone = id;
            _descriptionZone = zone;
            CargarDatos();
        }

        #region Control de las acciones del formulario
        private void ControlesFormulario(bool act)
        {
            txtCode.Enabled = !act;
            txtDescription.Enabled = !act;

            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                avenueBindingSource.ResumeBinding();
                CargarDatos();
            }
            else
            {
                if (flag)
                {
                    avenueBindingSource.SuspendBinding();
                }
                txtDescription.Focus();
            }
        }
        #endregion

        private void CargarDatos()
        {
            _avenueApplication = new AvenueApplication();
            avenueBindingSource.DataSource = _avenueApplication.SelectList(x=>x.ZoneId == _idZone);
        }

        private Domain.Entity.Avenue SetFormData()
        {
            _avenueEntity = new Domain.Entity.Avenue()
            {
                AvenueId = Guid.NewGuid(),                
                ZoneId = _idZone,
                Code = txtCode.Text,
                Description = txtDescription.Text.Trim(),
                UserRecordCreation = _userActive,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if(flag) return _avenueEntity;

            if(dgvDatosRegistrados.CurrentRow != null)
            {
                _avenueApplication = new AvenueApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _avenueApplication.SelectSingle(x=>x.AvenueId == id, true);
                entity.Code = txtCode.Text;
                entity.Description = txtDescription.Text.Trim();
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
            _avenueApplication = new AvenueApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _avenueApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _avenueApplication = new AvenueApplication();

            var result = flag
                ? _avenueApplication.Insert(SetFormData())
                : _avenueApplication.Update(SetFormData());

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvDatosRegistrados.Select();
            ControlesFormulario(true);
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            ControlesFormulario(true);
            txtZone.Text = _descriptionZone;
        }

        private void FrmAvenue_Load(object sender, EventArgs e)
        {
            CargarDatos();
            ControlesFormulario(true);
            txtZone.Text = _descriptionZone;
        }
    }
}
