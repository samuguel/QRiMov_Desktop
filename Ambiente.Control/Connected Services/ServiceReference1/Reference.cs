﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ambiente.Control.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="FAAT", ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="FAAT/GetDataSet", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetDataSet(string pSQL, string pBase);
        
        [System.ServiceModel.OperationContractAttribute(Action="FAAT/GetDataSet", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDataSetAsync(string pSQL, string pBase);
        
        [System.ServiceModel.OperationContractAttribute(Action="FAAT/ExecuteNonQuery", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ExecuteNonQuery(string pSQL, string pBase);
        
        [System.ServiceModel.OperationContractAttribute(Action="FAAT/ExecuteNonQuery", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ExecuteNonQueryAsync(string pSQL, string pBase);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Ambiente.Control.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Ambiente.Control.ServiceReference1.WebService1Soap>, Ambiente.Control.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetDataSet(string pSQL, string pBase) {
            return base.Channel.GetDataSet(pSQL, pBase);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDataSetAsync(string pSQL, string pBase) {
            return base.Channel.GetDataSetAsync(pSQL, pBase);
        }
        
        public bool ExecuteNonQuery(string pSQL, string pBase) {
            return base.Channel.ExecuteNonQuery(pSQL, pBase);
        }
        
        public System.Threading.Tasks.Task<bool> ExecuteNonQueryAsync(string pSQL, string pBase) {
            return base.Channel.ExecuteNonQueryAsync(pSQL, pBase);
        }
    }
}
