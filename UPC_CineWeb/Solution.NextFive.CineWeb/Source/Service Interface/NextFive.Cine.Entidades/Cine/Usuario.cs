using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Entidades.Cine
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int IdUsuario { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
        [DataMember]
        public string DNI { get; set; }
        [DataMember]
        public DateTime FechaCumpleanios { get; set; }
        [DataMember]
        public int Puntos { get; set; }
    }
}
