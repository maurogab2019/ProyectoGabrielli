using ProyectoPoliza.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoliza.Repositorio
{
    public class RepositorioPoliza
    {
        public Poliza getIdPoliza(int idPoliza)
        {
            var sentenciaSql = $"select po.IdPoliza,po.Estado,p.Nombre as NombreProducto,t.Nombre from Poliza po JOIN PRODUCTO p on(p.IdProducto=po.IdProducto) JOIN TipoProducto t on(t.IdTipoProducto = po.IdTipoProducto)  where IdPoliza = {idPoliza}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            //ejecuto la sentencia sql sobre el sql Connection , pasando como parametro el id poliza
            Poliza poliza = new Poliza();
            if(tablaResultado.Rows.Count == 0)
            {
                return null;
            }
            //mapeo y trasnformo las filas del DataTable a los atributos del objeto
            foreach (DataRow fila in tablaResultado.Rows)
            {
                poliza = mapearPoliza(fila);
            }
            return poliza;
        }

        public Poliza mapearPoliza(DataRow fila)
        {
            //mapeo el DataRow a un obejto Poliza
            Poliza poliza = new Poliza();

            poliza.idPoliza = Convert.ToInt32(fila["IdPoliza"]);
            poliza.Estado = fila["Estado"].ToString();
            Producto producto = new Producto();
            producto.Nombre = fila["NombreProducto"].ToString();
            TipoProducto tipoProducto = new TipoProducto();
            tipoProducto.Nombre = fila["Nombre"].ToString();
            poliza.producto = producto;
            poliza.TipoProducto = tipoProducto;
            return poliza;
        }
    }
}
