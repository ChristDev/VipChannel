using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Principal;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Maintenance.Service
{
    public partial class FrmService : Form
    {
        private int _operation;
        private Guid _id;
        private string _userSession;

        private Domain.Entity.Service _serviceEntity;
        private ServiceApplication _serviceApplication;

        private string _userRecordCreation;
        private DateTime _recordCreationDate;

        private string _userActive = FrmMenu.IdUserActive;

        public FrmService(int operation, Guid id)
        {
            InitializeComponent();
            _operation = operation;
            _id = id;
        }

        private void CargarEntidad(Domain.Entity.Service entity)
        {
            txtInternalCode.Text = entity.InternalCode;
            txtDescription.Text = entity.Description;
            txtCost.Text = entity.Cost.ToString();
            _userRecordCreation = entity.UserRecordCreation;
            _recordCreationDate = entity.RecordCreationDate;
        }


        private Domain.Entity.Service AsignarDatos()
        {
            _serviceEntity = new Domain.Entity.Service()
            {
                ServiceId = _id,
                InternalCode = txtInternalCode.Text,
                Description = txtDescription.Text,
                Cost = Convert.ToDecimal(txtCost.Text),           
                RecordStatus = ConstantBase.Active
            };

            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _serviceEntity.UserRecordCreation = _userActive;
                _serviceEntity.RecordCreationDate = DateTime.Now;
            }
            else if (_operation == (int)Operation.Update)
            {
                _serviceEntity.UserRecordCreation = _userRecordCreation;
                _serviceEntity.RecordCreationDate = _recordCreationDate;
                _serviceEntity.UserEditRecord = _userActive;
                _serviceEntity.RecordEditDate = DateTime.Now;
            }
            
            return _serviceEntity;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var entity = AsignarDatos();

            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _serviceApplication.Insert(entity);
            }
            else if (_operation == (int)Operation.Update)
            {
                _serviceApplication.Update(entity);
            }

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmService_Load(object sender, EventArgs e)
        {            
            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _serviceApplication = new ServiceApplication();
                lblTituloFormulario.Text = Constants.FormCreateNames.FrmServiceCreate;
                txtInternalCode.ReadOnly = true;
                txtInternalCode.Text = _serviceApplication.GenerarCodigoInterno();
            }
            else if (_operation == (int)Operation.Update)
            {
                lblTituloFormulario.Text = Constants.FormCreateNames.FrmServiceUpdate;
                _serviceApplication = new ServiceApplication();
                var entity = _serviceApplication.SelectSingle(x=>x.ServiceId == _id);
                CargarEntidad(entity);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
