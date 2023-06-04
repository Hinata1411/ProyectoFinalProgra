using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Compra
    {
        public int IDCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor oProveedor { get; set;}
        public string Documento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal Montototal { get; set; }
        public List<DetalleCompra> oListaDetalleCompra { get; set; }
        public string FechaDeRegistro { get; set; }

    }
}
