using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Application.View;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Constants;
using static VipChannel.Enums.MasterTables.ConstantOperation;

namespace VipChannel.Front.Plan
{
    public partial class FrmPlanCableList : Form
    {
        private PlanCableView _planView;
        public FrmPlanCableList()
        {
            InitializeComponent();
            Text = FormListNames.FrmPlanCableList;
        }

        #region Abrir formulario solo una vez
        private static FrmPlanCableList _mFormDefInstance;
        public static FrmPlanCableList DefInstance
        {
            get
            {
                if (_mFormDefInstance == null || _mFormDefInstance.IsDisposed)
                    _mFormDefInstance = new FrmPlanCableList();
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
            var form = new FrmPlanCable(Convert.ToInt32(Operation.Create), id);
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
            _planView = new PlanCableView();
            vPlanCableBindingSource.DataSource = _planView.SelectListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {            
            if (dgvDatosRegistrados.CurrentRow != null)
            {
                Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());
                var form = new FrmPlanCable(Convert.ToInt32(Operation.Update), id);
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
            var planApplication = new PlanApplication();            
            if (dgvDatosRegistrados.RowCount == 0)
            {
                MessageBox.Show("No hay registros para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            Guid id = Guid.Parse(dgvDatosRegistrados.CurrentRow.Cells[0].Value.ToString());

            var entity = new Domain.Entity.Plan();
            entity = planApplication.SelectSingle(x => x.PlanId == id, true);

            entity.RecordEditDate = DateTime.Now;
            entity.UserEditRecord = "LOAD";
            entity.RecordStatus = ConstantBase.Inactive;

            planApplication.Update(entity);
            MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();
        }
    }
}
