using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Persona
    {
        //Creamos los atributos de la persona
        protected String apellido;
        protected String nombre;
        protected String cedula;
        protected int numero_telefono;
        protected String correo_electronico;
        protected String direccion;

        private List<Object> lst_obj;

        //Se crearán los dos tipos de constructores
        public Persona() { }
        public Persona(String apellido, String nombre, String cedula, int numero_telefono, String correo_electronico, String direccion)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.cedula = cedula;
            this.numero_telefono = numero_telefono;
            this.correo_electronico = correo_electronico;
            this.direccion = direccion;
        }

        //Se realizarán los respectivos getter y setter

        public String Apellidos
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Nombres
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public int Numero_Telefono
        {
            get { return numero_telefono; }
            set { numero_telefono = value; }
        }

        public String Correo_Electronico
        {
            get { return correo_electronico; }
            set { correo_electronico = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        //Métodos que pueden ser modificados por las clases hijos
        public virtual String registrar() { return ""; }
        public virtual List<Object> listar() { return lst_obj; }
    }
}
