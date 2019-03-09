using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Domain.Entities.Venta;

namespace Ventas.Domain.Repositories
{
    public interface IVentasRepository
    {
        bool GenerarVenta(Vendedor vendedor, Cliente cliente, List<Producto> _compra);
        List<Factura> ObtenerFacturas();
    }
}
