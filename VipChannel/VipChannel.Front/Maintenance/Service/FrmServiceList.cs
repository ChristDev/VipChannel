using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Constants;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Maintenance.Service
{
    public partial class FrmServiceList : Form
    {
        private ServiceApplication _serviceApplication;
        public FrmServiceList()
        {
            InitializeComponent();
            Text = FormListNames.FrmServiceList;
        }

        #region Abrir formulario solo una vez
        private static FrmServiceList _mFormDefInstance;
        public static FrmServiceList DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmServiceList();
                return _mFormDefInstance;
            }
            set
            {
                _mFormDefInstance = value;
            }
        }
        #endregion


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Guid id = Guid.NewGuid();
            var form = new FrmService(Convert.ToInt32(Operation.Create), id);
            if(DialogResult.OK == form.ShowDialog())
            {                
                CargarDatos();
            }
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            CargarDatos();
            dgvDatosRegistrados.Select();
        }

        private void CargarDatos()
        {
            _serviceApplication = new ServiceApplication();
            serviceBindingSource.DataSource = _serviceApplication.SelectList(x=>x.RecordStatus == ConstantBase.Active);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {            
            if (dgvDatosRegistrados.CurrentRow != null)
            {
                Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var form = new FrmService(Convert.ToInt32(Operation.Update), id);
                if (DialogResult.OK == form.ShowDialog())
                {
                    CargarDatos();
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
            var serviceApplication = new ServiceApplication();
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());

            var entity = new Domain.Entity.Service();
            entity = serviceApplication.SelectSingle(x => x.ServiceId == id, true);

            entity.RecordEditDate = DateTime.Now;
            entity.UserEditRecord = "LOAD";
            entity.RecordStatus = ConstantBase.Inactive;

            serviceApplication.Update(entity);
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }
    }
}
