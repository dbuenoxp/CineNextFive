using NextFive.Cine.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.DataAccess.Interface.Cine
{
    public interface ICineDataAccess
    {
        ListaPelicula ListarPelicula();
    }
}
