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
    public partial class FrmManager : Form
    {
        private Manager _managerEntity;
        private ManagerApplication _managerApplication;

        private MasterTableApplication _masterTableApplication;
        bool flag;

        private string _userActive = FrmMenu.IdUserActive;

        public FrmManager()
        {
            InitializeComponent();
            LoadData();
        }

        #region Abrir formulario solo una vez
        private static FrmManager _mFormDefInstance;
        public static FrmManager DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmManager();
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

            btnNuevo.Enabled = act;
            btnEditar.Enabled = act;
            btnEliminar.Enabled = act;
            btnGuardar.Enabled = !act;
            btnCancelar.Enabled = !act;
            if (act)
            {
                managerBindingSource.ResumeBinding();
                LoadData();
            }
            else
            {
                if (flag)
                {
                    managerBindingSource.SuspendBinding();
                }
                cboTypeDocument.Focus();
            }
        }
        #endregion

        private void LoadData()
        {
            _managerApplication = new ManagerApplication();
            managerBindingSource.DataSource = _managerApplication.SelectList(x=>x.RecordStatus == ConstantBase.Active);
        }

        public void CargarCombos()
        {
            _masterTableApplication = new MasterTableApplication();
            cboTypeDocument.DataSource = _masterTableApplication.SelectList(x => x.IdMasterTableParent == ConstantMasterTable.MasterTable.TypeDocument);            
            cboTypeDocument.DisplayMember = "Name";
            cboTypeDocument.ValueMember = "IdMasterTable";
        }

        private Manager SetFormData()
        {
            _managerEntity = new Manager()
            {
                ManagerId = Guid.NewGuid(),
                TypeDocument = cboTypeDocument.SelectedValue.ToString(),
                DocumentNumber = txtDocumentNumber.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Names = txtNames.Text.Trim(),
                UserRecordCreation = _userActive,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            if (flag) return _managerEntity;

            if (dgvDatosRegistrados.CurrentRow != null)
            {
                _managerApplication = new ManagerApplication();
                var id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var entity = _managerApplication.SelectSingle(x => x.ManagerId == id, true);
                          
                entity.TypeDocument = cboTypeDocument.SelectedValue.ToString();
                entity.DocumentNumber = txtDocumentNumber.Text.Trim();
                entity.LastName = txtLastName.Text.Trim();
                entity.Names = txtNames.Text.Trim();

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
            _managerApplication = new ManagerApplication();

            flag = false;
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


            _managerApplication.Delete(SetFormData());
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _managerApplication = new ManagerApplication();

            var result = flag
                ? _managerApplication.Insert(SetFormData())
                : _managerApplication.Update(SetFormData());

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
