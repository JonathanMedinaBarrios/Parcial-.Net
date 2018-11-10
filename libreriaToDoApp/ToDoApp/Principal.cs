using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaToDoApp.Modelo;

namespace ToDoApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            FrmGrupo frm = new FrmGrupo();
            DialogResult resultado = frm.ShowDialog();


            TreeNode nodoSeleccionado = this.tvGrupos.SelectedNode;
            frm.agregarNodoPadre(""+this.tvGrupos.SelectedNode); 
            if (resultado == DialogResult.Yes)
            {
                Grupo grupo = frm.GetGrupo(); 
                TreeNode nodo = new TreeNode();
                nodo.Text = grupo.Nombre;
                nodo.Tag = grupo;

                if (nodoSeleccionado != null)
                {
                    nodoSeleccionado.Nodes.Add(nodo);
                }
                else
                {
                    //Raiz
                    this.tvGrupos.Nodes.Add(nodo);
                }
            }
        }
    }
}
