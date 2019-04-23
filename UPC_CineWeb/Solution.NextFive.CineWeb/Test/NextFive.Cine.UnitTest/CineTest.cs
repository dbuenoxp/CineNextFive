using Microsoft.VisualStudio.TestTools.UnitTesting;
using NextFive.Cine.DataAccess.Implementation.Cine;
using NextFive.Cine.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.UnitTest
{
    [TestClass]
    public class CineTest
    {
        public CineDataAccess oCineRepositorio = new CineDataAccess();

        [TestMethod]
        public void TestListarPeliculas()
        {
            ListaPelicula oListaPelicula = new ListaPelicula();
            oListaPelicula = oCineRepositorio.ListarPelicula();
            CollectionAssert.AllItemsAreNotNull(oListaPelicula);
        }

        [TestMethod]
        public void TestObtenerPeliculaAquaman()
        {
            ListaPelicula oListaPelicula = new ListaPelicula();
            oListaPelicula = oCineRepositorio.ListarPelicula();
            string nombre = oListaPelicula.Where(m => m.Nombre == "Aquaman").Select(m => m.Nombre).First().ToString();
            Assert.AreEqual(nombre, "Aquaman");
        }

        [TestMethod]
        public void TestRegistrarVotacion()
        {
            RespuestaTransaccion oResp = new RespuestaTransaccion();
            Votacion oVotacion = new Votacion();
            oVotacion.Peliculas = new Peliculas();
            oVotacion.Peliculas.Nombre = "La Monja";
            oVotacion.Comentario = "Muy Terrorifica, buena opción para volver a verlo";
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
            oResp = oCineRepositorio.InsertarVotacion(oVotacion);
            Assert.AreEqual("Usted ha votado por La Monja",oResp.MensajeTransaccion);
        }
    }
}
