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
    public class N_users
    {
        //Instancia de la clase D_users

        D_users objd = new D_users();

        //Método que recibe un objeto de la clase E_users y retorna un objeto DataTable
        public DataTable N_user(E_users obje)
        {
            //Llama al método D_user de la clase D_users y retorna el resultado
            return objd.D_user(obje);
        }

    }
}
