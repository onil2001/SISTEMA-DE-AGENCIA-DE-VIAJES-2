using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{   //Heredará de la clase persona
    public class Cliente_class : Persona
    {
        //Se creará el atributo de código para el cliente
        private int codigo;

        //Se creará un objeto de la clase "Manejador_cliente" y una lista de "Parámetros_cliente"
        Manejador_Cliente m = new Manejador_Cliente();
        List<Parametros_Cliente> lst;

        //Se crearán los dos tipos de constructores

        public Cliente_class() { }

        public Cliente_class(int codigo, String apellido, String nombre, String cedula, int numero_telefono, String correo_electronico, String direccion) : base(apellido, nombre, cedula, numero_telefono, correo_electronico, direccion)
        {
            this.codigo = codigo;
            this.apellido = apellido;
            this.nombre = nombre;
            this.cedula = cedula;
            this.numero_telefono = numero_telefono;
            this.correo_electronico = correo_electronico;
            this.direccion = direccion;
        }
        //Se cren los respectivos getter y setter para código
        public int Codigos
        {
            get { return codigo; }
            set { codigo = value; }
        }


        //Método necesario para interconectar la sentencia de generación automática de código entre la capa de presentación y la capa de acceso de datos
        public string Generar_codigo(string tabla)
        {
            return m.GenerarCodigo(tabla);
        }

        //Método para enviar los datos de registro hacia la capa de acceso de datos(dichos datos fueron ingresados por el usuario en la capa de presentación)

        public override String registrar()
        {
            string msj = "";

            try
            {
                List<Parametros_Cliente> lst = new List<Parametros_Cliente>();
                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(new Parametros_Cliente(Codigos, Apellidos, Nombres, Cedula, Numero_Telefono, Correo_Electronico, Direccion));
                msj = m.insertar_cliente(lst);
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos" + ex;
                throw ex;
            }
            return msj;
        }

        //Método necesario para manipular la data de la base de datos entre las capas de presentación y acceso de datos (con la finalidad de mostrar los datos en el datagridview)
        public DataTable CargarDatos(string tabla)
        {
            return m.cargarDatos(tabla);
        }

        //Método necesario para manipular los datos de consulta entre las capas de presentación y acceso de datos (con la finalidad de mostrar los datos en el datagridview)
        public DataTable consultarApellidoyNombre(string apellido, string nombre)
        {
            return m.consultarApellidoyNombre(apellido, nombre);
        }

        //Método para enviar los datos de modificación hacia la capa de acceso de datos(dichos datos fueron modificados por el usuario en la capa de presentación)
        public string Modificar(int codigo, string apellido, string nombre, string cedula, int numero_telefono, string correo_electronico, string direccion)
        {
            string msj = "";

            //Lista genérica de parámetros
            lst = new List<Parametros_Cliente>();

            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos                
                lst.Add(new Parametros_Cliente(codigo, apellido, nombre, cedula, numero_telefono, correo_electronico, direccion));
                m.modificar_cliente(lst);
                msj = m.modificar_cliente(lst);
            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos";
                return msj;
                throw ex;
            }

            return msj;
        }

        //Método que devolverá la lista de objetos traida de la base de datos (para llenar los campos de textbox en la capa de presentación)
        public List<Object> busquedaCliente()
        {
            return m.busquedaCliente();
        }
    }
}
