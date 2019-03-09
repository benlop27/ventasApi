using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ventas.App;

namespace VentasAPI2.Controllers
{
    [RoutePrefix("api/Ventas")]
    public class VentasController : ApiController
    {
        [HttpGet]
        [Route("ObtenerFacturas")]
        public IHttpActionResult Obtener()
        {
            VentasApp app = new VentasApp();
            return Json(app.ObtenerVentas());

        }
    }
}