using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_WPF.datos
{
    public class Persona 
    {
        public String Nombre { get; set; }
        
        public String Apellido { get; set; }

       

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
