using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Functions;
using VipChannel.Front.Principal;

namespace VipChannel.Front.Definitions
{
    public partial class FrmEmployee : Form
    {
        private Employee _employeeEntity;
        private EmployeeApplication _employeeApplication;
        private EmpleadoView _empleadoView;

        private HashByte _md5;
        private MasterTableApplication _masterTableApplication;
        private RoleApplication _roleApplication;
        bool flag;

        private string _userActive = FrmMenu.IdUserActive;

        public FrmEmployee()
        {
            InitializeComponent();
            LoadData();
        }

        #region Abrir formulario solo una vez
        private static FrmEmployee _mFormDefInstance;
        public static FrmEmployee DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmEmployee();
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
            cboTypeDocument.Enabled = !act;
            txtDocumentNumber.Enabled = !act;
            txtLastName.Enabled = !act;
            txtNames.Enabled = !act;
            cboRole.Enabled = !act;
            chkCambiarPassword.Enabled = !act;

            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                vEmpleadoBindingSource.ResumeBinding();
                LoadData();
            }
            else
            {
                if (flag)
                {
                    vEmpleadoBindingSource.SuspendBinding();
                }
                cboTypeDocument.Focus();
            }
        }
        #endregion

        private void LoadData()
        {
            _empleadoView = new EmpleadoView();
            vEmpleadoBindingSource.DataSource = _empleadoView.SelectListView();
        }

        public void CargarCombos()
        {
            _masterTableApplication = new MasterTableApplication();
            cboTypeDocument.DataSource = _masterTableApplication.SelectList(x => x.IdMasterTableParent == ConstantMasterTable.MasterTable.TypeDocument);            
            cboTypeDocument.DisplayMember = "Name";
            cboTypeDocument.ValueMember = "IdMasterTable";

            _roleApplication = new RoleApplication();
            roleBindingSource.DataSource = _roleApplication.SelectList(x=>x.RecordStatus == ConstantBase.Active && 
                                                                          x.IsEmployeeRole.Value);
        }

        private Employee SetFormData()
        {
            _md5 = new HashByte();  
            _employeeEntity = new Employee()
            {
                EmployeeId = Guid.NewGuid(),
                TypeDocument = cboTypeDocument.SelectedValue.ToString(),
                DocumentNumber = txtDocumentNumber.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Names = txtNames.Text.Trim(),
                RoleId = Guid.Parse(cboRole.SelectedValue.ToString()),
                Password = _md5.ConvertStringToMd5(txtPassword.Text.Trim()),
                UserRecordCreation = _userActive,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if (flag) return _employeeEntity;

            if (dgvDatosRegistrados.CurrentRow != null)
            {

                if (!chkCambiarPassword.Checked)
                {
                    if (!flag)
                    {
                        if (dgvDatosRegistrados.CurrentRow != null)
                        {
                            var idUsuario = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                            var password = _employeeApplication.GetPasswordByIdUsuario(idUsuario);
                            _employeeEntity.Password = password;
                        }
                    }
                }

                _employeeApplication = new EmployeeApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _employeeApplication.SelectSingle(x => x.EmployeeId == id, true);

                var passwordRegister = _md5.ConvertStringToMd5(txtPassword.Text.Trim());

                if(passwordRegister != _employeeEntity.Password && chkCambiarPassword.Checked) 
                { 
                    entity.Password = passwordRegister;
                }                
                entity.TypeDocument = cboTypeDocument.SelectedValue.ToString();
                entity.DocumentNumber = txtDocumentNumber.Text.Trim();
                entity.LastName = txtLastName.Text.Trim();
                entity.Names = txtNames.Text.Trim();
                entity.RoleId = Guid.Parse(cboRole.SelectedValue.ToString());


                entity.UserEditRecord = _userActive;
                entity.RecordEditDate = DateTime.Now;

                return entity;
            }

            return null;
        }

        private void CambiarPassword()
        {
            txtPassword.Enabled = chkCambiarPassword.Checked;
            txtPassword.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            flag = true;
            ControlesFormulario(false);
            chkCambiarPassword.Checked = true;
            CambiarPassword();
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
            _employeeApplication = new EmployeeApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _employeeApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _employeeApplication = new EmployeeApplication();

            var result = flag
                ? _employeeApplication.Insert(SetFormData())
                : _employeeApplication.Update(SetFormData());

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
            chkCambiarPassword.Checked = false;
        }

        private void FrmCajas_Load(object sender, EventArgs e)
        {
            
            this.dgvDatosRegistrados.Columns[0].Visible = false;

            LoadData();
            CargarCombos();
            ControlesFormulario(true);
            CambiarPassword();
        }

        private void chkCambiarPassword_CheckedChanged(object sender, EventArgs e)
        {
            CambiarPassword();
        }
    }
}
