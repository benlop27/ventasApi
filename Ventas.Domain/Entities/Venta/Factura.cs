using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Domain.Entities.Venta
{
   public class Factura
    {
        public int codigoFactura { get; set; }
        public Vendedor vendedor { get; set; }
        public Cliente cliente { get; set; }
        public List<Producto> compra { get; set; }
    }
}
