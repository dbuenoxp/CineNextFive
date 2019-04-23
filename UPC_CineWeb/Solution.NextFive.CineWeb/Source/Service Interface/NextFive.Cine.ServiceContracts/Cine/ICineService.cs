using NextFive.Cine.Entidades.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.ServiceContracts.Cine
{
    [ServiceContract]
    public interface ICineService
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "http://NextFive.Cine.ServiceContracts/Cine/CineService/ListarPelicula", ProtectionLevel = ProtectionLevel.None)]
        ListaPelicula ListarPelicula();
    }
}
