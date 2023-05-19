using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VipChannel.Enums.MasterTables.ConstantOperation;
using VipChannel.Enums.MasterTables;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;
using VipChannel.Application.View;
using VipChannel.Front.Principal;

namespace VipChannel.Front.Requests.Serve
{
    public partial class FrmTechnicalServe : Form
    {
        private InstallationRequestPlanApplication _installationRequestPlanApplication;

        private InstallationRequestCostApplication _installationRequestCostApplication;

        private ServiciosVentaView _servicesView;
        private List<vServiciosVenta> _dtServices = new List<vServiciosVenta>();

        private InstallationRequestAttended _installationRequestAttended;
        private InstallationRequestAttendedApplication _installationRequestAttendedApplication;

        private int _operation;
        private Guid _customerId;
        private Guid _customerAddressId;
        private CustomerAddressApplication _customerAddressApplication;


        private Guid _installationRequestId;

        private string _userActive = FrmMenu.IdUserActive;

        public FrmTechnicalServe(int operation, Guid customerId, Guid customerAddressId, Guid installationRequestId)
        {
            InitializeComponent();
            _operation = operation;
            _customerId = customerId;
            _customerAddressId = customerAddressId;
            _installationRequestId = installationRequestId;
        }
        
        private void CargarCombos()
        {
            _servicesView = new ServiciosVentaView();
            _dtServices = _servicesView.SelectListView();
            vServiciosVentaBindingSource.DataSource = _dtServices;
            cboServicios.SelectedIndex = -1;

            cboEquipment.DataSource = CargarEstadoDeServicio();
            cboEquipment.DisplayMember = "Descripcion";
            cboEquipment.ValueMember = "Id";
            cboEquipment.SelectedIndex = -1;

            var masterTableApplication = new MasterTableApplication();
            cboRequestStatus.DataSource = masterTableApplication.SelectList(x=>x.IdMasterTableParent == ConstantMasterTable.MasterTable.RequestStatus);
            cboRequestStatus.DisplayMember = "Name";
            cboRequestStatus.ValueMember = "IdMasterTable";
            cboRequestStatus.SelectedIndex = -1;

            var technicalApplication = new TecnicoView();
            vTecnicoBindingSource.DataSource = technicalApplication.SelectListView();
            cboTechnicalAttendedId.DisplayMember = "EmployeeName";
            cboTechnicalAttendedId.ValueMember = "TechnicalId";
            cboTechnicalAttendedId.SelectedIndex = -1;
        }

        private DataTable CargarEstadoDeServicio()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            dt.Rows.Add("ONU", "ONU");
            dt.Rows.Add("MININODO", "MININODO");
            dt.Rows.Add("REPETIDOR", "REPETIDOR");
            return dt;
        }

        private void CargarDatosPreRegistrados()
        {
            _installationRequestPlanApplication = new InstallationRequestPlanApplication();
            installationRequestPlanBindingSource.DataSource = _installationRequestPlanApplication.SelectList(x=>x.InstallationRequestId == _installationRequestId);

            _installationRequestCostApplication = new InstallationRequestCostApplication();
            installationRequestCostBindingSource.DataSource = _installationRequestCostApplication.SelectList(x => x.InstallationRequestId == _installationRequestId);
        }

        private void CargarCliente(Guid customerId)
        {
            var customerApplication = new CustomerApplication();
            var customer = customerApplication.SelectSingle(x=>x.CustomerId == customerId);

            var masterTableApplication = new MasterTableApplication();
            var masterTable = masterTableApplication.SelectSingle(x => x.IdMasterTable == customer.DocumentType);

            txtDocumentType.Text = masterTable.Name;
            txtDocumentNumber.Text = customer.DocumentNumber;
            txtLastName.Text = customer.LastName;
            txtNames.Text = customer.Names;
            txtBusinessName.Text = customer.BusinessName;
            txtCellPhone.Text = customer.CellPhone;
            txtOptionalCellPhone.Text = customer.OptionalCellPhone;
        }

