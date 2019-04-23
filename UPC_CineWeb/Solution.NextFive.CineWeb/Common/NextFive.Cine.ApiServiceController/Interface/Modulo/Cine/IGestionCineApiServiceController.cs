using NextFive.Cine.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.ApiServiceController.Interface.Modulo.Cine
{
    public interface IGestionCineApiServiceController 
    {
        ListaPelicula ListarPelicula();
    }
}
