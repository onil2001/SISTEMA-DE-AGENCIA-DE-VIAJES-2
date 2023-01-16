using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    //En la presente clase crearemos una sentencia que se conecte con la base de datos definida en App.Config y se crearan métodos para conectar y desconectar de la base de datos.
    public class Conexion_Desconexion_bd
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        //Abrir conexión hacia la base de datos
        public SqlConnection abrir_conexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        //Cerrar conexión hacia la base de datos
        public SqlConnection cerrar_conexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
