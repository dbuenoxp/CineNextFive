using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class Salas
    {
        [DataMember]
        public int IdSalas { get; set; }
        [DataMember]
        public string NumeroSala { get; set; }
        [DataMember]
        public TimeSpan Hoario { get; set; }
    }
}
