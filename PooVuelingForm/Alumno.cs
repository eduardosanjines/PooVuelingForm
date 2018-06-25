using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVuelingForm
{
    public class Alumno
    {
        public String id { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String dni { get; set; }
        public override string ToString() {
            return "id: " + id + "\nNombre: " + nombre + "\nApellido: " + apellido + "\ndni: " + dni;

        }

    }
}
