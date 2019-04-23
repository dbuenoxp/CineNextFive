using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class Entrada
    {
        [DataMember]
        public int IdEntrada { get; set; }
        [DataMember]
        public Usuario Usuario { get; set; }
        [DataMember]
        public Peliculas Pelicula { get; set; }
        [DataMember]
        public decimal Precio { get; set; }
        [DataMember]
        public Salas Sala { get; set; }
        [DataMember]
        public int Cantidad { get; set; }
        [DataMember]
        public DateTime FechaRegistro { get; set; }
        [DataMember]
        public int PuntosConsumidos { get; set; }
        [DataMember]
        public int PuntosObtenidos { get; set; }
    }
}
