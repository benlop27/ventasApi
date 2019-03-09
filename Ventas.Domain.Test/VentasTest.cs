using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ventas.Domain.Entities;
using Ventas.Domain.Entities.Venta;
using Ventas.Domain.Repositories;
using Ventas.Domain.Services;
using Ventas.Domain.Test.Mocks;

namespace Ventas.Domain.Test
{
    [TestClass]
    public class VentasTest
    {
        [TestMethod]
        public void GenerarVenta()
        {
            //Arrange
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
            IVentasRepository _ventasRepository = new VentasRepositoryMock();
            VentasService _ventasService = new VentasService();

            //Act
            bool confirmacionVenta = _ventasService.GenerarVenta(_ventasRepository, _vendedor, _cliente, _compra);

            //Assert
            Assert.IsTrue(confirmacionVenta);
        }

        [TestMethod]
        public void ObtenerVenta()
        {
            //Arrange
            List<Factura> facturas = new List<Factura>();
            IVentasRepository _ventasRepository = new VentasRepositoryMock();
            VentasService _ventasService = new VentasService();

            //Act
            facturas = _ventasService.ObtenerFacturas(_ventasRepository);

            //Assert
            Assert.IsTrue(facturas.Count>0);
        }

    }
    }
