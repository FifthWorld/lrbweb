﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.sola.webservices.filestreaming.extra
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.sola.org/faults/")]
    public partial class faultInfoBean : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string faultIdField;
        
        private string messageCodeField;
        
        private string[] messageParametersField;
        
        private validationResult[] validationResultListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string faultId
        {
            get
            {
                return this.faultIdField;
            }
            set
            {
                this.faultIdField = value;
                this.RaisePropertyChanged("faultId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string messageCode
        {
            get
            {
                return this.messageCodeField;
            }
            set
            {
                this.messageCodeField = value;
                this.RaisePropertyChanged("messageCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("messageParameters", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=2)]
        public string[] messageParameters
        {
            get
            {
                return this.messageParametersField;
            }
            set
            {
                this.messageParametersField = value;
                this.RaisePropertyChanged("messageParameters");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("validationResultList", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=3)]
        public validationResult[] validationResultList
        {
            get
            {
                return this.validationResultListField;
            }
            set
            {
                this.validationResultListField = value;
                this.RaisePropertyChanged("validationResultList");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://webservices.sola.org/transferobjects/")]
    public partial class validationResult : object, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string feedbackField;
        
        private string nameField;
        
        private string severityField;
        
        private bool successfulField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string feedback
        {
            get
            {
                return this.feedbackField;
            }
            set
            {
                this.feedbackField = value;
                this.RaisePropertyChanged("feedback");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
                this.RaisePropertyChanged("severity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool successful
        {
            get
            {
                return this.successfulField;
            }
            set
            {
                this.successfulField = value;
                this.RaisePropertyChanged("successful");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
namespace org.sola.webservices.filestreaming
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://webservices.sola.org/filestreaming", ConfigurationName="org.sola.webservices.filestreaming.FileStreaming")]
    public interface FileStreaming
    {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.sola.org/filestreaming/FileStreaming/CheckConnectionRequest", ReplyAction="http://webservices.sola.org/filestreaming/FileStreaming/CheckConnectionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        org.sola.webservices.filestreaming.CheckConnectionResponse CheckConnection(org.sola.webservices.filestreaming.CheckConnectionRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.sola.org/filestreaming/FileStreaming/UploadRequest", ReplyAction="http://webservices.sola.org/filestreaming/FileStreaming/UploadResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(org.sola.webservices.filestreaming.extra.faultInfoBean), Action="http://webservices.sola.org/filestreaming/FileStreaming/Upload/Fault/SOLAFault", Name="SOLAFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(org.sola.webservices.filestreaming.extra.faultInfoBean), Action="http://webservices.sola.org/filestreaming/FileStreaming/Upload/Fault/UnhandledFau" +
            "lt", Name="UnhandledFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        org.sola.webservices.filestreaming.UploadResponse Upload(org.sola.webservices.filestreaming.UploadRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://webservices.sola.org/filestreaming/FileStreaming/DownloadRequest", ReplyAction="http://webservices.sola.org/filestreaming/FileStreaming/DownloadResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(org.sola.webservices.filestreaming.extra.faultInfoBean), Action="http://webservices.sola.org/filestreaming/FileStreaming/Download/Fault/SOLAFault", Name="SOLAFault")]
        [System.ServiceModel.FaultContractAttribute(typeof(org.sola.webservices.filestreaming.extra.faultInfoBean), Action="http://webservices.sola.org/filestreaming/FileStreaming/Download/Fault/UnhandledF" +
            "ault", Name="UnhandledFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        org.sola.webservices.filestreaming.DownloadResponse Download(org.sola.webservices.filestreaming.DownloadRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckConnection", WrapperNamespace="http://webservices.sola.org/filestreaming", IsWrapped=true)]
    public partial class CheckConnectionRequest
    {
        
        public CheckConnectionRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CheckConnectionResponse", WrapperNamespace="http://webservices.sola.org/filestreaming", IsWrapped=true)]
    public partial class CheckConnectionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.sola.org/filestreaming", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool @return;
        
        public CheckConnectionResponse()
        {
        }
        
        public CheckConnectionResponse(bool @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Upload", WrapperNamespace="http://webservices.sola.org/filestreaming", IsWrapped=true)]
    public partial class UploadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.sola.org/filestreaming", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] fileContent;
        
        public UploadRequest()
        {
        }
        
        public UploadRequest(byte[] fileContent)
        {
            this.fileContent = fileContent;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UploadResponse", WrapperNamespace="http://webservices.sola.org/filestreaming", IsWrapped=true)]
    public partial class UploadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.sola.org/filestreaming", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public UploadResponse()
        {
        }
        
        public UploadResponse(string @return)
        {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Download", WrapperNamespace="http://webservices.sola.org/filestreaming", IsWrapped=true)]
    public partial class DownloadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.sola.org/filestreaming", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string pathFileName;
        
        public DownloadRequest()
        {
        }
        
        public DownloadRequest(string pathFileName)
        {
            this.pathFileName = pathFileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadResponse", WrapperNamespace="http://webservices.sola.org/filestreaming", IsWrapped=true)]
    public partial class DownloadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://webservices.sola.org/filestreaming", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] @return;
        
        public DownloadResponse()
        {
        }
        
        public DownloadResponse(byte[] @return)
        {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface FileStreamingChannel : org.sola.webservices.filestreaming.FileStreaming, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class FileStreamingClient : System.ServiceModel.ClientBase<org.sola.webservices.filestreaming.FileStreaming>, org.sola.webservices.filestreaming.FileStreaming
    {
        
        public FileStreamingClient()
        {
        }
        
        public FileStreamingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public FileStreamingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public FileStreamingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public FileStreamingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        org.sola.webservices.filestreaming.CheckConnectionResponse org.sola.webservices.filestreaming.FileStreaming.CheckConnection(org.sola.webservices.filestreaming.CheckConnectionRequest request)
        {
            return base.Channel.CheckConnection(request);
        }
        
        public bool CheckConnection()
        {
            org.sola.webservices.filestreaming.CheckConnectionRequest inValue = new org.sola.webservices.filestreaming.CheckConnectionRequest();
            org.sola.webservices.filestreaming.CheckConnectionResponse retVal = ((org.sola.webservices.filestreaming.FileStreaming)(this)).CheckConnection(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        org.sola.webservices.filestreaming.UploadResponse org.sola.webservices.filestreaming.FileStreaming.Upload(org.sola.webservices.filestreaming.UploadRequest request)
        {
            return base.Channel.Upload(request);
        }
        
        public string Upload(byte[] fileContent)
        {
            org.sola.webservices.filestreaming.UploadRequest inValue = new org.sola.webservices.filestreaming.UploadRequest();
            inValue.fileContent = fileContent;
            org.sola.webservices.filestreaming.UploadResponse retVal = ((org.sola.webservices.filestreaming.FileStreaming)(this)).Upload(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        org.sola.webservices.filestreaming.DownloadResponse org.sola.webservices.filestreaming.FileStreaming.Download(org.sola.webservices.filestreaming.DownloadRequest request)
        {
            return base.Channel.Download(request);
        }
        
        public byte[] Download(string pathFileName)
        {
            org.sola.webservices.filestreaming.DownloadRequest inValue = new org.sola.webservices.filestreaming.DownloadRequest();
            inValue.pathFileName = pathFileName;
            org.sola.webservices.filestreaming.DownloadResponse retVal = ((org.sola.webservices.filestreaming.FileStreaming)(this)).Download(inValue);
            return retVal.@return;
        }
    }
}