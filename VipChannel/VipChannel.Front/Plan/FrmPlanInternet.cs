using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Plan
{
    public partial class FrmPlanInternet : Form
    {
        private int _operation;
        private Guid _id;
        private string _userSession;

        private Domain.Entity.Plan _planEntity;
        private PlanApplication _planApplication;

        private MasterTableApplication _masterTableApplication;

        private string _userRecordCreation;
        private DateTime _recordCreationDate;
        private string _planType;

        public FrmPlanInternet(int operation, Guid id)
        {
            InitializeComponent();
            _operation = operation;
            _id = id;
            _planType = ConstantPlanType.Internet;
        }


        private void CargarCombos()
        {
            var internetSpeedType = ConstantMasterTable.MasterTable.InternetSpeedType;

            _masterTableApplication = new MasterTableApplication();
            cboDownloadInternetSpeedType.DataSource = _masterTableApplication.SelectList(x => x.IdMasterTableParent == internetSpeedType);
            cboDownloadInternetSpeedType.DisplayMember = "Name";
            cboDownloadInternetSpeedType.ValueMember = "IdMasterTable";

            cboUploadInternetSpeedType.DataSource = _masterTableApplication.SelectList(x => x.IdMasterTableParent == internetSpeedType);
            cboUploadInternetSpeedType.DisplayMember = "Name";
            cboUploadInternetSpeedType.ValueMember = "IdMasterTable";
        }

        private void CargarEntidad(Domain.Entity.Plan entity)
        {
            txtInternalCode.Text = entity.InternalCode;
            txtDescription.Text = entity.Description;
            txtCost.Text = entity.Cost.ToString();
            txtInternetUpload.Text = entity.InternetUpload.ToString();
            cboUploadInternetSpeedType.SelectedValue = entity.UploadInternetSpeedType;
            txtInternetDownload.Text = entity.InternetDownload.ToString();
            cboDownloadInternetSpeedType.SelectedValue = entity.DownloadInternetSpeedType;
            _userRecordCreation = entity.UserRecordCreation;
            _recordCreationDate = entity.RecordCreationDate;
        }


        private Domain.Entity.Plan AsignarDatos()
        {
            _planEntity = new Domain.Entity.Plan()
            {
                PlanId = _id,
                PlanType = _planType,
                InternalCode = txtInternalCode.Text,
                Description = txtDescription.Text,
                Cost = Convert.ToDecimal(txtCost.Text),
                InternetUpload = Convert.ToDecimal(txtInternetUpload.Text),
                UploadInternetSpeedType = cboUploadInternetSpeedType.SelectedValue.ToString(),
                InternetDownload = Convert.ToDecimal(txtInternetDownload.Text),
                DownloadInternetSpeedType = cboDownloadInternetSpeedType.SelectedValue.ToString(),                
                RecordStatus = ConstantBase.Active
            };

            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _planEntity.UserRecordCreation = "LOAD";
                _planEntity.RecordCreationDate = DateTime.Now;
            }
            else if (_operation == (int)Operation.Update)
            {
                _planEntity.UserRecordCreation = _userRecordCreation;
                _planEntity.RecordCreationDate = _recordCreationDate;
                _planEntity.UserEditRecord = "LOAD";
                _planEntity.RecordEditDate = DateTime.Now;
            }
            
            return _planEntity;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var entity = AsignarDatos();

            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _planApplication.Insert(entity);
            }
            else if (_operation == (int)Operation.Update)
            {
                _planApplication.Update(entity);
            }

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmPlanInternet_Load(object sender, EventArgs e)
        {
            CargarCombos();
            
            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _planApplication = new PlanApplication();
                lblTituloFormulario.Text = Constants.FormCreateNames.FrmPlanInternetCreate;
                txtInternalCode.ReadOnly = true;
                txtInternalCode.Text = _planApplication.GenerarCodigoInterno();
            }
            else if (_operation == (int)Operation.Update)
            {
                lblTituloFormulario.Text = Constants.FormCreateNames.FrmPlanInternetUpdate;
                _planApplication = new PlanApplication();
                var entity = _planApplication.SelectSingle(x=>x.PlanId == _id);
                CargarEntidad(entity);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
