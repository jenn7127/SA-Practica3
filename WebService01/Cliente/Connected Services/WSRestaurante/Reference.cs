﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente.WSRestaurante {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponse", Namespace="http://schemas.datacontract.org/2004/07/WebService1")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Cliente.WSRestaurante.Orden))]
    public partial class BaseResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Orden", Namespace="http://schemas.datacontract.org/2004/07/WebService1")]
    [System.SerializableAttribute()]
    public partial class Orden : Cliente.WSRestaurante.BaseResponse {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string estadoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string estado {
            get {
                return this.estadoField;
            }
            set {
                if ((object.ReferenceEquals(this.estadoField, value) != true)) {
                    this.estadoField = value;
                    this.RaisePropertyChanged("estado");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSRestaurante.IWSRestaurante")]
    public interface IWSRestaurante {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSRestaurante/ObtenerEstado", ReplyAction="http://tempuri.org/IWSRestaurante/ObtenerEstadoResponse")]
        Cliente.WSRestaurante.Orden ObtenerEstado(int NoOrden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSRestaurante/ObtenerEstado", ReplyAction="http://tempuri.org/IWSRestaurante/ObtenerEstadoResponse")]
        System.Threading.Tasks.Task<Cliente.WSRestaurante.Orden> ObtenerEstadoAsync(int NoOrden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSRestaurante/CrearOrden", ReplyAction="http://tempuri.org/IWSRestaurante/CrearOrdenResponse")]
        string CrearOrden();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSRestaurante/CrearOrden", ReplyAction="http://tempuri.org/IWSRestaurante/CrearOrdenResponse")]
        System.Threading.Tasks.Task<string> CrearOrdenAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSRestauranteChannel : Cliente.WSRestaurante.IWSRestaurante, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSRestauranteClient : System.ServiceModel.ClientBase<Cliente.WSRestaurante.IWSRestaurante>, Cliente.WSRestaurante.IWSRestaurante {
        
        public WSRestauranteClient() {
        }
        
        public WSRestauranteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSRestauranteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSRestauranteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSRestauranteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Cliente.WSRestaurante.Orden ObtenerEstado(int NoOrden) {
            return base.Channel.ObtenerEstado(NoOrden);
        }
        
        public System.Threading.Tasks.Task<Cliente.WSRestaurante.Orden> ObtenerEstadoAsync(int NoOrden) {
            return base.Channel.ObtenerEstadoAsync(NoOrden);
        }
        
        public string CrearOrden() {
            return base.Channel.CrearOrden();
        }
        
        public System.Threading.Tasks.Task<string> CrearOrdenAsync() {
            return base.Channel.CrearOrdenAsync();
        }
    }
}
