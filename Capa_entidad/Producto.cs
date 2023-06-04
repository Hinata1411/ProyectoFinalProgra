using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Producto
    {
        public int IDProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion { get; set; }
        public Categoria oCategoria { get; set;}
        public int Stock { get; set;}
        public decimal Precio { get; set;}
        public bool Estado { get; set;}
        public string FechaDeRegistro { get; set;}
    }
}
