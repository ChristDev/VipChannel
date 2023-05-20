using System;
using System.Linq;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Enums.MasterTables;
using VipChannel.Front.Functions;

namespace VipChannel.Front.Principal
{
    public partial class FrmLogin : Form
    {
        private HashByte _hashByte;
        private EmployeeApplication _employeeApplication;
        private TechnicalApplication _technicalApplication;

        int _intentos = 3;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CargarCombo()
        {
            var employeeType = new MasterTableApplication();
            cboEmployeeType.DataSource = employeeType.SelectList(x=>x.IdMasterTableParent == ConstantMasterTable.MasterTable.EmployeeType);
            cboEmployeeType.DisplayMember = "Name";
            cboEmployeeType.ValueMember = "IdMasterTable";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show(this, "Ingrese un Usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show(this, "Ingrese un Contraseña", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Logeo(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            }
        }

        private void Logeo(string username, string password)
        {
            _hashByte = new HashByte();
            byte[] passwordMd5 = null;

            if(cboEmployeeType.SelectedValue. ToString() == ConstantEmployeeType.Administrativo)
            {
                _employeeApplication = new EmployeeApplication();
                var usuario = _employeeApplication.SelectList(x => x.DocumentNumber == username).FirstOrDefault();
                passwordMd5 = _hashByte.ConvertStringToMd5(password);

                if (usuario != null)
                {
                    if (usuario.Password.SequenceEqual(passwordMd5))
                    {
                        var assignmentApplication = new AssignmentApplication();
                        var assignment = assignmentApplication.SelectSingle(x => x.EmployeeId == usuario.EmployeeId);

                        string usuarioActivo = usuario.Names + " " + usuario.LastName;
                        MessageBox.Show(this, "BIENVENIDO: " + usuarioActivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmMenu frm = new FrmMenu(usuario.EmployeeId.ToString(), 
                                                  usuarioActivo,
                                                  assignment.SucursalId.ToString(),
                                                  assignment.SaleBoxId.ToString()
                                                  );
                        _intentos = 3;
                        GuardarConfig(usuario.EmployeeId.ToString());
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        _intentos--;
                        MessageBox.Show(this, string.Format("Contraseña incorrecta. Quedan {0} intentos", _intentos),
                            "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarFormulario();
                    }
                }
                else
                {
                    _intentos--;
                    MessageBox.Show(this, string.Format("Usuario no existe. Quedan {0} intentos", _intentos),
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarFormulario();
                }

                if (_intentos == 0)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }

            else if(cboEmployeeType.SelectedValue.ToString() == ConstantEmployeeType.Tecnico)
            {
                _technicalApplication = new TechnicalApplication();
                var usuario = _technicalApplication.SelectList(x => x.DocumentNumber == username).FirstOrDefault();
                passwordMd5 = _hashByte.ConvertStringToMd5(password);

                if (usuario != null)
                {
                    if (usuario.Password.SequenceEqual(passwordMd5))
                    {
                        string usuarioActivo = usuario.Names + " " + usuario.LastName;

                        MessageBox.Show(this, "BIENVENIDO: " + usuarioActivo, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmMenu frm = new FrmMenu(usuario.TechnicalId.ToString(), 
                                                  usuarioActivo,
                                                  null,
                                                  null);
                        _intentos = 3;
                        GuardarConfig(usuario.TechnicalId.ToString());
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        _intentos--;
                        MessageBox.Show(this, string.Format("Contraseña incorrecta. Quedan {0} intentos", _intentos),
                            "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarFormulario();
                    }
                }
                else
                {
                    _intentos--;
                    MessageBox.Show(this, string.Format("Usuario no existe. Quedan {0} intentos", _intentos),
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarFormulario();
                }

                if (_intentos == 0)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else
            {

            }
        }

        private void GuardarConfig(string idUsuario)
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.AppSettings.Settings["IdUsuario"].Value = idUsuario.ToString();

            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("appSettings");
        }

        private void LimpiarFormulario()
        {
            cboEmployeeType.SelectedIndex = -1;
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtUsername.Focus();
        }
    }
}
