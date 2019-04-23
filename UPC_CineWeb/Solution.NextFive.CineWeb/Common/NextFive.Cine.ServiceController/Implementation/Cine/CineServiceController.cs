using CineServices;
using NextFive.Cine.ServiceController.Interface.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.ServiceController.Implementation.Cine
{
    public class CineServiceController //: ICineServiceController
    {
        //private readonly CineServices.ICineService oICineService;
        public CineServiceController()
        {
           // oICineService = new CineServiceClient();
        }

        private static CineServiceController _Instancia;

        public static CineServiceController Instancia
        {
            get { return _Instancia ?? (_Instancia = new CineServiceController()); }
        }
        public ListaPelicula ListarPelicula()
        {
            using (CineServiceClient client = new CineServiceClient())
            {
                return client.ListarPelicula();
            }
        }
    }
}
