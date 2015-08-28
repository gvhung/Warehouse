﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse.ServiceClient.WarehouseService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ObjectId", Namespace="http://schemas.datacontract.org/2004/07/MongoDB.Bson")]
    [System.SerializableAttribute()]
    public partial struct ObjectId : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int _incrementField;
        
        private int _machineField;
        
        private short _pidField;
        
        private int _timestampField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _increment {
            get {
                return this._incrementField;
            }
            set {
                if ((this._incrementField.Equals(value) != true)) {
                    this._incrementField = value;
                    this.RaisePropertyChanged("_increment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _machine {
            get {
                return this._machineField;
            }
            set {
                if ((this._machineField.Equals(value) != true)) {
                    this._machineField = value;
                    this.RaisePropertyChanged("_machine");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short _pid {
            get {
                return this._pidField;
            }
            set {
                if ((this._pidField.Equals(value) != true)) {
                    this._pidField = value;
                    this.RaisePropertyChanged("_pid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int _timestamp {
            get {
                return this._timestampField;
            }
            set {
                if ((this._timestampField.Equals(value) != true)) {
                    this._timestampField = value;
                    this.RaisePropertyChanged("_timestamp");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Ping", ReplyAction="http://tempuri.org/IService/PingResponse")]
        int Ping(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Ping", ReplyAction="http://tempuri.org/IService/PingResponse")]
        System.Threading.Tasks.Task<int> PingAsync(System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Warehouse.ServiceClient.WarehouseService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.IService>, Warehouse.ServiceClient.WarehouseService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Ping(System.DateTime date) {
            return base.Channel.Ping(date);
        }
        
        public System.Threading.Tasks.Task<int> PingAsync(System.DateTime date) {
            return base.Channel.PingAsync(date);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IProduct")]
    public interface IProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/AddProduct", ReplyAction="http://tempuri.org/IProduct/AddProductResponse")]
        bool AddProduct(Warehouse.Data.Dto.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/AddProduct", ReplyAction="http://tempuri.org/IProduct/AddProductResponse")]
        System.Threading.Tasks.Task<bool> AddProductAsync(Warehouse.Data.Dto.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/UpdateProduct", ReplyAction="http://tempuri.org/IProduct/UpdateProductResponse")]
        bool UpdateProduct(Warehouse.Data.Dto.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/UpdateProduct", ReplyAction="http://tempuri.org/IProduct/UpdateProductResponse")]
        System.Threading.Tasks.Task<bool> UpdateProductAsync(Warehouse.Data.Dto.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProducts", ReplyAction="http://tempuri.org/IProduct/GetProductsResponse")]
        Warehouse.Data.Dto.Product[] GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProducts", ReplyAction="http://tempuri.org/IProduct/GetProductsResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Product[]> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProduct", ReplyAction="http://tempuri.org/IProduct/GetProductResponse")]
        Warehouse.Data.Dto.Product GetProduct(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetProduct", ReplyAction="http://tempuri.org/IProduct/GetProductResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Product> GetProductAsync(string productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductChannel : Warehouse.ServiceClient.WarehouseService.IProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.IProduct>, Warehouse.ServiceClient.WarehouseService.IProduct {
        
        public ProductClient() {
        }
        
        public ProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddProduct(Warehouse.Data.Dto.Product product) {
            return base.Channel.AddProduct(product);
        }
        
        public System.Threading.Tasks.Task<bool> AddProductAsync(Warehouse.Data.Dto.Product product) {
            return base.Channel.AddProductAsync(product);
        }
        
        public bool UpdateProduct(Warehouse.Data.Dto.Product product) {
            return base.Channel.UpdateProduct(product);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateProductAsync(Warehouse.Data.Dto.Product product) {
            return base.Channel.UpdateProductAsync(product);
        }
        
        public Warehouse.Data.Dto.Product[] GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Product[]> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public Warehouse.Data.Dto.Product GetProduct(string productId) {
            return base.Channel.GetProduct(productId);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Product> GetProductAsync(string productId) {
            return base.Channel.GetProductAsync(productId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IWarehouseSocet")]
    public interface IWarehouseSocet {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/AddWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/AddWarehouseSocetResponse")]
        bool AddWarehouseSocet(Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/AddWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/AddWarehouseSocetResponse")]
        System.Threading.Tasks.Task<bool> AddWarehouseSocetAsync(Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/UpdateWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/UpdateWarehouseSocetResponse")]
        bool UpdateWarehouseSocet(Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/UpdateWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/UpdateWarehouseSocetResponse")]
        System.Threading.Tasks.Task<bool> UpdateWarehouseSocetAsync(Warehouse.Data.Dto.WarehouseSocet socet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetWarehouseSocets", ReplyAction="http://tempuri.org/IWarehouseSocet/GetWarehouseSocetsResponse")]
        Warehouse.Data.Dto.WarehouseSocet[] GetWarehouseSocets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetWarehouseSocets", ReplyAction="http://tempuri.org/IWarehouseSocet/GetWarehouseSocetsResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet[]> GetWarehouseSocetsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/GetWarehouseSocetResponse")]
        Warehouse.Data.Dto.WarehouseSocet GetWarehouseSocet(string socetId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWarehouseSocet/GetWarehouseSocet", ReplyAction="http://tempuri.org/IWarehouseSocet/GetWarehouseSocetResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet> GetWarehouseSocetAsync(string socetId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWarehouseSocetChannel : Warehouse.ServiceClient.WarehouseService.IWarehouseSocet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WarehouseSocetClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.IWarehouseSocet>, Warehouse.ServiceClient.WarehouseService.IWarehouseSocet {
        
        public WarehouseSocetClient() {
        }
        
        public WarehouseSocetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WarehouseSocetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseSocetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseSocetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddWarehouseSocet(Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.AddWarehouseSocet(socet);
        }
        
        public System.Threading.Tasks.Task<bool> AddWarehouseSocetAsync(Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.AddWarehouseSocetAsync(socet);
        }
        
        public bool UpdateWarehouseSocet(Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.UpdateWarehouseSocet(socet);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateWarehouseSocetAsync(Warehouse.Data.Dto.WarehouseSocet socet) {
            return base.Channel.UpdateWarehouseSocetAsync(socet);
        }
        
        public Warehouse.Data.Dto.WarehouseSocet[] GetWarehouseSocets() {
            return base.Channel.GetWarehouseSocets();
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet[]> GetWarehouseSocetsAsync() {
            return base.Channel.GetWarehouseSocetsAsync();
        }
        
        public Warehouse.Data.Dto.WarehouseSocet GetWarehouseSocet(string socetId) {
            return base.Channel.GetWarehouseSocet(socetId);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.WarehouseSocet> GetWarehouseSocetAsync(string socetId) {
            return base.Channel.GetWarehouseSocetAsync(socetId);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IPackage")]
    public interface IPackage {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/AddPackage", ReplyAction="http://tempuri.org/IPackage/AddPackageResponse")]
        bool AddPackage(Warehouse.Data.Dto.Package product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/AddPackage", ReplyAction="http://tempuri.org/IPackage/AddPackageResponse")]
        System.Threading.Tasks.Task<bool> AddPackageAsync(Warehouse.Data.Dto.Package product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/UpdatePackage", ReplyAction="http://tempuri.org/IPackage/UpdatePackageResponse")]
        bool UpdatePackage(Warehouse.Data.Dto.Package product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/UpdatePackage", ReplyAction="http://tempuri.org/IPackage/UpdatePackageResponse")]
        System.Threading.Tasks.Task<bool> UpdatePackageAsync(Warehouse.Data.Dto.Package product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/GetPackages", ReplyAction="http://tempuri.org/IPackage/GetPackagesResponse")]
        Warehouse.Data.Dto.Package[] GetPackages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/GetPackages", ReplyAction="http://tempuri.org/IPackage/GetPackagesResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Package[]> GetPackagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/GetPackage", ReplyAction="http://tempuri.org/IPackage/GetPackageResponse")]
        Warehouse.Data.Dto.Package GetPackage(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPackage/GetPackage", ReplyAction="http://tempuri.org/IPackage/GetPackageResponse")]
        System.Threading.Tasks.Task<Warehouse.Data.Dto.Package> GetPackageAsync(string productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPackageChannel : Warehouse.ServiceClient.WarehouseService.IPackage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PackageClient : System.ServiceModel.ClientBase<Warehouse.ServiceClient.WarehouseService.IPackage>, Warehouse.ServiceClient.WarehouseService.IPackage {
        
        public PackageClient() {
        }
        
        public PackageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PackageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PackageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PackageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddPackage(Warehouse.Data.Dto.Package product) {
            return base.Channel.AddPackage(product);
        }
        
        public System.Threading.Tasks.Task<bool> AddPackageAsync(Warehouse.Data.Dto.Package product) {
            return base.Channel.AddPackageAsync(product);
        }
        
        public bool UpdatePackage(Warehouse.Data.Dto.Package product) {
            return base.Channel.UpdatePackage(product);
        }
        
        public System.Threading.Tasks.Task<bool> UpdatePackageAsync(Warehouse.Data.Dto.Package product) {
            return base.Channel.UpdatePackageAsync(product);
        }
        
        public Warehouse.Data.Dto.Package[] GetPackages() {
            return base.Channel.GetPackages();
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Package[]> GetPackagesAsync() {
            return base.Channel.GetPackagesAsync();
        }
        
        public Warehouse.Data.Dto.Package GetPackage(string productId) {
            return base.Channel.GetPackage(productId);
        }
        
        public System.Threading.Tasks.Task<Warehouse.Data.Dto.Package> GetPackageAsync(string productId) {
            return base.Channel.GetPackageAsync(productId);
        }
    }
}