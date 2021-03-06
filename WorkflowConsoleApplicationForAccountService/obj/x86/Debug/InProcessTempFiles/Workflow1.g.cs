//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WorkflowConsoleApplicationForAccountService {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class Workflow1 : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private System.Activities.InArgument<string> _UserNameArgument;
        
        private System.Activities.InArgument<string> _PasswordArgument;
        
        private System.Activities.OutArgument<bool> _ResultCreate;
        
        private System.Activities.OutArgument<bool[]> _ResulltLogin;
        
        private System.Activities.InArgument<string> _ToEncrypt;
        
        private System.Activities.InArgument<string> _Encrypted;
        
        private System.Activities.InArgument<string> _Decrypted;
        
        private System.Activities.InArgument<string[]> _Topic;
        
        private System.Activities.OutArgument<string[]> _ResultTopic;
        
partial void BeforeInitializeComponent(ref bool isInitialized);

partial void AfterInitializeComponent();

        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        public Workflow1() {
            this.InitializeComponent();
        }
        
        public System.Activities.InArgument<string> UserNameArgument {
            get {
                return this._UserNameArgument;
            }
            set {
                this._UserNameArgument = value;
            }
        }
        
        public System.Activities.InArgument<string> PasswordArgument {
            get {
                return this._PasswordArgument;
            }
            set {
                this._PasswordArgument = value;
            }
        }
        
        public System.Activities.OutArgument<bool> ResultCreate {
            get {
                return this._ResultCreate;
            }
            set {
                this._ResultCreate = value;
            }
        }
        
        public System.Activities.OutArgument<bool[]> ResulltLogin {
            get {
                return this._ResulltLogin;
            }
            set {
                this._ResulltLogin = value;
            }
        }
        
        public System.Activities.InArgument<string> ToEncrypt {
            get {
                return this._ToEncrypt;
            }
            set {
                this._ToEncrypt = value;
            }
        }
        
        public System.Activities.InArgument<string> Encrypted {
            get {
                return this._Encrypted;
            }
            set {
                this._Encrypted = value;
            }
        }
        
        public System.Activities.InArgument<string> Decrypted {
            get {
                return this._Decrypted;
            }
            set {
                this._Decrypted = value;
            }
        }
        
        public System.Activities.InArgument<string[]> Topic {
            get {
                return this._Topic;
            }
            set {
                this._Topic = value;
            }
        }
        
        public System.Activities.OutArgument<string[]> ResultTopic {
            get {
                return this._ResultTopic;
            }
            set {
                this._ResultTopic = value;
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
            System.IO.Stream initializeXaml = typeof(Workflow1).Assembly.GetManifestResourceStream(resourceName);
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
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(Workflow1));
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
            string[] resources = typeof(Workflow1).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".Workflow1.g.xaml") || resource.Equals("Workflow1.g.xaml"))) {
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
