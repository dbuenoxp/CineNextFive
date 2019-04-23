using NextFive.Cine.BusinessLogic.Interface.Cine;
using NextFive.Cine.DataAccess.Implementation.Cine;
using NextFive.Cine.DataAccess.Interface.Cine;
using NextFive.Cine.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.BusinessLogic.Implementation.Cine
{
    public class CineBusinessLogic //: ICineBusinessLogic
    {
        //private readonly ICineDataAccess oICineDataAccess;
        //public CineBusinessLogic(ICineDataAccess oICineDataAccess)
        //{
        //    this.oICineDataAccess = oICineDataAccess;
        //}
        public ListaPelicula ListarPelicula()
        {
            return new CineDataAccess().ListarPelicula();
        }
        public RespuestaTransaccion InsertarVotacion(Votacion oVotacion)
        {
            return new CineDataAccess().InsertarVotacion(oVotacion);
        }
    }
}
