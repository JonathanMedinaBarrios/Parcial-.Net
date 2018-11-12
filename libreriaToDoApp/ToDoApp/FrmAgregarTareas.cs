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
                fechaInicio = DateTime.Parse(this.dateInicial.Text),
                fechaFinal = DateTime.Parse(this.dateFinal.Text),
            }; 
        }
    }
}
