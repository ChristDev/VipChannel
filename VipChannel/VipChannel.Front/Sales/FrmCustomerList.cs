using System;
using System.Linq;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Constants;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Sales
{
    public partial class FrmCustomerList : Form
    {
        private ClienteView _clienteView;
        private CustomerAddressApplication _customerAddressApplication;
        public FrmCustomerList()
        {
            InitializeComponent();
            Text = FormListNames.FrmCustomerList;
        }

        #region Abrir formulario solo una vez
        private static FrmCustomerList _mFormDefInstance;
        public static FrmCustomerList DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmCustomerList();
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
            _clienteView = new ClienteView();
            vClienteBindingSource.DataSource = _clienteView.SelectListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {            
            if (dgvDatosRegistrados.CurrentRow != null)
            {
                Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());

                var numeroDocumento = dgvDatosRegistrados.CurrentRow.Cells[3].Value.ToString();

                if(numeroDocumento.Length == 11)
                {
                    var form = new FrmCustomerCompany(Convert.ToInt32(Operation.Update), id);
                    if (DialogResult.OK == form.ShowDialog())
                    {
                        CargarDatos();
                    }
                }
                else
                {
                    var form = new FrmCustomer(Convert.ToInt32(Operation.Update), id);
                    if (DialogResult.OK == form.ShowDialog())
                    {
                        CargarDatos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var customerApplication = new CustomerApplication();
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());

            var entity = new Domain.Entity.Customer();
            entity = customerApplication.SelectSingle(x => x.CustomerId == id, true);

            entity.RecordEditDate = DateTime.Now;
            entity.UserEditRecord = "LOAD";
            entity.RecordStatus = ConstantBase.Inactive;

            customerApplication.Update(entity);
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            var form = new FrmCustomer(Convert.ToInt32(Operation.Create), id);
            if (DialogResult.OK == form.ShowDialog())
            {
                CargarDatos();
            }
        }

        private void dgvDatosRegistrados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            var form = new FrmCustomerCompany(Convert.ToInt32(Operation.Create), id);
            if (DialogResult.OK == form.ShowDialog())
            {
                CargarDatos();
            }
        }

        private void generarSolicitudInstalacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
            var frm = new FrmCustomerScheduling(Convert.ToInt32(Operation.Create), id);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                dgvDatosRegistrados_SelectionChanged(sender, e);
            }
        }

        private void dgvDatosRegistrados_SelectionChanged(object sender, EventArgs e)
        {
            _customerAddressApplication = new CustomerAddressApplication();
            Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
            var details = _customerAddressApplication.ListarDireccionPorClienteSolicitud(id).ToList();

            uspListarDireccionPorClienteSolicitudResultBindingSource.DataSource = details.Count == 0 ? null : details;
        }
    }
}
