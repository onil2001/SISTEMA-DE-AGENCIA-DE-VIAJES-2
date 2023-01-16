using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{   //La presente clase será necesaria para guardar los datos que sean enviados de la capa lógica de negocios, es decir, 
    //los datos enviados serán almacenados en los atributos de esta clase para posteriormente ser enviados como consultas
    //hacia la base de datos (en la clase manejador)
    public class Parametros_Cliente
    {
        private int codigo;
        private String apellido;
        private String nombre;
        private String cedula;
        private int numero_telefono;
        private String correo_electronico;
        private String direccion;

        public Parametros_Cliente(int codigo, String apellido, String nombre, String cedula, int numero_telefono, String correo_electronico, String direccion)
        {
            this.codigo = codigo;
            this.apellido = apellido;
            this.nombre = nombre;
            this.cedula = cedula;
            this.numero_telefono = numero_telefono;
            this.correo_electronico = correo_electronico;
            this.direccion = direccion;
        }

        public int Codigos
        {
            get { return codigo; }
            set { codigo = value; }
        }

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
    }
}
