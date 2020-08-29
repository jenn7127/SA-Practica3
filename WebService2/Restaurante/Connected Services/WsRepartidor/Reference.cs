﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurante.WsRepartidor {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponse", Namespace="http://schemas.datacontract.org/2004/07/WebService2")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Restaurante.WsRepartidor.Orden))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Orden", Namespace="http://schemas.datacontract.org/2004/07/WebService2")]
    [System.SerializableAttribute()]
    public partial class Orden : Restaurante.WsRepartidor.BaseResponse {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WsRepartidor.IWSRepartidor")]
    public interface IWSRepartidor {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSRepartidor/ObtenerEstado", ReplyAction="http://tempuri.org/IWSRepartidor/ObtenerEstadoResponse")]
        Restaurante.WsRepartidor.Orden ObtenerEstado(int NoOrden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSRepartidor/ObtenerEstado", ReplyAction="http://tempuri.org/IWSRepartidor/ObtenerEstadoResponse")]
        System.Threading.Tasks.Task<Restaurante.WsRepartidor.Orden> ObtenerEstadoAsync(int NoOrden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSRepartidor/EnviarOrden", ReplyAction="http://tempuri.org/IWSRepartidor/EnviarOrdenResponse")]
        string EnviarOrden(int NoOrden);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSRepartidor/EnviarOrden", ReplyAction="http://tempuri.org/IWSRepartidor/EnviarOrdenResponse")]
        System.Threading.Tasks.Task<string> EnviarOrdenAsync(int NoOrden);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSRepartidorChannel : Restaurante.WsRepartidor.IWSRepartidor, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSRepartidorClient : System.ServiceModel.ClientBase<Restaurante.WsRepartidor.IWSRepartidor>, Restaurante.WsRepartidor.IWSRepartidor {
        
        public WSRepartidorClient() {
        }
        
        public WSRepartidorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSRepartidorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSRepartidorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSRepartidorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Restaurante.WsRepartidor.Orden ObtenerEstado(int NoOrden) {
            return base.Channel.ObtenerEstado(NoOrden);
        }
        
        public System.Threading.Tasks.Task<Restaurante.WsRepartidor.Orden> ObtenerEstadoAsync(int NoOrden) {
            return base.Channel.ObtenerEstadoAsync(NoOrden);
        }
        
        public string EnviarOrden(int NoOrden) {
            return base.Channel.EnviarOrden(NoOrden);
        }
        
        public System.Threading.Tasks.Task<string> EnviarOrdenAsync(int NoOrden) {
            return base.Channel.EnviarOrdenAsync(NoOrden);
        }
    }
}