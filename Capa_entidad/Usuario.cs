using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Usuario
    {
        public int IDUsuario {get; set;}
        public string Documento { get; set;}
        public string Nombrecompleto { get; set;} 
        public string Correo { get; set;}
        public string Clave { get; set;}
        public Rol oRol { get; set;} //la o es de objeto 
        public bool Estado { get; set;} 
        public string FechaDeRegistro {get; set;}




    }
}
