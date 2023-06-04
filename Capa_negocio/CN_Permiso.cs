using Capa_datos;
using Capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_negocio
{
    public class CN_Permiso
    {
        private CD_Permiso objcd_permiso = new CD_Permiso(); //Instancia a la clase cd_usuario de la capa datos.

        public List<Permiso> Listar(int IDUsuario)
        {
            return objcd_permiso.Listar(IDUsuario); //nos devuelve la  misma lista.

        }
    }
}
