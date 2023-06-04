using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class DetalleCompra
    {
        public int IDDetallecompra {get; set;}
        public Producto oProducto { get; set;}  
        public decimal Precio { get; set;}
        public int Cantidad { get; set;}
        public decimal MontoTotal { get; set; }
        public string FechaDeRegistro { get; set; }
    }
}
