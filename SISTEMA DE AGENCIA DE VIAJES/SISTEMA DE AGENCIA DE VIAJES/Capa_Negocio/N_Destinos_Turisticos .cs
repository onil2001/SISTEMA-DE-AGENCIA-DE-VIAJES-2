using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    
    public class N_Destinos_Turisticos
    {
        // Se crea un nuevo objeto D_Destinos_Turisticos
        D_Destinos_Turisticos Dt = new D_Destinos_Turisticos();

        // Método que utiliza el método D_RegistroDestinosTuristicos de la clase de datos para registrar un nuevo destino turístico
        public String N_Registar_Destinos_Turisticos(E_Destino_Turisticos obje)
        {
            return Dt.D_RegistroDestinosTuristicos(obje);
        }

        // Método que utiliza el método D_Listar_Destinos_Turisticos de la clase de datos para listar todos los destinos turísticos
        public DataTable N_Listar_Destinos_Turisticos()
        {
            return Dt.D_Listar_Destinos_Turisticos();
        }

        // Método que utiliza el método D_buscar_DestinoTuristicos de la clase de datos para buscar los destinos turísticos
        public DataTable N_buscar_DestinoTuristicos(E_Destino_Turisticos obje)
        {
            return Dt.D_buscar_DestinoTuristicos(obje);
        }
    }

   

}
