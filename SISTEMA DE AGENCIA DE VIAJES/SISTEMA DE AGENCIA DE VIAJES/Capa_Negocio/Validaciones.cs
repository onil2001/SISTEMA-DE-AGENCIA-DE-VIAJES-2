using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class Validaciones
    {

        //Delegado para llamar al método de error
        public delegate void ErrorCallback(string message);

        //Método para verificar si una cadena es un número decimal válido
        public bool IsDecimal(string text, ErrorCallback errorCallback)
        {
            decimal value;
            //Convierte la cadena a decimal
            if (!decimal.TryParse(text, out value))
            {
                //Si la cadena está vacía, llamar al método de error
                errorCallback("El precio ingresado no es válido. Ingrese un número decimal.");
                return false;
            }
            return true;
        }

        //Método para verificar si una cadena contiene solo numeros y no está vacia
        public bool IsOnlyNumbersAndNotEmpty(string input, Action<string> ShowErrorMessage)
        {
            //Verofoca que la cadena no esté vacia
            if (string.IsNullOrWhiteSpace(input))
            {
                ShowErrorMessage("Error, existen campos vacios");
                return false;
            }

            //Usa una expresión regular para verificar si la cadena contiene solo numeros
            if (!Regex.IsMatch(input, @"^[0-9]+$"))
            {
                ShowErrorMessage("Error, existen campos numéricos que contienen letras");
                return false;
            }
            return true;
        }


        //Método para verificar si una cadena contiene solo letras y no está vacía
        public bool IsOnlyLettersAndNotEmpty(string input, Action<string> ShowErrorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                ShowErrorMessage("Error, existen campos vacios");
                return false;
            }

            //Usa una expresión regular para verificar si la cadena contiene letras, espacios y acentuaciones
            if (!Regex.IsMatch(input, @"^[A-Za-zÁÉÍÓÚáéíóúñÑ ]+$"))
            {
                ShowErrorMessage("Error, existen campos de letras que contienen números");
                return false;
            }
            return true;
        }

        public bool NotEmpty(string input, Action<string> ShowErrorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                ShowErrorMessage("Error, existen campos vacios");
                return false;
            }
            return true;
        }


        //Método para verificar si una cadena es un número decimal válido
        public bool EsDecimal(string text, ErrorCallback errorCallback)
        {
            decimal value;
            //Convierte la cadena a decimal
            if (!decimal.TryParse(text, out value))
            {
                //Si la cadena está vacía, llamar al método de error
                errorCallback("El precio ingresado no es válido. Debe ingresar un número decimal o entero.");
                return false;
            }
            return true;
        }

        //Método para verificar que las caja de texto no estén vacias
        public bool NoVacio(string text, string fieldName, ErrorCallback errorCallback)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                errorCallback(fieldName + " es obligatorio.");
                return false;
            }
            return true;
        }

        public bool SoloLetras(string input, Action<string> ShowErrorMessage)
        {
            //Usa una expresión regular para verificar si la cadena contiene solo letras
            if (!Regex.IsMatch(input, @"^[a-zA-Z]+$"))
            {
                ShowErrorMessage("La entrada debe contener solo letras.");
                return false;
            }
            return true;
        }


    }
}
