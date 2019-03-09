using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Domain.Entities.Venta;
using Ventas.Domain.Repositories;

namespace Ventas.Domain.Services
{
    public class VentasService
    {
        public bool GenerarVenta(IVentasRepository _ventasRepository, Vendedor _vendedor, Cliente _cliente, List<Producto> _compra) {
            bool estado = false;
            if (_vendedor.nombre != "Yo") {
              estado =  _ventasRepository.GenerarVenta(_vendedor, _cliente, _compra);

            }
            return estado;
        } 
        public List<Factura> ObtenerFacturas(IVentasRepository _ventasRepository) {
            return _ventasRepository.ObtenerFacturas();
        }
    }
}
