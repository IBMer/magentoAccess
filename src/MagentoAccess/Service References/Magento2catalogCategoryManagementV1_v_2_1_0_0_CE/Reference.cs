﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1")]
    public partial class GenericFault : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string traceField;
        
        private GenericFaultParameter[] parametersField;
        
        private WrappedError[] wrappedErrorsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string Trace {
            get {
                return this.traceField;
            }
            set {
                this.traceField = value;
                this.RaisePropertyChanged("Trace");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GenericFaultParameter[] Parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
                this.RaisePropertyChanged("Parameters");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public WrappedError[] WrappedErrors {
            get {
                return this.wrappedErrorsField;
            }
            set {
                this.wrappedErrorsField = value;
                this.RaisePropertyChanged("WrappedErrors");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1")]
    public partial class GenericFaultParameter : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1")]
    public partial class WrappedError : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        private GenericFaultParameter[] parametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public GenericFaultParameter[] parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
                this.RaisePropertyChanged("parameters");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1")]
    public partial class CatalogDataCategoryTreeInterface : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private int parentIdField;
        
        private string nameField;
        
        private bool isActiveField;
        
        private int positionField;
        
        private int levelField;
        
        private int productCountField;
        
        private CatalogDataCategoryTreeInterface[] childrenDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int parentId {
            get {
                return this.parentIdField;
            }
            set {
                this.parentIdField = value;
                this.RaisePropertyChanged("parentId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool isActive {
            get {
                return this.isActiveField;
            }
            set {
                this.isActiveField = value;
                this.RaisePropertyChanged("isActive");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int position {
            get {
                return this.positionField;
            }
            set {
                this.positionField = value;
                this.RaisePropertyChanged("position");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
                this.RaisePropertyChanged("level");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int productCount {
            get {
                return this.productCountField;
            }
            set {
                this.productCountField = value;
                this.RaisePropertyChanged("productCount");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public CatalogDataCategoryTreeInterface[] childrenData {
            get {
                return this.childrenDataField;
            }
            set {
                this.childrenDataField = value;
                this.RaisePropertyChanged("childrenData");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1")]
    public partial class CatalogCategoryManagementV1GetTreeResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private CatalogDataCategoryTreeInterface resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public CatalogDataCategoryTreeInterface result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("result");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1")]
    public partial class CatalogCategoryManagementV1GetTreeRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int rootCategoryIdField;
        
        private bool rootCategoryIdFieldSpecified;
        
        private int depthField;
        
        private bool depthFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int rootCategoryId {
            get {
                return this.rootCategoryIdField;
            }
            set {
                this.rootCategoryIdField = value;
                this.RaisePropertyChanged("rootCategoryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rootCategoryIdSpecified {
            get {
                return this.rootCategoryIdFieldSpecified;
            }
            set {
                this.rootCategoryIdFieldSpecified = value;
                this.RaisePropertyChanged("rootCategoryIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int depth {
            get {
                return this.depthField;
            }
            set {
                this.depthField = value;
                this.RaisePropertyChanged("depth");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool depthSpecified {
            get {
                return this.depthFieldSpecified;
            }
            set {
                this.depthFieldSpecified = value;
                this.RaisePropertyChanged("depthSpecified");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1", ConfigurationName="Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortT" +
        "ype")]
    public interface catalogCategoryManagementV1PortType {
        
        // CODEGEN: Generating message contract since the operation catalogCategoryManagementV1GetTree is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="catalogCategoryManagementV1GetTree", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.GenericFault), Action="catalogCategoryManagementV1GetTree", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeResponse1 catalogCategoryManagementV1GetTree(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="catalogCategoryManagementV1GetTree", ReplyAction="*")]
        System.Threading.Tasks.Task<MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeResponse1> catalogCategoryManagementV1GetTreeAsync(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeRequest1 request);
        
        // CODEGEN: Generating message contract since the operation catalogCategoryManagementV1Move is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="catalogCategoryManagementV1Move", ReplyAction="*")]
        [System.ServiceModel.FaultContractAttribute(typeof(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.GenericFault), Action="catalogCategoryManagementV1Move", Name="GenericFault")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveResponse1 catalogCategoryManagementV1Move(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveRequest1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="catalogCategoryManagementV1Move", ReplyAction="*")]
        System.Threading.Tasks.Task<MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveResponse1> catalogCategoryManagementV1MoveAsync(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveRequest1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class catalogCategoryManagementV1GetTreeRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
            "yManagementV1", Order=0)]
        public MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1GetTreeRequest catalogCategoryManagementV1GetTreeRequest;
        
        public catalogCategoryManagementV1GetTreeRequest1() {
        }
        
        public catalogCategoryManagementV1GetTreeRequest1(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1GetTreeRequest catalogCategoryManagementV1GetTreeRequest) {
            this.catalogCategoryManagementV1GetTreeRequest = catalogCategoryManagementV1GetTreeRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class catalogCategoryManagementV1GetTreeResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
            "yManagementV1", Order=0)]
        public MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1GetTreeResponse catalogCategoryManagementV1GetTreeResponse;
        
        public catalogCategoryManagementV1GetTreeResponse1() {
        }
        
        public catalogCategoryManagementV1GetTreeResponse1(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1GetTreeResponse catalogCategoryManagementV1GetTreeResponse) {
            this.catalogCategoryManagementV1GetTreeResponse = catalogCategoryManagementV1GetTreeResponse;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1")]
    public partial class CatalogCategoryManagementV1MoveRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int categoryIdField;
        
        private int parentIdField;
        
        private int afterIdField;
        
        private bool afterIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int categoryId {
            get {
                return this.categoryIdField;
            }
            set {
                this.categoryIdField = value;
                this.RaisePropertyChanged("categoryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int parentId {
            get {
                return this.parentIdField;
            }
            set {
                this.parentIdField = value;
                this.RaisePropertyChanged("parentId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int afterId {
            get {
                return this.afterIdField;
            }
            set {
                this.afterIdField = value;
                this.RaisePropertyChanged("afterId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool afterIdSpecified {
            get {
                return this.afterIdFieldSpecified;
            }
            set {
                this.afterIdFieldSpecified = value;
                this.RaisePropertyChanged("afterIdSpecified");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
        "yManagementV1")]
    public partial class CatalogCategoryManagementV1MoveResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public bool result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("result");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class catalogCategoryManagementV1MoveRequest1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
            "yManagementV1", Order=0)]
        public MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1MoveRequest catalogCategoryManagementV1MoveRequest;
        
        public catalogCategoryManagementV1MoveRequest1() {
        }
        
        public catalogCategoryManagementV1MoveRequest1(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1MoveRequest catalogCategoryManagementV1MoveRequest) {
            this.catalogCategoryManagementV1MoveRequest = catalogCategoryManagementV1MoveRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class catalogCategoryManagementV1MoveResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://127.0.0.1:777/magento-2-1-0-0-ce/soap/default?services=catalogCategor" +
            "yManagementV1", Order=0)]
        public MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1MoveResponse catalogCategoryManagementV1MoveResponse;
        
        public catalogCategoryManagementV1MoveResponse1() {
        }
        
        public catalogCategoryManagementV1MoveResponse1(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1MoveResponse catalogCategoryManagementV1MoveResponse) {
            this.catalogCategoryManagementV1MoveResponse = catalogCategoryManagementV1MoveResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface catalogCategoryManagementV1PortTypeChannel : MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class catalogCategoryManagementV1PortTypeClient : System.ServiceModel.ClientBase<MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType>, MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType {
        
        public catalogCategoryManagementV1PortTypeClient() {
        }
        
        public catalogCategoryManagementV1PortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public catalogCategoryManagementV1PortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public catalogCategoryManagementV1PortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public catalogCategoryManagementV1PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeResponse1 MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType.catalogCategoryManagementV1GetTree(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeRequest1 request) {
            return base.Channel.catalogCategoryManagementV1GetTree(request);
        }
        
        public MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1GetTreeResponse catalogCategoryManagementV1GetTree(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1GetTreeRequest catalogCategoryManagementV1GetTreeRequest) {
            MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeRequest1 inValue = new MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeRequest1();
            inValue.catalogCategoryManagementV1GetTreeRequest = catalogCategoryManagementV1GetTreeRequest;
            MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeResponse1 retVal = ((MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType)(this)).catalogCategoryManagementV1GetTree(inValue);
            return retVal.catalogCategoryManagementV1GetTreeResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeResponse1> MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType.catalogCategoryManagementV1GetTreeAsync(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeRequest1 request) {
            return base.Channel.catalogCategoryManagementV1GetTreeAsync(request);
        }
        
        public System.Threading.Tasks.Task<MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeResponse1> catalogCategoryManagementV1GetTreeAsync(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1GetTreeRequest catalogCategoryManagementV1GetTreeRequest) {
            MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeRequest1 inValue = new MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1GetTreeRequest1();
            inValue.catalogCategoryManagementV1GetTreeRequest = catalogCategoryManagementV1GetTreeRequest;
            return ((MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType)(this)).catalogCategoryManagementV1GetTreeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveResponse1 MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType.catalogCategoryManagementV1Move(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveRequest1 request) {
            return base.Channel.catalogCategoryManagementV1Move(request);
        }
        
        public MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1MoveResponse catalogCategoryManagementV1Move(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1MoveRequest catalogCategoryManagementV1MoveRequest) {
            MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveRequest1 inValue = new MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveRequest1();
            inValue.catalogCategoryManagementV1MoveRequest = catalogCategoryManagementV1MoveRequest;
            MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveResponse1 retVal = ((MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType)(this)).catalogCategoryManagementV1Move(inValue);
            return retVal.catalogCategoryManagementV1MoveResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveResponse1> MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType.catalogCategoryManagementV1MoveAsync(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveRequest1 request) {
            return base.Channel.catalogCategoryManagementV1MoveAsync(request);
        }
        
        public System.Threading.Tasks.Task<MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveResponse1> catalogCategoryManagementV1MoveAsync(MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.CatalogCategoryManagementV1MoveRequest catalogCategoryManagementV1MoveRequest) {
            MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveRequest1 inValue = new MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1MoveRequest1();
            inValue.catalogCategoryManagementV1MoveRequest = catalogCategoryManagementV1MoveRequest;
            return ((MagentoAccess.Magento2catalogCategoryManagementV1_v_2_1_0_0_CE.catalogCategoryManagementV1PortType)(this)).catalogCategoryManagementV1MoveAsync(inValue);
        }
    }
}