using Capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Capa_entidad;

namespace Capa_negocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario(); //Instancia a la clase cd_usuario de la capa datos.

        public Usuario Login(string _usuario, string _contrasena)
        {
            return objcd_usuario.Login(_usuario, _contrasena); //nos devuelve la  misma lista.

        }
       
    }
}
