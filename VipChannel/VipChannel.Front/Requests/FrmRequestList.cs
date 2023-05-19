using System;
using System.Linq;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Constants;
using VipChannel.Front.Requests.Serve;
using VipChannel.Front.Sales;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Requests
{
    public partial class FrmRequestList : Form
    {
        private SolicitudesInstalacionView _solicitudesInstalacionView;
        public FrmRequestList()
        {
            InitializeComponent();
            Text = FormListNames.FrmRequestList;
        }

        #region Abrir formulario solo una vez
        private static FrmRequestList _mFormDefInstance;
        public static FrmRequestList DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmRequestList();
                return _mFormDefInstance;
            }
            set
            {
                _mFormDefInstance = value;
            }
        }
        #endregion



        private void FrmList_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dgvDatosRegistrados.Select();
        }

        private void CargarDatos()
        {
            _solicitudesInstalacionView = new SolicitudesInstalacionView();
            vSolicitudesInstalacionBindingSource.DataSource = _solicitudesInstalacionView.SelectListView();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            //var form = new FrmCustomer(Convert.ToInt32(Operation.Create), id);
            //if (DialogResult.OK == form.ShowDialog())
            //{
            //    CargarDatos();
            //}
        }

        private void dgvDatosRegistrados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            //var form = new FrmCustomerCompany(Convert.ToInt32(Operation.Create), id);
            //if (DialogResult.OK == form.ShowDialog())
            //{
            //    CargarDatos();
            //}
        }

        private void generarSolicitudInstalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
        //    var frm = new FrmCustomerScheduling(Convert.ToInt32(Operation.Create), id);
        //    if(frm.ShowDialog() == DialogResult.OK)
        //    {
        //        dgvDatosRegistrados_SelectionChanged(sender, e);
        //    }
        }

        private void btnAtenderSolicitud_Click(object sender, EventArgs e)
        {
            Guid customerId = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
            Guid customerAddressId = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[1].Value.ToString());
            Guid installationRequestId = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[2].Value.ToString());

            var frm = new FrmTechnicalServe(Convert.ToInt32(Operation.Create), customerId, customerAddressId, installationRequestId);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarDatos();
            }
        }
    }
}
