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
using libreriaToDoApp;

namespace ToDoApp
{
    public partial class Principal : Form
    {

        public DataSet  data = null ;
        string CMD;
        public int Id_usuario ; 

        public Principal(int id)
        {
            InitializeComponent();
            Id_usuario = id; 
            imprimirGrupo(1);
            tvGrupos.ExpandAll();
        }



        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {

            Ventana_agregar_grupos ventana_Agregar_Grupos = new Ventana_agregar_grupos();
            ventana_Agregar_Grupos.ShowDialog();
            if (ventana_Agregar_Grupos.DialogResult == DialogResult.Yes)
            {

            }
                FrmGrupo frm = new FrmGrupo(this.tvGrupos.SelectedNode.Text);
            DialogResult resultado = frm.ShowDialog();


            TreeNode nodoSeleccionado = this.tvGrupos.SelectedNode;

            if (resultado == DialogResult.Yes)
            {
                Grupo grupo = frm.GetGrupo();
                TreeNode nodo = new TreeNode();
                nodo.Text = grupo.Nombre;
                nodo.Tag = grupo;


                if (nodoSeleccionado != null)
                {
                    CMD = "SELECT * FROM Grupos where nombre='"+ nodoSeleccionado.Text+"'";
                    data = Sql.Ejecutar(CMD);
                    int id_grupo = int.Parse(data.Tables[0].Rows[0]["Id_Grupo"].ToString().Trim());
                    CMD = string.Format("INSERT INTO Grupos(Nombre, Id_Usuario,Id_GrupoPadre)" +
                                                   "VALUES ('" + nodo.Text + "'," + 1 +","+id_grupo + ")");
                    guardarNodo(CMD);
                    nodoSeleccionado.Nodes.Add(nodo);
                    this.tvGrupos.SelectedNode = null; 
                }
                else
                {
                    //Raiz
                    this.tvGrupos.Nodes.Add(nodo);
                    CMD = string.Format("INSERT INTO Grupos(Nombre, Id_Usuario)" +
                                                   "VALUES ('" + nodo.Text + "'," + 1 + ")");
                    guardarNodo(CMD);
                }
            }

        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {

        }


        private void guardarNodo(string cmd) {
            try{
                 Sql.Ejecutar(cmd);
            }
            catch (Exception exc){
                MessageBox.Show("Error al guardar el grupo en la base de datos..." + exc);
                String error = "" + exc;
            }
         }

        private void imprimirGrupo(int id){

            CMD = "SELECT * FROM Grupos where Id_Usuario="+ Id_usuario;
            data = Sql.Ejecutar(CMD);

            DataView dataViewHijos = new DataView(data.Tables[0]);

            foreach (DataRowView dataRowCurrent in dataViewHijos)
            {
                TreeNode nodo = new TreeNode();
                nodo.Text = dataRowCurrent["nombre"].ToString().Trim();
                this.tvGrupos.Nodes.Add(nodo);
            }
                
        }

        private void agregarTareas(object sender, TreeNodeMouseClickEventArgs e)
        {
            FrmGrupo frm = new FrmGrupo(this.tvGrupos.SelectedNode.Text);
            DialogResult resultado = frm.ShowDialog();
        }
    }
}
