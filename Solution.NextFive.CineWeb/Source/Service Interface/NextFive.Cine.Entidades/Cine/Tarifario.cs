using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class Tarifario
    {
        [DataMember]
        public int Idtarifario{ get; set; }
        [DataMember]
        public decimal Precio { get; set; }
        [DataMember]

        public int Rango { get; set; }
        [DataMember]
        public int Porcentaje { get; set; }
        //Para los comentarios dfhjj
    }
}
