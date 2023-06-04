using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Cliente
    { 
        public int IDCliente {get; set;}
        public string Documento { get; set;}
        public string Nombrecompleto { get; set;}
        public string Correo { get; set;}
        public string Telefono { get; set;}
        public bool Estado { get; set;}
        public string FechaDeRegistro { get; set; }
    }
}
