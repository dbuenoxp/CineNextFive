using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class Peliculas
    {
        [DataMember]
        public int IdPelicula { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string Duracion { get; set; }
        [DataMember]
        public Categoria Categoria { get; set; }
        [DataMember]
        public bool Cartelera { get; set; }
        [DataMember]
        public DateTime FechaInicioCartelera { get; set; }
        [DataMember]
        public DateTime FechaFinCartelera { get; set; }
    }
}
