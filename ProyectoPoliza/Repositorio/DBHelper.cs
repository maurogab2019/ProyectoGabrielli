using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoliza.Repositorio
{
    public class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();


        private DBHelper()
        {
            string_conexion = "Server=tcp:bdpedidos.database.windows.net,1433;Initial Catalog=pedidos;Persist Security Info=False;User ID=mauro;Password=Belgrano1000;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        }
        public static DBHelper GetDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public DataTable ConsultaSQL(string strSql)
        {
            try
            {
                //inicializo una conexion a una bd 
                SqlConnection cnn = new SqlConnection();
                //inicializo una query o sp
                SqlCommand cmd = new SqlCommand();
                //creo una tabla en memoria
                DataTable tabla = new DataTable();
                //defino la cadena de conexion que abrira el sqlConnecion
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //establezco la conexion que usara el sql query
                cmd.Connection = cnn;
                //defino la query como un text/string
                cmd.CommandType = CommandType.Text;
                //defino la query o sp que se ejecutara en la Connection definida antes
                cmd.CommandText = strSql;
                //envio el command text a Connection,con load obtengo en forma de DataTable los datos obtenidos de DataReader
                tabla.Load(cmd.ExecuteReader());
                this.CloseConnection(cnn);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocurrio un problema desconocido con el almacenamento de datos");
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
        }

        public int EjecutarSQL(string strSql)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cnn.ConnectionString = string_conexion;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            afectadas = cmd.ExecuteNonQuery();
            this.CloseConnection(cnn);
            return afectadas;
        }
    }
}
