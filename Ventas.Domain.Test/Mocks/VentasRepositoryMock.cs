using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Domain.Entities;
using Ventas.Domain.Entities.Venta;
using Ventas.Domain.Repositories;

namespace Ventas.Domain.Test.Mocks
{
    public class VentasRepositoryMock : IVentasRepository
    {
        public bool GenerarVenta(Vendedor vendedor, Cliente cliente, List<Producto> _compra)
        {
            List<Factura> facturas = new List<Factura>();
            bool estado = false;
            try
            {
                facturas.Add(new Factura()
                {
                    cliente = cliente,
                    vendedor = vendedor,
                    codigoFactura = 1,
                    compra = _compra
                });
                Console.WriteLine(facturas.Count);
                estado = true;
            }
            catch (Exception e) {

            }
            return estado;
        }

        public List<Factura> ObtenerFacturas() {

            List<Factura> facturas = new List<Factura>();
            Vendedor _vendedor = new Vendedor();
            _vendedor.nombre = "Benjamin";
            Cliente _cliente = new Cliente();
            _cliente.nombre = "Gabriela";
            List<Producto> _compra = new List<Producto>() {
                new Producto(){
                    nombre="Galleta Algo",
                    precio = 1
                },
                new Producto(){
                    nombre = "Paleta Magnum",
                    precio=2
                },
                new Producto(){
                    nombre="Gaseosa Kolashampan",
                    precio=1
                }
            };
            facturas.Add(new Factura()
            {
                cliente = _cliente,
                vendedor = _vendedor,
                codigoFactura = 1,
                compra = _compra
            });

            return facturas;
        }
    }
}
