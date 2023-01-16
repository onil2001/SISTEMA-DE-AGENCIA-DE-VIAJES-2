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
    public class D_users
    {

       
            //Instancia de la clase Conexion_Desconexion_bd
            Conexion_Desconexion_bd c = new Conexion_Desconexion_bd();

            public DataTable D_user(E_users obje)
            {
                //Abre la conexión a la base de datos
                SqlCommand cmd = new SqlCommand("sp_logueo_ez", c.abrir_conexion());
                cmd.CommandType = CommandType.StoredProcedure;

                //Agrega los parámetros para el procedimiento almacenado
                cmd.Parameters.AddWithValue("@usuario", obje.usuario);
                cmd.Parameters.AddWithValue("@clave", obje.clave);

                //Crea un adaptador de datos para rellenar el DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Cierra la conexión a la base de datos
                c.cerrar_conexion();
                return dt;
            }



        }
    }
