using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class VotacionTest
    {
        [DataMember]
        public int IdVotacion { get; set; }
        [DataMember]
        public int IdUsuario { get; set; }
        [DataMember]
        public string IP { get; set; }
        [DataMember]
        public string Peliculas { get; set; }
        [DataMember]
        public string Comentario { get; set; }
    }
}
