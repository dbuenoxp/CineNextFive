using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class AsientosXEntradas
    {
        [DataMember]
        public int IdAsientoEntrada { get; set; }
        [DataMember]
        public Entrada Entrada { get; set; }
        [DataMember]
        public Fila Fila { get; set; }
    }
}
