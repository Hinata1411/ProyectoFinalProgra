using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Venta
    {
        public int IDVenta { get; set; }
        public Usuario oUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Documentocliente { get; set; }
        public string Nombrecliente { get; set; }
        public decimal Montopago { get; set; }
        public decimal Montocambio { get; set; }
        public decimal Montototal { get; set; }
        public List<Detalleventa> oListaDetalleventa { get; set; }
        public string FechaDeRegistro { get; set; }
    }
}
