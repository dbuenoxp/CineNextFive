using NextFive.Cine.ApiServiceController.Base;
using NextFive.Cine.ApiServiceController.Interface.Modulo.Cine;
using NextFive.Cine.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.ApiServiceController.Implementation.Modulo.Cine
{
    public class GestionCineApiServiceController : ApiClient, IGestionCineApiServiceController
    {
        public Dictionary<string, string> HttpData { get; set; }

        public GestionCineApiServiceController()
        {
            HttpData = new Dictionary<string, string>();
            HttpData.Add("URI", System.Configuration.ConfigurationManager.AppSettings["urlApiCine"]);
            HttpData.Add("ReqURI", "api/Cine/");
        }

        public ListaPelicula ListarPelicula()
        {
            ListaPelicula oLsta = this.CallService<ListaPelicula>(HttpData, HttpVerbs.GET, "ListarPelicula");
            return oLsta;
        }
        public RespuestaTransaccion InsertarVotacion(Votacion oVotacion)
        {
            RespuestaTransaccion oRespuesta = this.CallService<RespuestaTransaccion>(HttpData, HttpVerbs.POST,
                                                                                               "InsertarVotacion", oVotacion);
            return oRespuesta;
        }
    }
}
