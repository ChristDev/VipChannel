using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Sales
{
    public partial class FrmCustomerScheduling : Form
    {
        private int _operation;
        private Guid _id;
        private string _userSession;

        private Customer _customerEntity;
        private CustomerApplication _customerApplication;


        private ZoneApplication _zoneApplication;
        private AvenueApplication _avenueApplication;

        private PlanesView _planesView;
        private List<vPlanesVenta> _dtPlanes = new List<vPlanesVenta>();

        private ServiceApplication _serviceApplication;
        private List<Service> _dtServices = new List<Service>();


        private string _userRecordCreation;
        private DateTime _recordCreationDate;

        private string _personType;
        public FrmCustomerScheduling()
            //(int operation, Guid id)
        {
            InitializeComponent();
            //_operation = operation;
            //_id = id;
            _personType = ConstantPersonType.Natural;
        }

        private void CargarEntidad(Customer entity)
        {
            cboZoneId.SelectedValue = entity.DocumentType;
            txtReference.Text = entity.DocumentNumber;
            //txtLastName.Text = entity.LastName;
            //txtNames.Text = entity.Names;
            //dtpBirthDate.Value = entity.BirthDate.GetValueOrDefault();
            //txtEmail.Text = entity.Email;
            //txtCellPhone.Text = entity.CellPhone;
            //txtOptionalCellPhone.Text = entity.OptionalCellPhone;
            //txtEmail.Text = entity.Email;

            _userRecordCreation = entity.UserRecordCreation;
            _recordCreationDate = entity.RecordCreationDate;
        }


        private Customer AsignarDatos()
        {
            _customerEntity = new Customer()
            {
                CustomerId = _id,
                PersonType = _personType,
                DocumentType = cboZoneId.SelectedValue.ToString(),
                DocumentNumber = txtReference.Text,
                //LastName = txtLastName.Text,
                //Names = txtNames.Text,
                //BusinessName = string.Empty,
                //BirthDate = dtpBirthDate.Value,
                //Email = txtEmail.Text,
                //CellPhone = txtCellPhone.Text,
                //OptionalCellPhone = txtOptionalCellPhone.Text,
                RecordStatus = ConstantBase.Active
            };

            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _customerEntity.UserRecordCreation = "LOAD";
                _customerEntity.RecordCreationDate = DateTime.Now;
            }
            else if (_operation == (int)Operation.Update)
            {
                _customerEntity.UserRecordCreation = _userRecordCreation;
                _customerEntity.RecordCreationDate = _recordCreationDate;
                _customerEntity.UserEditRecord = "LOAD";
                _customerEntity.RecordEditDate = DateTime.Now;
            }
            
            return _customerEntity;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var entity = AsignarDatos();

            if (_operation == Convert.ToInt32(Operation.Create))
            {
                _customerApplication.Insert(entity);
            }
            else if (_operation == (int)Operation.Update)
            {
                _customerApplication.Update(entity);
            }

            MessageBox.Show("Se guardo correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CargarCombos()
        {
            _zoneApplication = new ZoneApplication();
            zoneBindingSource.DataSource = _zoneApplication.SelectList(x=> x.RecordStatus == ConstantBase.Active);

            var dtCargarEstadoDeServicio =  CargarEstadoDeServicio();
            cboServiceStatus.DataSource = dtCargarEstadoDeServicio;
            cboServiceStatus.DisplayMember = "Descripcion";
            cboServiceStatus.ValueMember = "Id";

            var dtCargarDiaDePago = CargarDiaDePago();
            cboPayDay.DataSource = dtCargarDiaDePago;
            cboPayDay.DisplayMember = "Descripcion";
            cboPayDay.ValueMember = "Id";

            var dtCargarCrearFactura = CargarCrearFactura();
            cboCreateInvoices.DataSource = dtCargarCrearFactura;
            cboCreateInvoices.DisplayMember = "Descripcion";
            cboCreateInvoices.ValueMember = "Id";

            var dtCargarDiasDeGracia = CargarDiasDeGracia();
            cboDaysOfGrace.DataSource = dtCargarDiasDeGracia;
            cboDaysOfGrace.DisplayMember = "Descripcion";
            cboDaysOfGrace.ValueMember = "Id";

            var dtCargarMesesDeDescuento = CargarMesesDeDescuento();
            cboDiscountMonths.DataSource = dtCargarMesesDeDescuento;
            cboDiscountMonths.DisplayMember = "Descripcion";
            cboDiscountMonths.ValueMember = "Id";


            _planesView = new PlanesView();
            _dtPlanes = _planesView.SelectListView();
            cboPlanes.DataSource = _dtPlanes;
            cboPlanes.DisplayMember = "Descripcion";
            cboPlanes.ValueMember = "PlanId";

            _serviceApplication = new ServiceApplication();
            _dtServices = _serviceApplication.SelectList(x => x.RecordStatus == ConstantBase.Active);
            cboServicios.DataSource = _dtServices;
            cboServicios.DisplayMember = "Description";
            cboServicios.ValueMember = "ServiceId";
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

        private void cboDocumentType_SelectedIndexChanged(object sender, EventArgs e)
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
            }
        }
    }
}
