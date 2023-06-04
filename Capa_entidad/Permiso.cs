using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Permiso
    {
        public int IDPermiso{get; set;}
        public Rol oRol { get; set;} //Relacionandolo a la clase rol inmediatamente
        public string NombreMenu { get; set;}   
        public String FechaDeRegistro {get; set;}

    }
}
