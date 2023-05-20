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
    public partial class FrmEmployeeSalesBox : Form
    {
        private SucursalApplication _sucursalApplication;
        private SaleBoxApplication _saleBoxApplication;


        private string _userActive = FrmMenu.IdUserActive;
        private string _employee { get; set; }
        private string _employeeId { get; set; }

        private Assignment _assignmentEntity;
        private AssignmentApplication _assignmentApplication;
        private Guid _assignmentId;


        public FrmEmployeeSalesBox(string employeeId, string employee)
        {
            InitializeComponent();
            _employee = employee;
            _employeeId = employeeId;
            LoadData();
        }

        private void LoadData()
        {
            txtEmployee.Text = _employee;
            CargarCombos();

            _assignmentApplication = new AssignmentApplication();
            var id = Guid.Parse(_employeeId);
            var assignment = _assignmentApplication.SelectList(x => x.EmployeeId == id).FirstOrDefault();
            if(assignment != null)
            {
                cboSucursalId.SelectedValue = assignment.SucursalId;
                cboSaleBoxId.SelectedValue = assignment.SaleBoxId;
                _assignmentId = assignment.AssignmentsId;
            }
        }

        public void CargarCombos()
        {
            _sucursalApplication = new SucursalApplication();
            sucursalBindingSource.DataSource = _sucursalApplication.SelectList(x=>x.RecordStatus == ConstantBase.Active);
            cboSucursalId.SelectedIndex = -1;
        }

  
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_assignmentId == null)
            {
                _assignmentEntity = new Assignment()
                {
                    AssignmentsId = Guid.NewGuid(),
                    EmployeeId = Guid.Parse(_employeeId),
                    SucursalId = Guid.Parse(cboSucursalId.SelectedValue.ToString()),
                    SaleBoxId = Guid.Parse(cboSaleBoxId.SelectedValue.ToString()),
                    UserRecordCreation = _userActive,
                    RecordCreationDate = DateTime.Now,
                    RecordStatus = ConstantBase.Active,
                };

                _assignmentApplication = new AssignmentApplication();
                _assignmentApplication.Insert(_assignmentEntity);
            }
            else
            {
                _assignmentEntity = new Assignment()
                {
                    AssignmentsId = _assignmentId,
                    EmployeeId = Guid.Parse(_employeeId),
                    SucursalId = Guid.Parse(cboSucursalId.SelectedValue.ToString()),
                    SaleBoxId = Guid.Parse(cboSaleBoxId.SelectedValue.ToString()),
                    UserRecordCreation = _userActive,
                    RecordCreationDate = DateTime.Now,
                    RecordStatus = ConstantBase.Active,
                };

                _assignmentApplication = new AssignmentApplication();
                _assignmentApplication.Update(_assignmentEntity);

            }

            MessageBox.Show("Se asigno correctamente la caja al empleado", "Asignación de caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSucursalId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboSucursalId.SelectedValue == null)
                {
                    return;
                }

                var idSelected = Guid.Parse(cboSucursalId.SelectedValue.ToString());
                _saleBoxApplication = new SaleBoxApplication();
                saleBoxBindingSource.DataSource = _saleBoxApplication
                    .SelectList(x => x.RecordStatus == ConstantBase.Active && x.SucursalId == idSelected);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
