using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Destino_Turisticos
    {
        // Propiedad que almacena el código del destino turístico
        public String codigo { get; set; }


        // Propiedad que almacena el lugar de origen del destino turístico
        public String origen { get; set; }


        // Propiedad que almacena el lugar de destino del destino turístico
        public String destino { get; set; }


        // Propiedad que almacena el precio del destino turístico
        public decimal precio { get; set; }


        // Propiedad que almacena la acción a realizar (insertar o actualizar)
        public String accion { get; set; }
    }
  


}
