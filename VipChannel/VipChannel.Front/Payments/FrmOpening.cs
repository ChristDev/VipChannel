using System;
using System.Configuration;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Principal;

namespace VipChannel.Front.Payments
{
    public partial class FrmOpening : Form
    {
        private string _userActiveId = FrmMenu.IdUserActive;
        private string _saleBoxId = FrmMenu.SaleBoxId;

        private DailyBox _dailyBoxEntity;
        private DailyBoxApplication _dailyBoxApplication;

        public FrmOpening()
        {
            InitializeComponent();
            PreCarga();
        }


        private void PreCarga()
        {       
            var saleBoxApplication = new Application.Entity.SaleBoxApplication();
            var id = Guid.Parse(_saleBoxId);
            var saleBox = saleBoxApplication.SelectSingle(q => q.SaleBoxId == id);

            lblCaja.Text = saleBox.Name;
        }

        #region Abrir formulario solo una vez
        private static FrmOpening _mFormDefInstance;
        public static FrmOpening DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmOpening();
                return _mFormDefInstance;
            }
            set
            {
                _mFormDefInstance = value;
            }
        }
        #endregion



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _dailyBoxEntity = new DailyBox()
            {
                DailyBoxId = Guid.NewGuid(),
                EmployeeId = Guid.Parse(_userActiveId),
                SaleBoxId = Guid.Parse(_saleBoxId),
                OpeningDate = dtpFechaApertura.Value,
                OpeningAmount = decimal.Parse(txtMontoApertura.Text),
                ClosingDate = null,
                ClosingAmount = null,
                UserRecordCreation = _userActiveId,
                RecordCreationDate = DateTime.Now,
                RecordStatus = ConstantBase.Active
            };

            _dailyBoxApplication = new DailyBoxApplication();
            _dailyBoxApplication.Insert(_dailyBoxEntity);

            MessageBox.Show("Apertura de caja realizada correctamente", "Apertura de caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
