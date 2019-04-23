
using NextFive.Cine.ApiServiceController.Implementation.Modulo.Cine;
using NextFive.Cine.ApiServiceController.Interface.Modulo.Cine;
using NextFive.Cine.Entidades.Cine;
using NextFive.Cine.ServiceController.Implementation.Cine;
using NextFive.Cine.ServiceController.Interface.Cine;
using Solution.NextFive.CineWeb.Controllers.Base;
using Solution.NextFive.CineWeb.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;

namespace Solution.NextFive.CineWeb.Controllers
{
    public class CineController : Controller
    {
        // GET: Cine
        //private readonly IGestionCineApiServiceController oIGestionCineApiServiceController;
       public GestionCineApiServiceController oGestionCineApiServiceController = new GestionCineApiServiceController();
        //public CineController(IGestionCineApiServiceController oIGestionCineApiServiceController)
        //{
        //    this.oIGestionCineApiServiceController = oIGestionCineApiServiceController;
        //}
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Principal()
        {
            return View();
        }
        public ActionResult Votaciones()
         {
           
           ListaPelicula oListaPelicula = new ListaPelicula();
           oListaPelicula = oGestionCineApiServiceController.ListarPelicula();

            return View();
        }

        [HttpPost()]
        public ActionResult setVotaciones(String Pelicula, String Comentario)
        {
            String Result = String.Empty;
            RespuestaTransaccion oResp = new RespuestaTransaccion();
            Votacion oVotacion = new Votacion();
            oVotacion.Peliculas = new Peliculas();
            oVotacion.Peliculas.Nombre = Pelicula;
            oVotacion.Comentario = Comentario;
            oVotacion.Usuario = new Usuario();
            oVotacion.Usuario.IdUsuario = 0;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                  oVotacion.IP = ip.ToString();
                  break;
                }
            }
            oResp = oGestionCineApiServiceController.InsertarVotacion(oVotacion);
            Result = oResp.IdTransaccion.ToString();
            return Content(Result);
        }
        public ActionResult Comprauno()
        {
            return View();
        }
        public ActionResult CompraDos()
        {
            return View();
        }
        public ActionResult CompraTres()
        {
            return View();
        }
        public ActionResult CompraCuatro()
        {
            return View();
        }
        //prueba de subida
        public ActionResult Registro()
        {
            return View();
        }
    }
}