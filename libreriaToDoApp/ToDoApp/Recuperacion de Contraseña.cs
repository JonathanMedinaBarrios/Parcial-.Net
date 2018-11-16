using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class Recuperacion_de_Contraseña : Form
    {
        public Recuperacion_de_Contraseña()
        {
            InitializeComponent();
        }

        public string getNombre() {
            return this.textCorreo.Text; 
        }
    }
}
