using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Domain.Entities.Venta
{
    public class Producto
    {
        public int codigoProducto { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
    }
}
