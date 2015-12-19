﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacaoWeb.IMCService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultadoIMC", Namespace="http://schemas.datacontract.org/2004/07/AplicacaoWCF")]
    [System.SerializableAttribute()]
    public partial class ResultadoIMC : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AlturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescSituacaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PesoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorIMCField;
        
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
        public double Altura {
            get {
                return this.AlturaField;
            }
            set {
                if ((this.AlturaField.Equals(value) != true)) {
                    this.AlturaField = value;
                    this.RaisePropertyChanged("Altura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescSituacao {
            get {
                return this.DescSituacaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescSituacaoField, value) != true)) {
                    this.DescSituacaoField = value;
                    this.RaisePropertyChanged("DescSituacao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Peso {
            get {
                return this.PesoField;
            }
            set {
                if ((this.PesoField.Equals(value) != true)) {
                    this.PesoField = value;
                    this.RaisePropertyChanged("Peso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ValorIMC {
            get {
                return this.ValorIMCField;
            }
            set {
                if ((this.ValorIMCField.Equals(value) != true)) {
                    this.ValorIMCField = value;
                    this.RaisePropertyChanged("ValorIMC");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMCService.IIMCService")]
    public interface IIMCService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIMCService/CalcularIMC", ReplyAction="http://tempuri.org/IIMCService/CalcularIMCResponse")]
        AplicacaoWeb.IMCService.ResultadoIMC CalcularIMC(double peso, double altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIMCService/CalcularIMC", ReplyAction="http://tempuri.org/IIMCService/CalcularIMCResponse")]
        System.Threading.Tasks.Task<AplicacaoWeb.IMCService.ResultadoIMC> CalcularIMCAsync(double peso, double altura);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIMCServiceChannel : AplicacaoWeb.IMCService.IIMCService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IMCServiceClient : System.ServiceModel.ClientBase<AplicacaoWeb.IMCService.IIMCService>, AplicacaoWeb.IMCService.IIMCService {
        
        public IMCServiceClient() {
        }
        
        public IMCServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IMCServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IMCServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IMCServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AplicacaoWeb.IMCService.ResultadoIMC CalcularIMC(double peso, double altura) {
            return base.Channel.CalcularIMC(peso, altura);
        }
        
        public System.Threading.Tasks.Task<AplicacaoWeb.IMCService.ResultadoIMC> CalcularIMCAsync(double peso, double altura) {
            return base.Channel.CalcularIMCAsync(peso, altura);
        }
    }
}
