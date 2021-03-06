﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineServices
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name = "ListaPelicula", Namespace = "http://schemas.datacontract.org/2004/07/NextFive.Cine.Entidades.Cine", ItemName = "Peliculas")]
    public class ListaPelicula : System.Collections.Generic.List<CineServices.Peliculas>
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Peliculas", Namespace = "http://schemas.datacontract.org/2004/07/NextFive.Cine.Entidades.Cine")]
    public partial class Peliculas : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private bool CarteleraField;

        private CineServices.Categoria CategoriaField;

        private string DescripcionField;

        private string DuracionField;

        private System.DateTime FechaFinCarteleraField;

        private System.DateTime FechaInicioCarteleraField;

        private int IdPeliculaField;

        private string NombreField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Cartelera
        {
            get
            {
                return this.CarteleraField;
            }
            set
            {
                this.CarteleraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CineServices.Categoria Categoria
        {
            get
            {
                return this.CategoriaField;
            }
            set
            {
                this.CategoriaField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion
        {
            get
            {
                return this.DescripcionField;
            }
            set
            {
                this.DescripcionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Duracion
        {
            get
            {
                return this.DuracionField;
            }
            set
            {
                this.DuracionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaFinCartelera
        {
            get
            {
                return this.FechaFinCarteleraField;
            }
            set
            {
                this.FechaFinCarteleraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaInicioCartelera
        {
            get
            {
                return this.FechaInicioCarteleraField;
            }
            set
            {
                this.FechaInicioCarteleraField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPelicula
        {
            get
            {
                return this.IdPeliculaField;
            }
            set
            {
                this.IdPeliculaField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre
        {
            get
            {
                return this.NombreField;
            }
            set
            {
                this.NombreField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Categoria", Namespace = "http://schemas.datacontract.org/2004/07/NextFive.Cine.Entidades.Cine")]
    public partial class Categoria : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string DescripcionField;

        private int IdCategoriaField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion
        {
            get
            {
                return this.DescripcionField;
            }
            set
            {
                this.DescripcionField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCategoria
        {
            get
            {
                return this.IdCategoriaField;
            }
            set
            {
                this.IdCategoriaField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "CineServices.ICineService")]
    public interface ICineService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICineService/ListarPelicula", ReplyAction = "http://tempuri.org/ICineService/ListarPeliculaResponse")]
        CineServices.ListaPelicula ListarPelicula();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICineService/ListarPelicula", ReplyAction = "http://tempuri.org/ICineService/ListarPeliculaResponse")]
        System.Threading.Tasks.Task<CineServices.ListaPelicula> ListarPeliculaAsync();
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICineServiceChannel : CineServices.ICineService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CineServiceClient : System.ServiceModel.ClientBase<CineServices.ICineService>, CineServices.ICineService
    {

        public CineServiceClient()
        {
        }

        public CineServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public CineServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public CineServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public CineServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public CineServices.ListaPelicula ListarPelicula()
        {
            return base.Channel.ListarPelicula();
        }

        public System.Threading.Tasks.Task<CineServices.ListaPelicula> ListarPeliculaAsync()
        {
            return base.Channel.ListarPeliculaAsync();
        }
    }
}
