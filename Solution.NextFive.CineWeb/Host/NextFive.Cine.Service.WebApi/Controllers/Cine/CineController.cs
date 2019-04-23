using NextFive.Cine.BusinessLogic.Implementation.Cine;
using NextFive.Cine.BusinessLogic.Interface.Cine;
using NextFive.Cine.Entidades.Cine;
using NextFive.Cine.Service.WebApi.Controllers.Base;
using System;
using System.Web.Http;
using System.Web.Http.Description;

namespace NextFive.Cine.Service.WebApi.Controllers.Cine
{
    public class CineController : BaseApiController
    {
        private CineBusinessLogic oCineBusinessLogic = new CineBusinessLogic();

        //public CineController(ICineBusinessLogic oICineBusinessLogic)
        //{
        //    this.oICineBusinessLogic = oICineBusinessLogic;
        //}

        [HttpGet]
        [ActionName("ListarPelicula")]
        [ResponseType(typeof(ListaPelicula))]
        [Route("api/Cine/ListarPelicula")]
        public IHttpActionResult ListarPelicula()   
        {
            ListaPelicula oListaPelicula = oCineBusinessLogic.ListarPelicula();
            return Ok(oListaPelicula);
        }

        [HttpPost]
        [ActionName("InsertarVotacion")]
        [ResponseType(typeof(RespuestaTransaccion))]
        [Route("api/Cine/InsertarVotacion")]
        public IHttpActionResult InsertarVotacion(byte[] contentData)
        {
            string str = Convert.ToBase64String(contentData);
            var data = this.JsonManager.CreateDataFromBase64String<Votacion>(str);
            var oRespuesta = oCineBusinessLogic.InsertarVotacion(data);
            return Ok(oRespuesta);
        }

        [HttpPost]
        [ActionName("InsertarVotacionTest")]
        [ResponseType(typeof(RespuestaTransaccion))]
        [Route("api/Cine/InsertarVotacionTest")]
        public IHttpActionResult InsertarVotacionTest(VotacionTest oVotacion)
        {
            Votacion ovot = new Votacion();
            ovot.Usuario = new Usuario();
            ovot.Usuario.IdUsuario = oVotacion.IdUsuario;
            ovot.Peliculas = new Peliculas();
            ovot.Peliculas.Nombre = oVotacion.Peliculas;
            ovot.IP = oVotacion.IP;
            ovot.Comentario = oVotacion.Comentario;
            var oRespuesta = oCineBusinessLogic.InsertarVotacion(ovot);
            return Ok(oRespuesta);
        }
    }
}