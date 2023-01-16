using System;
using System.Collections.Generic;
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
    public class N_Aerolinea
    {
        // Se crea un nuevo objeto D_Aerolinea
        D_Aerolinea Dt = new D_Aerolinea();

        // Método que utiliza el método D_RegistroAerolineas de la clase de datos para registrar una nueva aerolínea
        public String N_Registrar_Aerolinea(E_Aerolinea obje)
        {
            return Dt.D_RegistroAerolineas(obje);
        }


        // Método que utiliza el método D_Listar_Aerolineas de la clase de datos para listar todas las aerolíneas
        public DataTable N_Listar_Aerolinea()
        {
            return Dt.D_Listar_Aerolineas();
        }

        // Método que utiliza el método D_Listar_Aerolineas de la clase de datos para listar todas las aerolíneas
        public DataTable N_Buscar_Aerolineas(E_Aerolinea obje)
        {
            return Dt.D_buscar_Aerolineas(obje);
        }
    }
}
