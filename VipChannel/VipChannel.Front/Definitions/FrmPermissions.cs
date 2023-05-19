using System;
using System.Windows.Forms;
using VipChannel.Application.Entity;
using VipChannel.Domain.Entity;

namespace VipChannel.Front.Definitions
{

    public partial class FrmPermissions : Form
    {
        Guid _idRol;
        string _permisos = "";
        string _cadenaPermisos = "";
        int _contador = 0;
        private Role _roleEntity;
        private RoleApplication _roleApplication;


        public FrmPermissions(Guid idRol, string rolDescripcion)
        {
            InitializeComponent();
            _idRol = idRol;
            CargarPermisos();
            txtDescripcion.Text = rolDescripcion;
        }

        private void CargarPermisos()
        {
            AsignarEntidad(_idRol);

            _permisos = _roleEntity.Permissions;
            this.treeViewAjustes.ExpandAll();
            this.treeViewMantenimientos.ExpandAll();
            this.treeViewPlanes.ExpandAll();
            this.treeViewVentas.ExpandAll();
            this.treeViewSolicitudes.ExpandAll();

            ListarTreeView(treeViewAjustes);
            ListarTreeView(treeViewMantenimientos);
            ListarTreeView(treeViewPlanes);
            ListarTreeView(treeViewVentas);
            ListarTreeView(treeViewSolicitudes);
        }


        public void ListarTreeView(TreeView nombreArbol)
        {
            foreach (TreeNode tool in nombreArbol.Nodes)
            {
                if ((_permisos.Substring(_contador, 1) == "0"))
                {
                    tool.Checked = false;
                }
                else
                {
                    tool.Checked = true;
                }
                _contador++;
                if (tool.Nodes.Count > 0)
                {
                    ChekMenu(tool.Nodes);
                }
            }
        }

        private void ChekMenu(TreeNodeCollection item)
        {
            foreach (TreeNode i in item)
            {
                if (i is TreeNode)
                {

                    if ((_permisos.Substring(_contador, 1) == "0"))
                    {
                        i.Checked = false;
                    }
                    else
                    {
                        i.Checked = true;
                    }
                    _contador++;
                    if (((TreeNode)i).Nodes.Count > 0)
                    {

                        ChekMenu(((TreeNode)i).Nodes);
                    }
                }
            }
        }

        private void AsignarEntidad(Guid id)
        {
            _roleEntity = new Role();
            _roleApplication = new RoleApplication();
                
            _roleEntity = _roleApplication.SelectSingle(item => item.RoleId.Equals(id));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((treeViewAjustes.Nodes[0].Checked == true))
                _cadenaPermisos += "1";
            else
                _cadenaPermisos += "0";
            RecorrerNodos(treeViewAjustes.Nodes[0]);

            if ((treeViewMantenimientos.Nodes[0].Checked == true))
                _cadenaPermisos += "1";
            else
                _cadenaPermisos += "0";
            RecorrerNodos(treeViewMantenimientos.Nodes[0]);

            if ((treeViewPlanes.Nodes[0].Checked == true))
                _cadenaPermisos += "1";
            else
                _cadenaPermisos += "0";
            RecorrerNodos(treeViewPlanes.Nodes[0]);

            if ((treeViewVentas.Nodes[0].Checked == true))
                _cadenaPermisos += "1";
            else
                _cadenaPermisos += "0";
            RecorrerNodos(treeViewVentas.Nodes[0]);

            if ((treeViewSolicitudes.Nodes[0].Checked == true))
                _cadenaPermisos += "1";
            else
                _cadenaPermisos += "0";
            RecorrerNodos(treeViewSolicitudes.Nodes[0]);

            _roleApplication = new RoleApplication();
            _roleApplication.ActualizarPermisos(_roleEntity.RoleId, _cadenaPermisos);
            MessageBox.Show("Permisos de " + _roleEntity.Description + " asignados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _cadenaPermisos = "";
            this.Close();
        }

        private void RecorrerNodos(TreeNode objNode)
        {
            TreeNode Nodo;
            Nodo = objNode;
            foreach (TreeNode node in Nodo.Nodes)
            {
                if ((node.Checked == true))
                {
                    _cadenaPermisos += "1";
                }
                else
                {
                    _cadenaPermisos += "0";
                }
                RecorrerNodos(node);
            }
        }
        private void CheckParentNode(TreeNode currNode)
        {
            var parentNode = currNode.Parent;
            if ((parentNode == null))
            {
                return;
            }
            parentNode.Checked = false;
            foreach (TreeNode node in parentNode.Nodes)
            {
                if (node.Checked)
                {
                    parentNode.Checked = true;
                    break;
                }
            }
            CheckParentNode(parentNode);
        }


        private void CheckChildNode(TreeNode currNode)
        {
            var checkStatus = currNode.Checked;
            foreach (TreeNode node in currNode.Nodes)
            {
                node.Checked = checkStatus;
                CheckChildNode(node);
            }
        }



        private void treeViewAjustes_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeViewAjustes.AfterCheck -= treeViewAjustes_AfterCheck;
            CheckChildNode(e.Node);
            CheckParentNode(e.Node);
            treeViewAjustes.AfterCheck += treeViewAjustes_AfterCheck;
        }

        private void treeViewMantenimientos_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeViewMantenimientos.AfterCheck -= treeViewMantenimientos_AfterCheck;
            CheckChildNode(e.Node);
            CheckParentNode(e.Node);
            treeViewMantenimientos.AfterCheck += treeViewMantenimientos_AfterCheck;
        }

        private void treeViewPlanes_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeViewPlanes.AfterCheck -= treeViewPlanes_AfterCheck;
            CheckChildNode(e.Node);
            CheckParentNode(e.Node);
            treeViewPlanes.AfterCheck += treeViewPlanes_AfterCheck;
        }

        private void treeViewVentas_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeViewVentas.AfterCheck -= treeViewVentas_AfterCheck;
            CheckChildNode(e.Node);
            CheckParentNode(e.Node);
            treeViewVentas.AfterCheck += treeViewVentas_AfterCheck;
        }

        private void treeViewSolicitudes_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeViewSolicitudes.AfterCheck -= treeViewSolicitudes_AfterCheck;
            CheckChildNode(e.Node);
            CheckParentNode(e.Node);
            treeViewSolicitudes.AfterCheck += treeViewSolicitudes_AfterCheck;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
