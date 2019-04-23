using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class RespuestaTransaccion
    {
        [DataMember]
        public int IdTransaccion { get; set; }

        [DataMember]
        public string CodigoTransaccion { get; set; }

        [DataMember]
        public string MensajeTransaccion { get; set; }
    }
}
