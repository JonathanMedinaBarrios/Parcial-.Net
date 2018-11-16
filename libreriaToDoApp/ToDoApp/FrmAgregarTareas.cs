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
    public partial class FrmAgregarTareas : Form
    {
        public FrmAgregarTareas(string nodo)
        {
            InitializeComponent();
        }

        public Tarea GetTarea() {

            return new Tarea() {
                Nombre = this.textTarea.Text,
                Prioridad = cmbPrioridad.Text,
                fechaInicio =DateTime.Parse(dateInicial.Value.ToString("yyyy-MM-dd")),
                fechaFinal = DateTime.Parse(dateFinal.Value.ToString("yyyy-MM-dd")),
            }; 
        }

        private void dateInicial_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgregarTareas_Load(object sender, EventArgs e)
        {

        }

        private void dateFinal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
