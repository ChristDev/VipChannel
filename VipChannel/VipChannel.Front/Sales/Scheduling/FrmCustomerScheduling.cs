using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Principal;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Sales
{
    public partial class FrmCustomerScheduling : Form
    {
        private int _operation;
        private Guid _id;
        private string _userSession;

        private CustomerAddress _customerAddress;
        private InstallationRequest _installationRequest;

        private InstallationRequestPlan _installationRequestPlan;
        private List<InstallationRequestPlan> _installationRequestPlans = new List<InstallationRequestPlan>();

        private InstallationRequestCost _installationRequestCost;
        private List<InstallationRequestCost> _installationRequestCosts = new List<InstallationRequestCost>();

        private CustomerApplication _customerApplication;
        private CustomerAddressApplication _customerAddressApplication;
        private InstallationRequestApplication _installationRequestApplication;
        private InstallationRequestPlanApplication _installationRequestPlanApplication;
        private InstallationRequestCostApplication _installationRequestCostApplication;

        private ZoneApplication _zoneApplication;
        private AvenueApplication _avenueApplication;

        private PlanesVentaView _planesView;
        private List<vPlanesVenta> _dtPlanes = new List<vPlanesVenta>();

        private ServiciosVentaView _servicesView;
        private List<vServiciosVenta> _dtServices = new List<vServiciosVenta>();

        private TecnicoView _tecnicoView;

        private string _userRecordCreation;
        private DateTime _recordCreationDate;

        private string _personType;

        private string _userActive = FrmMenu.IdUserActive;

        public FrmCustomerScheduling(int operation, Guid id)
        {
            InitializeComponent();
            _operation = operation;
            _id = id;
            _personType = ConstantPersonType.Natural;
        }

        private CustomerAddress AsignarDatos_CustomerAddres()
        {
            var customerAddresId = Guid.NewGuid();
            _customerAddress = new CustomerAddress()
            {                
                CustomerAddressId = customerAddresId,
                CustomerId = _id,
                ZoneId = Guid.Parse(cboZoneId.SelectedValue.ToString()),
                AvenueId = Guid.Parse(cboAvenueId.SelectedValue.ToString()),
                AdressDetail = txtAdressDetail.Text,
                Number = txtNumber.Text,
                Latitude = "",
                Longitude = "",
                Reference = txtReference.Text,
                UserRecordCreation = "LOAD",
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };            
            _customerAddress.InstallationRequests.Add(AsignarDatos_InstallationRequest());

            return _customerAddress;
        }


        private InstallationRequest AsignarDatos_InstallationRequest()
        {
            var installationRequestId = Guid.NewGuid(); ;
            _installationRequest = new InstallationRequest()
            {
                InstallationRequestId = installationRequestId,                
                CustomerAddressId = _customerAddress.CustomerAddressId,
                ServiceStatus = cboServiceStatus.SelectedValue.ToString(),
                EmployeeId = Guid.Parse(_userActive),
                PayDay = int.Parse(cboPayDay.SelectedValue.ToString()),
                CreateInvoices = int.Parse(cboCreateInvoices.SelectedValue.ToString()),
                DaysOfGrace = int.Parse(cboDaysOfGrace.SelectedValue.ToString()),
                ApplyDiscount = chkApplyDiscount.Checked,
                DiscountAmount = cboDiscountMonths.SelectedValue == null ? 0 : decimal.Parse(txtDiscountAmount.Text),
                DiscountMonths = cboDiscountMonths.SelectedValue == null ? 0 : int.Parse(cboDiscountMonths.SelectedValue.ToString()),

                DateAttention = dtpDateAttention.Value,
                HourAttention = tmpHourAttention.Text,
                TechnicalId = Guid.Parse(cboTechnicalId.SelectedValue.ToString()),
                Comment = txtComment.Text,

                UserRecordCreation = _userActive,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };

            var plans = new List<InstallationRequestPlan>();
            foreach (var item in _installationRequestPlans)
            {
                var plan = new InstallationRequestPlan()
                {
                    InstallationRequestPlanId = Guid.NewGuid(),
                    InstallationRequestId = item.InstallationRequestId,
                    PlanId = item.PlanId,
                    PlanName = item.PlanName,
                    PlanCost = item.PlanCost,
                    UserRecordCreation = _userActive,
                    RecordCreationDate = DateTime.Now,
                    RecordStatus = ConstantBase.Active
                };
                plans.Add(plan);
            }

            var services = new List<InstallationRequestCost>();
            foreach (var item in _installationRequestCosts) 
            {
                var service = new InstallationRequestCost()
                {
                    InstallationRequestCostId = Guid.NewGuid(),
                    InstallationRequestId = item.InstallationRequestId,
                    ServiceId = item.ServiceId,
                    ServiceName = item.ServiceName,
                    ServiceCost = item.ServiceCost,
                    UserRecordCreation = _userActive,
                    RecordCreationDate = DateTime.Now,
                    RecordStatus = ConstantBase.Active
                };
                services.Add(service);
            }

            _installationRequest.InstallationRequestPlans = plans;
            _installationRequest.InstallationRequestCosts = services;

            return _installationRequest;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _customerAddressApplication = new CustomerAddressApplication();
            _installationRequestApplication = new InstallationRequestApplication();

            if (_installationRequestPlans.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un plan", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(_installationRequestCosts.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un servicio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                       
            _customerAddressApplication.Insert(AsignarDatos_CustomerAddres());

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarCombos()
        {
            _zoneApplication = new ZoneApplication();
            zoneBindingSource.DataSource = _zoneApplication.SelectList(x=> x.RecordStatus == ConstantBase.Active);

            var dtCargarEstadoDeServicio =  CargarEstadoDeServicio();
            cboServiceStatus.DataSource = dtCargarEstadoDeServicio;
            cboServiceStatus.DisplayMember = "Descripcion";
            cboServiceStatus.ValueMember = "Id";
            cboServiceStatus.SelectedIndex = -1;

            var dtCargarDiaDePago = CargarDiaDePago();
            cboPayDay.DataSource = dtCargarDiaDePago;
            cboPayDay.DisplayMember = "Descripcion";
            cboPayDay.ValueMember = "Id";
            cboPayDay.SelectedIndex = -1;

            var dtCargarCrearFactura = CargarCrearFactura();
            cboCreateInvoices.DataSource = dtCargarCrearFactura;
            cboCreateInvoices.DisplayMember = "Descripcion";
            cboCreateInvoices.ValueMember = "Id";
            cboCreateInvoices.SelectedIndex = -1;

            var dtCargarDiasDeGracia = CargarDiasDeGracia();
            cboDaysOfGrace.DataSource = dtCargarDiasDeGracia;
            cboDaysOfGrace.DisplayMember = "Descripcion";
            cboDaysOfGrace.ValueMember = "Id";
            cboDaysOfGrace.SelectedIndex = -1;

            var dtCargarMesesDeDescuento = CargarMesesDeDescuento();
            cboDiscountMonths.DataSource = dtCargarMesesDeDescuento;
            cboDiscountMonths.DisplayMember = "Descripcion";
            cboDiscountMonths.ValueMember = "Id";
            cboDiscountMonths.SelectedIndex = -1;


            _planesView = new PlanesVentaView();
            _dtPlanes = _planesView.SelectListView();
            vPlanesVentaBindingSource.DataSource = _dtPlanes;
            cboPlanes.SelectedIndex = -1;


            _servicesView = new ServiciosVentaView();
            _dtServices = _servicesView.SelectListView();
            vServiciosVentaBindingSource.DataSource = _dtServices;
            cboServicios.SelectedIndex = -1;

            _tecnicoView = new TecnicoView();
            vTecnicoBindingSource.DataSource = _tecnicoView.SelectListView();
            cboTechnicalId.SelectedIndex = -1;

            var dtCargarMeses = CargarMeses();
            cboMesesContrato.DataSource = dtCargarMeses;
            cboMesesContrato.DisplayMember = "Descripcion";
            cboMesesContrato.ValueMember = "Id";
            cboMesesContrato.SelectedIndex = -1;
        }

        private DataTable CargarEstadoDeServicio()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            dt.Rows.Add("GRATUITO", "GRATUITO");
            dt.Rows.Add("FACTURADO", "FACTURADO");
            return dt;
        }

        private DataTable CargarDiaDePago()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            for (int i = 1; i <= 28; i++)
            {
                dt.Rows.Add(i.ToString(), i.ToString());

            }
            return dt;
        }

        private DataTable CargarCrearFactura()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            for (int i = 0; i <= 26; i++)
            {
                if(i == 0)
                {
                    dt.Rows.Add(i.ToString(), "Desactivado");

                }
                else if (i == 1)
                {
                    dt.Rows.Add(i.ToString(), i.ToString() + " Día");
                }
                else
                {
                    dt.Rows.Add(i.ToString(), i.ToString() + " Dias");
                }
            }
            return dt;
        }

        private DataTable CargarDiasDeGracia()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            for (int i = 0; i <= 25; i++)
            {
                if (i == 0)
                {
                    dt.Rows.Add(i.ToString(), i.ToString() + " Días");

                }
                else if (i == 1)
                {
                    dt.Rows.Add(i.ToString(), i.ToString() + " Día");
                }
                else
                {
                    dt.Rows.Add(i.ToString(), i.ToString() + " Dias");
                }
            }
            return dt;
        }

        private DataTable CargarMesesDeDescuento()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            for (int i = 0; i <= 12; i++)
            {
                if (i == 0)
                {
                    dt.Rows.Add(i.ToString(), i.ToString() + " Meses");

                }
                else if (i == 1)
                {
                    dt.Rows.Add(i.ToString(), i.ToString() + " Mes");
                }
                else
                {
                    dt.Rows.Add(i.ToString(), i.ToString() + " Meses");
                }
            }
            return dt;
        }

        private DataTable CargarMeses()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Descripcion", typeof(string));

            for (int i = 6; i <= 12; i++)
            {
                dt.Rows.Add(i.ToString(), i.ToString() + " Meses");               
            }
            return dt;
        }

        private void FrmPlanCable_Load(object sender, EventArgs e)
        {
            CargarCombos();
            if (_operation == Convert.ToInt32(Operation.Create))
            {
                lblTituloFormulario.Text = Constants.FormCreateNames.FrmCustomerCreate;
            }
            else if (_operation == (int)Operation.Update)
            {
                lblTituloFormulario.Text = Constants.FormCreateNames.FrmCustomerUpdate;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close();
        }


        private void chkApplyDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApplyDiscount.Checked)
            {
                fLabelMedium11.Visible = true;
                txtDiscountAmount.Visible = true;

                fLabelMedium12.Visible = true;
                cboDiscountMonths.Visible = true;                
            }
            else
            {
                fLabelMedium11.Visible = false;
                txtDiscountAmount.Visible = false;

                fLabelMedium12.Visible = false;
                cboDiscountMonths.Visible = false;

                txtDiscountAmount.Text = string.Empty;
                cboDiscountMonths.SelectedIndex = -1;
            }
        }

        private void cboZoneId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var idSelected = Guid.Parse(cboZoneId.SelectedValue.ToString());
                _avenueApplication = new AvenueApplication();
                avenueBindingSource.DataSource = _avenueApplication
                    .SelectList(x => x.RecordStatus == ConstantBase.Active && x.ZoneId == idSelected);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if(cboPlanes.SelectedValue != null)
                {
                    var idSelected = Guid.Parse(cboPlanes.SelectedValue.ToString());
                    var selected = _dtPlanes.FirstOrDefault(x => x.PlanId == idSelected);
                    txtPlanPaquete.Text = selected.Descripcion;
                    txtMontoPlanPaquete.Text = selected.Cost.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
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

        private void LimpiarPlanPaquete()
        {
            cboPlanes.SelectedIndex = -1;
            txtPlanPaquete.Text = string.Empty;
            txtMontoPlanPaquete.Text = string.Empty;
        }

        private void btnAgregarPlanPaquete_Click(object sender, EventArgs e)
        {
            if(cboPlanes.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un plan", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var planId = Guid.Parse(cboPlanes.SelectedValue.ToString());
            var planName = txtPlanPaquete.Text;
            var planCost = Convert.ToDecimal(txtMontoPlanPaquete.Text);
            
            var plan = new InstallationRequestPlan
            {
                PlanId = planId,
                PlanName = planName,
                PlanCost = planCost
            };           

            if (_installationRequestPlans.Count(x => x.PlanId == planId) != 0)
            {
                MessageBox.Show("El plan ya se encuentra agregado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarPlanPaquete();
                return;
            }

            _installationRequestPlans.Add(plan);
            LimpiarPlanPaquete();

            if (installationRequestPlanBindingSource.Count == 0)
            {
                installationRequestPlanBindingSource.DataSource = _installationRequestPlans;
            }
            else
            {
                installationRequestPlanBindingSource.DataSource = null;
                installationRequestPlanBindingSource.DataSource = _installationRequestPlans;
            }
        }

        private void btnQuitarPlanPaquete_Click(object sender, EventArgs e)
        {
            if(dgvDatosPlanPaquete.CurrentRow == null)
            {
                MessageBox.Show("No existen registros a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = Guid.Parse(dgvDatosPlanPaquete.CurrentRow.Cells[0].Value.ToString());
            var selected = _installationRequestPlans.FirstOrDefault(x => x.PlanId == id);

            _installationRequestPlans.Remove(selected);
            installationRequestPlanBindingSource.DataSource = null;
            installationRequestPlanBindingSource.DataSource = _installationRequestPlans;
        }

        private void LimpiarServicio()
        {
            cboServicios.SelectedIndex = -1;
            txtServicio.Text = string.Empty;
            txtMontoServicio.Text = string.Empty;
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (cboServicios.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un servicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var servicioId = Guid.Parse(cboServicios.SelectedValue.ToString());
            var serviceName = txtServicio.Text;
            var serviceCost = Convert.ToDecimal(txtMontoServicio.Text);

            var servicio = new InstallationRequestCost
            {
                ServiceId = servicioId,
                ServiceName = serviceName,
                ServiceCost = serviceCost
            };            

            if (_installationRequestCosts.Count(x => x.ServiceId == servicioId) != 0)
            {
                MessageBox.Show("El servicio ya se encuentra agregado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarServicio();
                return;
            }

            _installationRequestCosts.Add(servicio);
            LimpiarServicio();

            if (installationRequestCostBindingSource.Count == 0)
            {
                installationRequestCostBindingSource.DataSource = _installationRequestCosts;
            }
            else
            {
                installationRequestCostBindingSource.DataSource = null;
                installationRequestCostBindingSource.DataSource = _installationRequestCosts;
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (dgvDatosServicio.CurrentRow == null)
            {
                MessageBox.Show("No existen registros a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = Guid.Parse(dgvDatosServicio.CurrentRow.Cells[0].Value.ToString());
            var selected = _installationRequestCosts.FirstOrDefault(x => x.ServiceId == id);

            _installationRequestCosts.Remove(selected);
            installationRequestCostBindingSource.DataSource = null;
            installationRequestCostBindingSource.DataSource = _installationRequestCosts;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
