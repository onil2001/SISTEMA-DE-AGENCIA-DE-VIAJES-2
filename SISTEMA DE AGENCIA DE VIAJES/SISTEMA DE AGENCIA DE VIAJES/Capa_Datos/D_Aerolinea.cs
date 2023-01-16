using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Capa_Entidad;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class D_Aerolinea

    {

        Conexion_Desconexion_bd c = new Conexion_Desconexion_bd();
       

        // Método para registrar una nueva aerolínea
        public String D_RegistroAerolineas(E_Aerolinea obje)
        {
            // variable de tipo string para almacenar la acción realizada
            String accion = "";

            // Se crea un nuevo objeto SqlCommand para ejecutar un procedimiento almacenado
            SqlCommand cmd = new SqlCommand("sp_ingreso_Aerolineas", c.abrir_conexion());

            // Se agrega los parámetros de entrada para el procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigoAerolinea);
            cmd.Parameters.AddWithValue("@nombre", obje.nombreAerolinea);
            cmd.Parameters.AddWithValue("@siglas", obje.siglasAerolinea);

            // Agrega un parámetro de salida para almacenar la acción realizada
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;

            // Ejecuta el procedimiento almacenado
            cmd.ExecuteNonQuery();

            // Almacena el parámetro de salida en la variable accion
            accion = cmd.Parameters["@accion"].Value.ToString();

            // Cierra la conexión utilizando el objeto Conexion_Desconexion_bd
            c.cerrar_conexion();

            return accion;
        }


        // Método para listar todas las aerolíneas
        public DataTable D_Listar_Aerolineas()
        {
            // Se crea un nuevo objeto SqlCommand para ejecutar un procedimiento almacenado
            SqlCommand cmd = new SqlCommand("sp_listar_Aerolineas", c.abrir_conexion());
            // Se crea un nuevo objeto SqlDataAdapter para ejecutar el comando y llenar un DataTable con los resultados
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Método para Buscar las aerolineas
        public DataTable D_buscar_Aerolineas(E_Aerolinea obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_Aerolineas", c.abrir_conexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombreAerolinea);
            // Se crea un nuevo objeto SqlDataAdapter para ejecutar el comando y llenar un DataTable con los resultados
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
