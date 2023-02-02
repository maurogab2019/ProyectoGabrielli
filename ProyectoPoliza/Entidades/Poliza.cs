using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoliza.Entidades
{
    public class Poliza
    {
        public int idPoliza { get; set; }

        public Producto producto { get; set; }

        public TipoProducto TipoProducto { get; set; }

        public string Estado { get; set; }
    }
}
