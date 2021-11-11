using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupo9.Datos
{
    class Datos
    {
        private static Datos instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;

        private Datos()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = @"Data Source=DESKTOP-O6JL5EQ\SQLEXPRESS;Initial Catalog=Proyecto PAV;Integrated Security=True";
        }
        public static Datos obtenerInstancia()
        {
            if (instancia == null)
                instancia = new Datos();
            return instancia;
        }
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }
        public void actualizar(string consultaSQL)
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            comando.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
