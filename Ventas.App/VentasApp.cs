using System.Collections.Generic;
using Ventas.Domain.Entities.Venta;
using Ventas.Domain.Repositories;
using Ventas.Domain.Services;
using Ventas.Domain.Test.Mocks;

namespace Ventas.App
{
    public class VentasApp
    {
        public List<Factura> ObtenerVentas() {
            List<Factura> facturas = new List<Factura>();
            IVentasRepository _ventasRepository = new VentasRepositoryMock();
            VentasService _ventasService = new VentasService();
            facturas = _ventasService.ObtenerFacturas(_ventasRepository);
            return facturas;
        }
    }
}
