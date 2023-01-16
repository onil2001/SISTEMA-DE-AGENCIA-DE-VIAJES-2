using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Aerolinea
    {
        // Propiedad que almacena el código de la aerolínea
        public String codigoAerolinea { get; set; }

        // Propiedad que almacena el nombre de la aerolínea
        public String nombreAerolinea { get; set; }


        // Propiedad que almacena las siglas de la aerolínea
        public String siglasAerolinea { get; set; }


        // Propiedad que almacena la acción a realizar (insertar o actualizar)
        public String accion { get; set; }



    }
}
