using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreriaToDoApp.Modelo
{
    public class Tarea
    {
        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }

    }
}
