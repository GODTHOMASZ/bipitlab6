﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Data.DataTable GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboValue", ReplyAction="http://tempuri.org/IService1/GetComboValueResponse")]
        System.Data.DataTable GetComboValue();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboValue", ReplyAction="http://tempuri.org/IService1/GetComboValueResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetComboValueAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewRec", ReplyAction="http://tempuri.org/IService1/NewRecResponse")]
        void NewRec(string cname, string service, string count, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NewRec", ReplyAction="http://tempuri.org/IService1/NewRecResponse")]
        System.Threading.Tasks.Task NewRecAsync(string cname, string service, string count, string date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Client.ServiceReference1.IService1>, Client.ServiceReference1.IService1 {
        
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
        
        public System.Data.DataTable GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public System.Data.DataTable GetComboValue() {
            return base.Channel.GetComboValue();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetComboValueAsync() {
            return base.Channel.GetComboValueAsync();
        }
        
        public void NewRec(string cname, string service, string count, string date) {
            base.Channel.NewRec(cname, service, count, date);
        }
        
        public System.Threading.Tasks.Task NewRecAsync(string cname, string service, string count, string date) {
            return base.Channel.NewRecAsync(cname, service, count, date);
        }
    }
}
