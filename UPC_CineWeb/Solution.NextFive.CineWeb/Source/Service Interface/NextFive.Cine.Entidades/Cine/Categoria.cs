using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class Categoria
    {
        [DataMember]
        public int IdCategoria { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
