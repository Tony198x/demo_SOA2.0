﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleHelloWorldService
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using CServiceStack.ProtoBuf;
    using CServiceStack.ServiceHost;
    using CServiceStack.Common.Types;
    
    
    /// <summary>
    /// Sample helloworld request
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("HelloRequest", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [ProtoContract()]
    public partial class HelloRequestType
    {
        
        private string nameField;
        
        /// <summary>
        /// If provided, service will response with Hello 'Name'.
        /// </summary>
        [ProtoMember(1)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <summary>
    /// Sample helloworld response
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soa.ctrip.com/framework/soa/sample/v1")]
    [System.Xml.Serialization.XmlRootAttribute("HelloResponse", Namespace="http://soa.ctrip.com/framework/soa/sample/v1", IsNullable=false)]
    [ProtoContract()]
    public partial class HelloResponseType : IHasResponseStatus
    {
        
        private ResponseStatusType responseStatusField;
        
        private string resultField;
        
        [ProtoMember(1)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
        
        /// <summary>
        /// HelloWorld response result
        /// </summary>
        [ProtoMember(2)]
        public string Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }
    
    /// <summary>
    /// Service interface auto-generated by SOA tool, DO NOT CHANGE!
    /// 
    /// 注意，实现该接口的服务在CServiceStack服务容器中是以new instance per request的形式被初始化的，
    /// 也就是说，容器会为每个请求创建一个新的服务实例，并在请求结束时释放(release)，而不是单个
    /// 服务实例(singleton)服务所有的请求, 所以请务必不要在服务初始化（例如构造函数中）时做较重的初始化
    /// （例如初始化数据库等）动作，否则对性能有很大影响，如果有较重的初始化动作，
    /// 请在服务实现中以静态方式（例如静态构造函数中)一次性完成，或者以IoC注入方式初始化，在服务容器
    /// 启动时事先将依赖初始化并注册在容器中，让容器在构造服务实例时自动解析和注入依赖(也可在服务实现中手动解析依赖)，
    /// 关于静态和依赖注入初始化的样例，请参考CServiceStack提供的样例程序.
    /// 
    /// A hello world like sample demonstrating the usage of CServiceStack
    /// </summary>
    [CServiceInterface("HelloWorldService", "http://soa.ctrip.com/framework/soa/sample/v1", "2.0.2.2")]
    public interface IHelloWorldService
    {
        
        /// <summary>
        /// helloworld test
        /// </summary>
        HelloResponseType Hello(HelloRequestType request);
        
        CheckHealthResponseType CheckHealth(CheckHealthRequestType request);
    }
}
