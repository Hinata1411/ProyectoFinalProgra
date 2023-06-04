using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;
using Capa_entidad;

namespace Capa_negocio
{
    public class CN_rol
    {
        private CD_Rol objcd_Rol = new CD_Rol(); //Instancia a la clase cd_rol de la capa datos.

        public List<Rol> Listar()
        {
            return objcd_Rol.Listar(); //nos devuelve la  misma lista.

        }
    }
}
