using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Detalleventa
    {
        public int IDDetalleventa { get; set; }
        public Producto oProducto { get; set; }
        public decimal Precioventa { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public string FechaDeRegistro { get; set; }

    }
}
