//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WorkflowConsoleApplicationForAccountService.NewforcusServiceNha.Activities {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class NewForcusService : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private string _EndpointConfigurationName;
        
        private System.Activities.InArgument<string[]> _Input_topic;
        
        private System.Activities.OutArgument<string[]> _Output_Result;
        
partial void BeforeInitializeComponent(ref bool isInitialized);

partial void AfterInitializeComponent();

        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        public NewForcusService() {
            this.InitializeComponent();
        }
        
        [System.ComponentModel.DefaultValueAttribute("BasicHttpBinding_IService3")]
        public string EndpointConfigurationName {
            get {
                return this._EndpointConfigurationName;
            }
            set {
                this._EndpointConfigurationName = value;
            }
        }
        
        [System.Activities.RequiredArgumentAttribute()]
        public System.Activities.InArgument<string[]> Input_topic {
            get {
                return this._Input_topic;
            }
            set {
                this._Input_topic = value;
            }
        }
        
        public System.Activities.OutArgument<string[]> Output_Result {
            get {
                return this._Output_Result;
            }
            set {
                this._Output_Result = value;
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        public void InitializeComponent() {
            if ((this._contentLoaded == true)) {
                return;
            }
            this._contentLoaded = true;
            bool isInitialized = false;
            this.BeforeInitializeComponent(ref isInitialized);
            if ((isInitialized == true)) {
                this.AfterInitializeComponent();
                return;
            }
            string resourceName = this.FindResource();
            System.IO.Stream initializeXaml = typeof(NewForcusService).Assembly.GetManifestResourceStream(resourceName);
            System.Xml.XmlReader xmlReader = null;
            System.Xaml.XamlReader reader = null;
            System.Xaml.XamlObjectWriter objectWriter = null;
            try {
                System.Xaml.XamlSchemaContext schemaContext = XamlStaticHelperNamespace._XamlStaticHelper.SchemaContext;
                xmlReader = System.Xml.XmlReader.Create(initializeXaml);
                System.Xaml.XamlXmlReaderSettings readerSettings = new System.Xaml.XamlXmlReaderSettings();
                readerSettings.LocalAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                readerSettings.AllowProtectedMembersOnRoot = true;
                reader = new System.Xaml.XamlXmlReader(xmlReader, schemaContext, readerSettings);
                System.Xaml.XamlObjectWriterSettings writerSettings = new System.Xaml.XamlObjectWriterSettings();
                writerSettings.RootObjectInstance = this;
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(NewForcusService));
                objectWriter = new System.Xaml.XamlObjectWriter(schemaContext, writerSettings);
                System.Xaml.XamlServices.Transform(reader, objectWriter);
            }
            finally {
                if ((xmlReader != null)) {
                    ((System.IDisposable)(xmlReader)).Dispose();
                }
                if ((reader != null)) {
                    ((System.IDisposable)(reader)).Dispose();
                }
                if ((objectWriter != null)) {
                    ((System.IDisposable)(objectWriter)).Dispose();
                }
            }
            this.AfterInitializeComponent();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        private string FindResource() {
            string[] resources = typeof(NewForcusService).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".WorkflowConsoleApplicationForAccountService.NewforcusServiceNha.IService.NewForc" +
                        "usService.g.xaml") || resource.Equals("WorkflowConsoleApplicationForAccountService.NewforcusServiceNha.IService.NewForcu" +
                        "sService.g.xaml"))) {
                    return resource;
                }
            }
            throw new System.InvalidOperationException("Resource not found.");
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        void System.ComponentModel.ISupportInitialize.BeginInit() {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        void System.ComponentModel.ISupportInitialize.EndInit() {
            this.InitializeComponent();
        }
    }
}
