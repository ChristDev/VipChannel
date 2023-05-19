using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Constants;
using VipChannel.Front.Principal;

namespace VipChannel.Front.Definitions
{
    public partial class FrmRole : Form
    {
        private Role _rolEntity;
        private RoleApplication _rolApplication;
        bool flag;

        private string _userActive = FrmMenu.IdUserActive;

        public FrmRole()
        {
            InitializeComponent();
            LoadData();
        }

        #region Abrir formulario solo una vez
        private static FrmRole _mFormDefInstance;
        public static FrmRole DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmRole();
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
            txtDescription.Enabled = !act;
            rbtIsEmployeeRole.Enabled = !act;
            rbtIsTechnicalRole.Enabled = !act;

            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                roleBindingSource.ResumeBinding();
                LoadData();
            }
            else
            {
                if (flag)
                {
                    roleBindingSource.SuspendBinding();
                }
                txtName.Focus();
            }
        }
        #endregion

        private void LoadData()
        {
            _rolApplication = new RoleApplication();
            roleBindingSource.DataSource = _rolApplication.SelectList();
        }

         private Role SetFormData()
        {
            var optionAjustes = OptionAjustes.AJUSTES +
                OptionAjustes.GENERAL +
                OptionAjustes.SUCURSAL +
                OptionAjustes.COMPROBANTES +
                OptionAjustes.ROLES +
                OptionAjustes.EMPLEADOS+
                OptionAjustes.TECNICOS +
                OptionAjustes.GESTORES +
                OptionAjustes.SALIR;

            var optionMantenimientos = OptionMantenimientos.MANTENIMIENTOS +
                OptionMantenimientos.ZONAS +
                OptionMantenimientos.SERVICIOS;

            var optionPlanes = OptionPlanes.PLANES +
                OptionPlanes.INTERNET +
                OptionPlanes.CABLE +
                OptionPlanes.PAQUETES;

            var optionVentas = OptionVentas.VENTAS +
                OptionVentas.CLIENTE;

            var optionSolicitudes = OptionSolicitudes.SOLICITUDES +
                OptionSolicitudes.INSTALACIONES;

            var permissions = optionAjustes + 
                optionMantenimientos +
                optionPlanes +
                optionVentas +
                optionSolicitudes;

            _rolEntity = new Role()
            {
                RoleId = Guid.NewGuid(),
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                IsEmployeeRole = rbtIsEmployeeRole.Checked,
                IsTechnicalRole = rbtIsTechnicalRole.Checked,                
                UserRecordCreation = _userActive,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if (flag) return _rolEntity;

            if (dgvDatosRegistrados.CurrentRow != null)
            {
                _rolApplication = new RoleApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _rolApplication.SelectSingle(x => x.RoleId == id, true);
                entity.Name = txtName.Text.Trim();
                entity.Description = txtDescription.Text.Trim();
                entity.IsEmployeeRole = rbtIsEmployeeRole.Checked;
                entity.IsTechnicalRole = rbtIsTechnicalRole.Checked;
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
            _rolApplication = new RoleApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _rolApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _rolApplication = new RoleApplication();

            var result = flag
                ? _rolApplication.Insert(SetFormData())
                : _rolApplication.Update(SetFormData());

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
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            if (dgvDatosRegistrados.CurrentRow == null) return;
            var idRol = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
            var nombreRol = dgvDatosRegistrados.CurrentRow.Cells[1].Value.ToString();
            var oFrm = new FrmPermissions(idRol, nombreRol);
            oFrm.Show();
        }
    }
}
