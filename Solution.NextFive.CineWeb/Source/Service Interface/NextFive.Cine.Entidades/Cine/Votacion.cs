using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class Votacion
    {
        [DataMember]
        public int IdVotacion { get; set; }
        [DataMember]
        public Usuario Usuario { get; set; }
        [DataMember]
        public string IP { get; set; }
        [DataMember]
        public Peliculas Peliculas { get; set; }
        [DataMember]
        public string Comentario { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
    }
}
