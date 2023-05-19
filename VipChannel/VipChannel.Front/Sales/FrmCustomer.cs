using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Principal;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Sales
{
    public partial class FrmCustomer : Form
    {
        private int _operation;
        private Guid _id;
        private string _userSession;

        private Customer _customerEntity;
        private CustomerApplication _customerApplication;

        private MasterTableApplication _masterTableApplication;

        private string _userRecordCreation;
        private DateTime _recordCreationDate;

        private string _personType;

        private string _userActive = FrmMenu.IdUserActive;

        public FrmCustomer(int operation, Guid id)
        {
            InitializeComponent();
            _operation = operation;
            _id = id;
            _personType = ConstantPersonType.Natural;
        }

        private void CargarEntidad(Customer entity)
        {
            cboDocumentType.SelectedValue = entity.DocumentType;
            txtDocumentNumber.Text = entity.DocumentNumber;
            txtLastName.Text = entity.LastName;
            txtNames.Text = entity.Names;
            dtpBirthDate.Value = entity.BirthDate.GetValueOrDefault();
            txtEmail.Text = entity.Email;
            txtCellPhone.Text = entity.CellPhone;
            txtOptionalCellPhone.Text = entity.OptionalCellPhone;

            _userRecordCreation = entity.UserRecordCreation;
            _recordCreationDate = entity.RecordCreationDate;
        }


        private Customer AsignarDatos()
        {
            _customerEntity = new Customer()
            {
                CustomerId = _id,
                PersonType = _personType,
                DocumentType = cboDocumentType.SelectedValue.ToString(),
                DocumentNumber = txtDocumentNumber.Text,
                LastName = txtLastName.Text,
                Names = txtNames.Text,
                BusinessName = string.Empty,
                BirthDate = dtpBirthDate.Value,
                Email = txtEmail.Text,
                CellPhone = txtCellPhone.Text,
                OptionalCellPhone = txtOptionalCellPhone.Text,
                RecordStatus = ConstantBase.Active
            };

            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _customerEntity.UserRecordCreation = _userActive;
                _customerEntity.RecordCreationDate = DateTime.Now;


            }
            else if (_operation == (int)Operation.Update)
            {
                _customerEntity.UserRecordCreation = _userRecordCreation;
                _customerEntity.RecordCreationDate = _recordCreationDate;
                _customerEntity.UserEditRecord = _userActive;
                _customerEntity.RecordEditDate = DateTime.Now;
            }
            
            return _customerEntity;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var entity = AsignarDatos();

            if (_operation == Convert.ToInt32(Operation.Create))
            {
                entity.CustomerStatus = ConstantCustomerType.Postulante;
                _customerApplication.Insert(entity);
            }
            else if (_operation == (int)Operation.Update)
            {
                var update = _customerApplication.SelectSingle(x => x.CustomerId == entity.CustomerId);
                entity.CustomerStatus = update.CustomerStatus;
                _customerApplication.Update(entity);
            }

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CargarCombos()
        {
            var masterTableApplication = new MasterTableApplication();
            cboDocumentType.DataSource = masterTableApplication
                .SelectList(x => x.IdMasterTableParent == ConstantMasterTable.MasterTable.TypeDocument
                && x.IdMasterTable != ConstantTypeDocument.Ruc);

            cboDocumentType.DisplayMember = "Name";
            cboDocumentType.ValueMember = "IdMasterTable";
        }

        private void FrmPlanCable_Load(object sender, EventArgs e)
        {
            CargarCombos();
            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _customerApplication = new CustomerApplication();
                lblTituloFormulario.Text = Constants.FormCreateNames.FrmCustomerCreate;
            }
            else if (_operation == (int)Operation.Update)
            {
                lblTituloFormulario.Text = Constants.FormCreateNames.FrmCustomerUpdate;
                _customerApplication = new CustomerApplication();
                var entity = _customerApplication.SelectSingle(x=>x.CustomerId == _id);
                CargarEntidad(entity);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