        private void CargarClienteDireccion(Guid customerAddressId)
        {
            var customerAddressApplication = new CustomerAddressApplication();
            var customerAddress = customerAddressApplication.SelectSingle(x => x.CustomerAddressId == customerAddressId);

            var zoneApplication = new ZoneApplication();
            var zone = zoneApplication.SelectSingle(x => x.ZoneId == customerAddress.ZoneId);            

            var avenueApplication = new AvenueApplication();
            var avenue = avenueApplication.SelectSingle(x => x.AvenueId == customerAddress.AvenueId);

            txtZoneName.Text = zone.Description;
            txtAvenueName.Text = avenue.Description;
            txtAdressDetail.Text = customerAddress.AdressDetail;
            txtNumber.Text = customerAddress.Number;
            txtReference.Text = customerAddress.Reference;  
            txtLatitude.Text = customerAddress.Latitude;
            txtLongitude.Text = customerAddress.Longitude;
        }


        private void FrmTechnicalServe_Load(object sender, EventArgs e)
        {
            CargarCliente(_customerId);
            CargarClienteDireccion(_customerAddressId);

            CargarCombos();
            CargarDatosPreRegistrados();
            this.dgvDatosServicio.Columns[0].Visible = false;
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            var customerAddressApplication = new CustomerAddressApplication();
            var latitude = txtLatitude.Text;
            var longitude = txtLongitude.Text;

            customerAddressApplication.ActualizarCoordenadasCliente(_customerAddressId, latitude, longitude);
            MessageBox.Show("Se actualizó correctamente las coordenadas del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboServicios.SelectedValue != null)
                {
                    var idSelected = Guid.Parse(cboServicios.SelectedValue.ToString());
                    var selected = _dtServices.FirstOrDefault(x => x.ServiceId == idSelected);
                    txtServicio.Text = selected.Description;
                    txtMontoServicio.Text = selected.Cost.ToString();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private InstallationRequestAttended SetForm()
        {
            _installationRequestAttended = new InstallationRequestAttended()
            {
                InstallationRequestAttendedId = Guid.NewGuid(),
                InstallationRequestId = _installationRequestId,
                DateAttended = dtpDateAttended.Value,
                HourAttended = tmpHourAttended.Text,
                TechnicalAttendedId = Guid.Parse(cboTechnicalAttendedId.SelectedValue.ToString()),
                RequestStatus = cboRequestStatus.SelectedValue.ToString(),
                Comment = txtComment.Text,
                Equipment = cboEquipment.SelectedValue == null ? "" : cboEquipment.SelectedValue.ToString(),
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                Serie = txtSerie.Text,
                OltPower = txtOltPower.Text,
                CatvPower = txtCatvPower.Text,
                Nap = txtNap.Text,
                Thread = txtThread.Text,
                Route = txtRoute.Text,
                Trunk = txtTrunk.Text,
                Sector = txtSector.Text,
                District = txtDistrict.Text,
                Latitude = txtLatitude.Text,
                Longitude = txtLongitude.Text,
                TerminalCapacityFirst = txtTerminalCapacityFirst.Text,
                TerminalCapacitySecond = txtTerminalCapacitySecond.Text,                
                UserRecordCreation = _userActive,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };
            return _installationRequestAttended;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var entity = SetForm();

            _installationRequestAttendedApplication = new InstallationRequestAttendedApplication();
            _installationRequestAttendedApplication.Insert(entity);

            var customerAddressApplication = new CustomerAddressApplication();
            if(entity.RequestStatus == ConstantRequestStatus.Completado)
            {
                customerAddressApplication.ActualizarEstadoClienteDireccionActivo(
                    _customerAddressId,
                    ConstantCustomerAddressStatus.Activo);

            }
            else
            {
                customerAddressApplication.ActualizarEstadoClienteDireccionRechazado(
                    _customerAddressId,
                    ConstantCustomerAddressStatus.Rechazado);
            }

            MessageBox.Show("Se registró correctamente la atención de la solicitud", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
