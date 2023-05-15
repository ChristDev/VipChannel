using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Plan;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Definitions
{
    public partial class FrmGeneral : Form
    {
        private CompanyApplication _companyApplication;
        private Company _companyEntity;

        private Guid _id;
        private int _operation;

        private string _userRecordCreation;
        private DateTime _recordCreationDate;
        public FrmGeneral()
        {
            InitializeComponent();
        }


        #region Abrir formulario solo una vez
        private static FrmGeneral _mFormDefInstance;
        public static FrmGeneral DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmGeneral();
                return _mFormDefInstance;
            }
            set
            {
                _mFormDefInstance = value;
            }
        }
        #endregion

        private void FrmGeneral_Load(object sender, EventArgs e)
        {
            var company = ObtenerConfiguracion();
            AsignarDatos(company);
        }

        private Company ObtenerConfiguracion()
        {
            _companyApplication = new CompanyApplication();

            var company = _companyApplication.SelectList(x=>x.RecordStatus == ConstantBase.Active);
            if(company.Count == 0)
            {
                _id = Guid.NewGuid();
                _operation = Convert.ToInt32(Operation.Create);
                return null;
            }
            else
            {
                _operation = Convert.ToInt32(Operation.Update);
                _userRecordCreation = company.FirstOrDefault().UserRecordCreation;
                _recordCreationDate = company.FirstOrDefault().RecordCreationDate;
                return company.FirstOrDefault();
            }
        }

        private Company SetFormData()
        {
            _companyEntity = new Company()
            {
                CompanyId = _id,
                BusinessName = txtBusinessName.Text,
                TradeName = txtTradeName.Text,
                NumberDocument = txtNumberDocument.Text,
                CellPhone = txtCellPhone.Text,
                OptionalCellPhone = txtOptionalCellPhone.Text,
                Address = txtAddress.Text,
                Department = txtDepartment.Text,
                Province = txtProvince.Text,
                District = txtDistrict.Text,

                Slogan = txtSlogan.Text,
                ProofFooter = txtProofFooter.Text,
                GoogleMapsApi = txtGoogleMapsApi.Text,
                ReniecApi = txtReniecApi.Text,
                EmailMailShipping = txtEmailMailShipping.Text,
                PasswordMailShipping = txtPasswordMailShipping.Text,
                HostMailShipping = txtHostMailShipping.Text,
                PortMailShipping = txtPortMailShipping.Text,
                RecordStatus = ConstantBase.Active
            };


            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _companyEntity.UserRecordCreation = "LOAD";
                _companyEntity.RecordCreationDate = DateTime.Now;
            }
            else if (_operation == (int)Operation.Update)
            {
                _companyEntity.UserRecordCreation = _userRecordCreation;
                _companyEntity.RecordCreationDate = _recordCreationDate;
                _companyEntity.UserEditRecord = "LOAD";
                _companyEntity.RecordEditDate = DateTime.Now;
            }

            return _companyEntity;
        }

        private void AsignarDatos(Company entity)
        {
            if(entity == null) return; 
            _id = entity.CompanyId;
            txtBusinessName.Text = entity.BusinessName;
            txtTradeName.Text = entity.TradeName;
            txtNumberDocument.Text = entity.NumberDocument;
            txtCellPhone.Text = entity.CellPhone;
            txtOptionalCellPhone.Text = entity.OptionalCellPhone;
            txtAddress.Text = entity.Address;
            txtDepartment.Text = entity.Department;
            txtProvince.Text = entity.Province;
            txtDistrict.Text = entity.District;

            txtSlogan.Text = entity.Slogan;
            pbxImagenCompany.Image = null;
            txtProofFooter.Text = entity.ProofFooter;

            txtGoogleMapsApi.Text = entity.GoogleMapsApi;
            txtReniecApi.Text = entity.ReniecApi;

            txtEmailMailShipping.Text = entity.EmailMailShipping;
            txtPasswordMailShipping.Text = entity.PasswordMailShipping;
            txtHostMailShipping.Text= entity.HostMailShipping;
            txtPortMailShipping.Text = entity.PortMailShipping.ToString();           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _companyApplication = new CompanyApplication();
            var company = SetFormData();

            if (MessageBox.Show("¿Está seguro que desea guardar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _companyApplication.Insert(company);
            }
            else if (_operation == Convert.ToInt32(Operation.Update))
            {
                _companyApplication.Update(company);
            }

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ObtenerConfiguracion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
