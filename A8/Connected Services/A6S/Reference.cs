﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A8.A6S {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="A6S.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Data", ReplyAction="http://tempuri.org/IService1/DataResponse")]
        string Data(string values, string op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Data", ReplyAction="http://tempuri.org/IService1/DataResponse")]
        System.Threading.Tasks.Task<string> DataAsync(string values, string op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Math", ReplyAction="http://tempuri.org/IService1/MathResponse")]
        string Math(string op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Math", ReplyAction="http://tempuri.org/IService1/MathResponse")]
        System.Threading.Tasks.Task<string> MathAsync(string op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ExportResult", ReplyAction="http://tempuri.org/IService1/ExportResultResponse")]
        string ExportResult(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ExportResult", ReplyAction="http://tempuri.org/IService1/ExportResultResponse")]
        System.Threading.Tasks.Task<string> ExportResultAsync(string fileName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : A8.A6S.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<A8.A6S.IService1>, A8.A6S.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Data(string values, string op) {
            return base.Channel.Data(values, op);
        }
        
        public System.Threading.Tasks.Task<string> DataAsync(string values, string op) {
            return base.Channel.DataAsync(values, op);
        }
        
        public string Math(string op) {
            return base.Channel.Math(op);
        }
        
        public System.Threading.Tasks.Task<string> MathAsync(string op) {
            return base.Channel.MathAsync(op);
        }
        
        public string ExportResult(string fileName) {
            return base.Channel.ExportResult(fileName);
        }
        
        public System.Threading.Tasks.Task<string> ExportResultAsync(string fileName) {
            return base.Channel.ExportResultAsync(fileName);
        }
    }
}
