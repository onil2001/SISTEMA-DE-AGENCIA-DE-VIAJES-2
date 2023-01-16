using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Manejador_Cliente
    {
        public SqlCommand cmd;
        public SqlDataReader dr;
        public DataTable dt;
        Conexion_Desconexion_bd c = new Conexion_Desconexion_bd();

        //Método para enviar la solicitud de ingreso de cliente hacia la base de datos
        //Dichos datos fueron ingresados en la capa de presentación, sin embargo, se enviaron hacia la capa lógica de negocios para poder llamarlos en la presente capa (acceso de datos)
        public String insertar_cliente(List<Parametros_Cliente> lst)
        {
            string msj = "";
            try
            {   //Se crea el if dentro del Try para denotar posibles errores
                if (lst != null)
                {
                    //Se establece que la sentencia de insert se envie si la lista es diferente de null, es decir, no está vacia.
                    //Se envían los parámetros de la lista hacia cada campo de la base de datos, posteriormente, se ejecuta la sentencia y se cierra la conexión
                    cmd = new SqlCommand("Insert into Cliente(codigo, apellido, nombre, cedula, numero_telefono, correo_electronico, direccion) values ('" + lst[0].Codigos + "','" + lst[0].Apellidos + "','" + lst[0].Nombres + "','" + lst[0].Cedula + "','" + lst[0].Numero_Telefono + "','" + lst[0].Correo_Electronico + "','" + lst[0].Direccion + "')", c.abrir_conexion());
                    cmd.ExecuteNonQuery();
                    c.cerrar_conexion();
                    msj = "Registro exitoso :)";
                }
            }
            //Se atrapan las excepciones
            catch (Exception ex)
            {
                msj = "Error de registro por:" + ex;
            }
            return msj;
        }

        //Método para iterar los códigos de la solicitud de manera automática
        public string GenerarCodigo(string tabla)
        {
            //Se definen dos variables las cuales permitirán denotar el valor actual del código
            string codigo = string.Empty;
            int total = 0;
            //Se establece la sentencia
            cmd = new SqlCommand("select count(*) as codigo from " + tabla, c.abrir_conexion());
            dr = cmd.ExecuteReader();
            //Se dice que mientras el DataRed lea entonces se almacene en la variable total la iteración del campo codigo.
            if (dr.Read())
            {
                total = Convert.ToInt32(dr["codigo"]) + 1;
            }
            c.cerrar_conexion();
            //Se establece que la variable de codigo tomará el valor del total, es decir, el numero actual de código.
            codigo = total.ToString();
            /*
            if (total < 10)
            {
                codigo = "000" + total;
            }
            else if (total < 100)
            {
                codigo = "00" + total;
            }
            else if (total < 1000)
            {
                codigo = "0" + total;
            }
            */
            //Se retorna el código
            return codigo;
        }

        //Método necesario para enviar una sentencia a la base de datos, la cual permita almacenar todos los clientes ingresados
        //(en primeras instancias el datatable con los datos almacenados será enviado hacia
        //la capa lógica de negocios (método con el mismo nombre), luego en la capa de presentación se llamará hacia dichos datos para presentarlos en el datagridview)
        public DataTable cargarDatos(string tabla)
        {
            dt = new DataTable();

            cmd = new SqlCommand("Select * from " + tabla, c.abrir_conexion());
            dr = cmd.ExecuteReader();
            dt.Load(dr);

            c.cerrar_conexion();
            return dt;
        }

        //Método para enviar la solicitud de las consultas con los parámetros establecidos (apellido obligatorio y nombre opcional)
        public DataTable consultarApellidoyNombre(String apellido, String nombre)
        {
            dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select * from Cliente where apellido = @apellido " + " and nombre like @nombre", c.abrir_conexion());
                cmd.Parameters.AddWithValue("apellido", apellido);
                cmd.Parameters.AddWithValue("nombre", nombre);
                SqlDataAdapter con = new SqlDataAdapter(cmd);
                con.Fill(dt);
                c.cerrar_conexion();

            }
            ////Se atrapan las excepciones y se cierra la conexión
            catch (Exception ex)
            {
                String msj = "Error de registro por:" + ex;
            }
            return dt;
        }

        //Método para enviar la solicitud de modificación hacia la base de datos
        //Dichos datos fueron ingresados en la capa de presentación, sin embargo, se enviaron hacia la capa lógica de negocios para poder llamarlos en la presente capa (acceso de datos)
        public String modificar_cliente(List<Parametros_Cliente> lst)
        {
            string msj = "";
            try
            {
                //Se crea el if dentro del Try para denotar posibles errores
                if (lst != null)
                {   //Se establece que la sentencia de Update se envie si la lista es diferente de null, es decir, no está vacia.
                    //Se envían los parámetros almacenados en la lista hacia cada campo de la base de datos, posteriormente, se ejecuta la sentencia y se cierra la conexión
                    cmd = new SqlCommand("Update Cliente " +
                                         "set apellido = @apellido, nombre = @nombre, cedula = @cedula, numero_telefono = @numero_telefono, correo_electronico = @correo_electronico, direccion = @direccion " + "where codigo = @codigo ;", c.abrir_conexion());
                    cmd.Parameters.AddWithValue("codigo", lst[0].Codigos);
                    cmd.Parameters.AddWithValue("apellido", lst[0].Apellidos);
                    cmd.Parameters.AddWithValue("nombre", lst[0].Nombres);
                    cmd.Parameters.AddWithValue("cedula", lst[0].Cedula);
                    cmd.Parameters.AddWithValue("numero_telefono", lst[0].Numero_Telefono);
                    cmd.Parameters.AddWithValue("correo_electronico", lst[0].Correo_Electronico);
                    cmd.Parameters.AddWithValue("direccion", lst[0].Direccion);
                    cmd.ExecuteNonQuery();
                    c.cerrar_conexion();
                    msj = "Modificación exitosa :)";
                }
            }
            ////Se atrapan las excepciones y se cierra la conexión
            catch (Exception ex)
            {
                msj = "Error de modificación por:" + ex;
            }
            return msj;
        }
        //Se creará una lista de objetos la cual devuelva los valores de cada campo desde la base de datos
        public List<Object> busquedaCliente()
        {
            try
            {   //Se define una lista de objetos y las sentencias necesarias para devolver los valores desde la base de datos
                List<Object> lstCliente = new List<Object>();
                cmd = new SqlCommand("Select codigo, apellido, nombre, cedula, numero_telefono, correo_electronico, direccion " + "from Cliente;", c.abrir_conexion());
                SqlDataReader registros = cmd.ExecuteReader();
                //Se define que mientras la variable de SqlDataReader lea los datos, se agreguen a la lista de objetos de cliente
                while (registros.Read())
                {
                    var tmp = new
                    {
                        codigo = registros["codigo"].ToString(),
                        apellido = registros["apellido"].ToString(),
                        nombre = registros["nombre"].ToString(),
                        cedula = registros["cedula"].ToString(),
                        numero_telefono = registros["numero_telefono"].ToString(),
                        correo_electronico = registros["correo_electronico"].ToString(),
                        direccion = registros["direccion"].ToString()
                    };
                    lstCliente.Add(tmp);
                }
                //Se cierra la conexión y se devuelve la lista de clientes
                c.cerrar_conexion();
                return lstCliente;
            }
            //Se atrapan las excepciones y se cierra la conexión
            catch (Exception ex)
            {
                c.cerrar_conexion();
                throw ex;
            }
        }
    }
}