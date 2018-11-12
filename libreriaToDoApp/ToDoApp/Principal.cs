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

        public Principal()
        {

        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {

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


        //agregar tareas 
        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            FrmAgregarTareas frm = new FrmAgregarTareas(this.tvGrupos.SelectedNode.Text);
            DialogResult resultado = frm.ShowDialog();

            TreeNode nodoSeleccionado = this.tvGrupos.SelectedNode;

            if (resultado == DialogResult.Yes)
            {
                Tarea tarea = frm.GetTarea();
                CMD = "SELECT * FROM Grupos where nombre='" + nodoSeleccionado.Text + "'";
                data = Sql.Ejecutar(CMD);
                int id_grupo = int.Parse(data.Tables[0].Rows[0]["Id_Grupo"].ToString().Trim());
                CMD = string.Format("INSERT INTO Tareas(Nombre,Prioridad,fechaInicio ,fechaFinalizacion,porcentaje,Id_Grupo)" +
                                                   "VALUES ('" + tarea.Nombre + "'," + "'" + tarea.Prioridad + "', "
                                                          + "'" + tarea.fechaInicio + "', "+ "'" + tarea.fechaFinal + "', " 
                                                          + 50 + "," +id_grupo+ ")");
                guardarNodo(CMD);
                ActualizarTareas();
                //this.gvTareas.Rows.Add("",""+tarea.Nombre,""+tarea.Prioridad,"",""+tarea.fechaInicio+);
            }
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

            DataView datos = new DataView(data.Tables[0]);

            foreach (DataRowView dataRowCurrent in datos)
            {
                TreeNode nodo = new TreeNode();
                nodo.Text = dataRowCurrent["nombre"].ToString().Trim();
                this.tvGrupos.Nodes.Add(nodo);
            }
                
        }


        private void VerTareas(object sender, TreeNodeMouseClickEventArgs e)
        {
            ActualizarTareas(); 
        }

        private void ActualizarTareas() {
            TreeNode nodoSeleccionado = this.tvGrupos.SelectedNode;
            CMD = "SELECT * FROM Grupos where nombre='" + nodoSeleccionado.Text + "'";
            data = Sql.Ejecutar(CMD);
            int id_grupo = int.Parse(data.Tables[0].Rows[0]["Id_Grupo"].ToString().Trim());
            CMD = "SELECT * FROM tareas WHERE Id_Grupo =" + id_grupo;

            data = Sql.Ejecutar(CMD);
            DataView datos = new DataView(data.Tables[0]);
            gvTareas.Rows.Clear();

            foreach (DataRowView dataRowCurrent in datos)
            {
                DataGridViewRow fila = new DataGridViewRow();
                int i = gvTareas.Rows.Add();
                gvTareas.Rows[i].Cells["IdTarea"].Value = dataRowCurrent["id_tarea"].ToString().Trim();
                gvTareas.Rows[i].Cells["Nombre"].Value = dataRowCurrent["nombre"].ToString().Trim();
                gvTareas.Rows[i].Cells["Prioridad"].Value = dataRowCurrent["prioridad"].ToString().Trim();
                gvTareas.Rows[i].Cells["Porcentaje"].Value = dataRowCurrent["porcentaje"].ToString().Trim();
            }
        }
    }
}
