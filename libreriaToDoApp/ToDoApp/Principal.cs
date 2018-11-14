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
            imprimirGruposRaiz(id);
            tvGrupos.ExpandAll();
        }

        public Principal()
        {

        }
        //Region de los botone de la vista principal  
        #region Botones  

        //Agregar Grupo 
        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {

            TreeNode nodoSeleccionado = this.tvGrupos.SelectedNode;
            FrmGrupo frm;
            if (nodoSeleccionado != null)
            {
                frm = new FrmGrupo(this.tvGrupos.SelectedNode.Text);
            }
            else
            {
                frm = new FrmGrupo();
            }

            DialogResult resultado = frm.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                Grupo grupo = frm.GetGrupo();
                TreeNode nodo = new TreeNode();
                nodo.Text = grupo.Nombre;
                nodo.Tag = grupo;


                if (nodoSeleccionado != null)
                {
                    CMD = "SELECT buscarIdgrupo('" + nodoSeleccionado.Text + "')";
                    data = ejecutar(CMD);
                    int id_grupo = int.Parse(data.Tables[0].Rows[0]["buscarIdgrupo"].ToString().Trim());
                    CMD = string.Format("INSERT INTO Grupos(Nombre, Id_Usuario,Id_GrupoPadre)" +
                                                   "VALUES ('" + nodo.Text + "'," + Id_usuario + "," + id_grupo + ")");
                    Ejecutar2(CMD);
                    nodoSeleccionado.Nodes.Add(nodo);
                    this.tvGrupos.SelectedNode = null;
                }
                else
                {
                    //Raiz
                    this.tvGrupos.Nodes.Add(nodo);
                    CMD = string.Format("SElECT GuadarGrupoPadre('" + nodo.Text + "'," + Id_usuario + ")");
                    Ejecutar2(CMD);
                }
            }

        }

        //agregar tareas 
        private void btnAgregarFila_Click(object sender, EventArgs e)
        {

            if (this.tvGrupos.SelectedNode == null)
            {
                MessageBox.Show("Debe selecionar un grupo");
            }
            else
            {
                FrmAgregarTareas frm = new FrmAgregarTareas(this.tvGrupos.SelectedNode.Text);
                DialogResult resultado = frm.ShowDialog();

                TreeNode nodoSeleccionado = this.tvGrupos.SelectedNode;

                if (resultado == DialogResult.Yes)
                {
                    Tarea tarea = frm.GetTarea();
                    CMD = "SELECT buscarIdgrupo('" + nodoSeleccionado.Text + "')"; //Procedimiento almacenado
                    data = Sql.Ejecutar(CMD);
                    int id_grupo = int.Parse(data.Tables[0].Rows[0]["buscarIdgrupo"].ToString().Trim());
                    CMD = "SELECT insertarTareas ('" + tarea.Nombre + "'," + "'" + tarea.Prioridad + "', "
                                              + "'" + tarea.fechaInicio + "', " + "'" + tarea.fechaFinal + "', "
                                                    + 50 + "," + id_grupo + ")"; //Procedimiento almacenado guardarTareas 
                    Ejecutar2(CMD);
                    ActualizarTareas();
                    //this.gvTareas.Rows.Add("",""+tarea.Nombre,""+tarea.Prioridad,"",""+tarea.fechaInicio+);
                }
            }
        }

        //Revover tareas 
        private void btnRemoverTareas(object sender, EventArgs e)
        {
            try
            {
                string id_celda = gvTareas.CurrentCell.Value.ToString();
                CMD = "Select EliminarTareas(" + id_celda + ")";
                Sql.Ejecutar2(CMD);
                ActualizarTareas();
            }
            catch {
               MessageBox.Show("Debe selecionar una celda");
            }            
        }


        #endregion


        #region metodos para imprimir los grupos del usuario

        private void imprimirGruposRaiz(int id_usuario){
            CMD = "SELECT * FROM Grupos where Id_Usuario="+ Id_usuario+ "and Id_grupopadre is null";
            data = ejecutar(CMD);

            DataView datos = new DataView(data.Tables[0]);

            foreach (DataRowView dataRowCurrent in datos)
            {
                TreeNode nodo = new TreeNode();
                nodo.Text = dataRowCurrent["nombre"].ToString().Trim();
                this.tvGrupos.Nodes.Add(nodo);
                CrearGruposHijos(int.Parse(dataRowCurrent["Id_grupo"].ToString().Trim()),nodo);
            }
                
        }

        private void CrearGruposHijos(int indicePadre, TreeNode nodePadre)
        {
            CMD = "SELECT * FROM Grupos where Id_Usuario=" + Id_usuario + "and Id_grupopadre="+ indicePadre;
            DataSet datas = ejecutar(CMD);

            DataView datos = new DataView(datas.Tables[0]);

            if (datos != null) {
                foreach (DataRowView dataRowCurrent in datos)
                {
                    TreeNode nuevoNodo = new TreeNode();
                    nuevoNodo.Text = dataRowCurrent["nombre"].ToString().Trim();
                    nodePadre.Nodes.Add(nuevoNodo);
                    CrearGruposHijos(int.Parse(dataRowCurrent["Id_grupo"].ToString().Trim()), nuevoNodo);
                }
            }
        }

        #endregion


        private void VerTareas(object sender, TreeNodeMouseClickEventArgs e)
        {
           ActualizarTareas();          
        }




        //METODO QUE CONSULTA LAS TAREAS ASOCIADAD A CADA GRUPO 

        private void ActualizarTareas() {

            TreeNode nodoSeleccionado = this.tvGrupos.SelectedNode;
            CMD = "SELECT * FROM Grupos where nombre='" + nodoSeleccionado.Text + "'";
            data = ejecutar(CMD);
            int id_grupo = int.Parse(data.Tables[0].Rows[0]["Id_Grupo"].ToString().Trim());
            CMD = "SELECT * FROM tareas WHERE Id_Grupo =" + id_grupo;

            data = ejecutar(CMD);
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
                gvTareas.Rows[i].Cells["FechaInicio"].Value = dataRowCurrent["FechaInicio"].ToString().Trim();
                gvTareas.Rows[i].Cells["FechaFinal"].Value = dataRowCurrent["Fechafinalizacion"].ToString().Trim();
            }
        }

       

        private void Ejecutar2(string cmd)
        {
            try
            {
                Sql.Ejecutar2(cmd);
            }
            catch (Exception exc)
            {
                MessageBox.Show("" + exc);
                String error = "" + exc;
            }
        }

        private DataSet ejecutar(string cmd)
        {
            try
            {
                return Sql.Ejecutar(cmd);
            }
            catch (Exception exc)
            {
                MessageBox.Show("" + exc);
                String error = "" + exc;
                return null; 
            }
        }
    }
}
