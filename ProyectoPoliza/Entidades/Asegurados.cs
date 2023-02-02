using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoliza.Entidades
{
    public class Asegurados
    {
        public int idAsegurado { get; set; }

        public Poliza poliza { get; set; }

        public int Dni { get; set; }
        public string Nombre { get; set; }

        public DateTime FechaNacimiento  { get; set; }

        public string Estado { get; set; }


    }
}
