using ProyectoPoliza.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoliza.Repositorio
{
    public class RepositorioAsegurados
    {

        public List<Asegurados> getAseguradosPorPoliza(int idPoliza)
        {
            //creo la lista de asegurados
            List<Asegurados> listaAsegurados = new List<Asegurados>();
            var sentenciaSql = $"select a.IdAsegurado,a.Dni,a.Nombre,a.FechaNacimiento from Asegurados a where a.IdPoliza = {idPoliza} and a.Estado='Activo'";
            //ejecuto la sentencia sql sobre el sql Connection , pasando como parametro el id poliza
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            Asegurados asegurado = new Asegurados();
            //mapeo y trasnformo las filas del DataTable a los atributos del objeto
            foreach (DataRow fila in tablaResultado.Rows)
            {
                asegurado = mapearAsegurado(fila);
                listaAsegurados.Add(asegurado);
            }
            return listaAsegurados;
        }

        public Asegurados mapearAsegurado(DataRow filaAsegurado)
        {
            Asegurados asegurado = new Asegurados();
            asegurado.idAsegurado = Convert.ToInt32(filaAsegurado["IdAsegurado"]);
            asegurado.Dni = Convert.ToInt32(filaAsegurado["Dni"]);
            asegurado.Nombre = filaAsegurado["Nombre"].ToString();
            asegurado.FechaNacimiento = Convert.ToDateTime(filaAsegurado["FechaNacimiento"]);
            return asegurado;
        }

        public int EliminarAsegurado(int idAseguradoEliminar)
        {
            var sentenciaSql = $"UPDATE Asegurados set Estado='Inactivo' where IdAsegurado={idAseguradoEliminar}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            //paso el id del asegurado a eliminar y valido si se aplico a BD
            if(filasAfectadas == 1)
            {
                return 1;
            }
            throw new ApplicationException("No se elimino ese asegurado");

        }
    }
}
