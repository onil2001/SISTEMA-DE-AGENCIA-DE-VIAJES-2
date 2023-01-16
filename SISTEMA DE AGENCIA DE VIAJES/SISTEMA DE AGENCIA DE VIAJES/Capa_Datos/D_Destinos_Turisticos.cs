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
    public class D_Destinos_Turisticos
         
    {
        //Instacia de la clase conexión a la base de datos 
        Conexion_Desconexion_bd c = new Conexion_Desconexion_bd();
      
        // Método para registrar un nuevo destino turístico
        public String D_RegistroDestinosTuristicos(E_Destino_Turisticos obje)
        {
            
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_ingreso_destino_turistico", c.abrir_conexion());
            // objeto SqlCommand para ejecutar un procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@origen", obje.origen);
            cmd.Parameters.AddWithValue("@destino", obje.destino);
            cmd.Parameters.AddWithValue("@precio", obje.precio);

            // Se agrega un parámetro de salida para almacenar la acción realizada
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

        // Método para listar todos los destinos turísticos
        public DataTable D_Listar_Destinos_Turisticos()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_destino_turistico", c.abrir_conexion());

            // Se crea un nuevo objeto SqlDataAdapter para ejecutar el comando y llenar un DataTable con los resultados
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Devuelve el DataTable con los datos
            return dt;
        }
        
        
        // Método para buscar los destinos turísticos
        public DataTable D_buscar_DestinoTuristicos(E_Destino_Turisticos obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_DestinoTuristico", c.abrir_conexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            // Se crea un nuevo objeto SqlDataAdapter para ejecutar el comando y llenar un DataTable con los resultados
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Devuelve el DataTable con los datos
            return dt;
        }

    }



}
