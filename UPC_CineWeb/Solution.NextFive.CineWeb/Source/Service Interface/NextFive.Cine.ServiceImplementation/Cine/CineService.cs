using NextFive.Cine.BusinessLogic.Implementation.Cine;
using NextFive.Cine.BusinessLogic.Interface.Cine;
using NextFive.Cine.Entidades.Cine;
using NextFive.Cine.ServiceContracts.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.ServiceImplementation.Cine
{
    public class CineService : ICineService
    {
        //private readonly ICineBusinessLogic oICineBusinessLogic;

        //public CineService(ICineBusinessLogic oICineBusinessLogic)
        //{
        //    this.oICineBusinessLogic = oICineBusinessLogic;
        //}

        public ListaPelicula ListarPelicula()
        {
            return new CineBusinessLogic().ListarPelicula();
        }
    }
}
