﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWeb.Demo.MyUserService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyUserService.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserInfos", ReplyAction="http://tempuri.org/IUserService/GetUserInfosResponse")]
        MyWeb.Model.UserInfo[] GetUserInfos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserInfos", ReplyAction="http://tempuri.org/IUserService/GetUserInfosResponse")]
        System.Threading.Tasks.Task<MyWeb.Model.UserInfo[]> GetUserInfosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddUserInfo", ReplyAction="http://tempuri.org/IUserService/AddUserInfoResponse")]
        bool AddUserInfo(MyWeb.Model.UserInfo uInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/AddUserInfo", ReplyAction="http://tempuri.org/IUserService/AddUserInfoResponse")]
        System.Threading.Tasks.Task<bool> AddUserInfoAsync(MyWeb.Model.UserInfo uInfo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : MyWeb.Demo.MyUserService.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<MyWeb.Demo.MyUserService.IUserService>, MyWeb.Demo.MyUserService.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MyWeb.Model.UserInfo[] GetUserInfos() {
            return base.Channel.GetUserInfos();
        }
        
        public System.Threading.Tasks.Task<MyWeb.Model.UserInfo[]> GetUserInfosAsync() {
            return base.Channel.GetUserInfosAsync();
        }
        
        public bool AddUserInfo(MyWeb.Model.UserInfo uInfo) {
            return base.Channel.AddUserInfo(uInfo);
        }
        
        public System.Threading.Tasks.Task<bool> AddUserInfoAsync(MyWeb.Model.UserInfo uInfo) {
            return base.Channel.AddUserInfoAsync(uInfo);
        }
    }
}
