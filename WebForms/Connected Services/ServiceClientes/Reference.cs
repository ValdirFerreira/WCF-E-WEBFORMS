//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebForms.ServiceClientes {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceCliente.Entidades")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BairroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CEPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPFField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ComplementoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataExpedicaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataNascimentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoCivilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogradouroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrgaoExpedicaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RGField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UFField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UF_ExpedicaoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bairro {
            get {
                return this.BairroField;
            }
            set {
                if ((object.ReferenceEquals(this.BairroField, value) != true)) {
                    this.BairroField = value;
                    this.RaisePropertyChanged("Bairro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CEP {
            get {
                return this.CEPField;
            }
            set {
                if ((object.ReferenceEquals(this.CEPField, value) != true)) {
                    this.CEPField = value;
                    this.RaisePropertyChanged("CEP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPF {
            get {
                return this.CPFField;
            }
            set {
                if ((object.ReferenceEquals(this.CPFField, value) != true)) {
                    this.CPFField = value;
                    this.RaisePropertyChanged("CPF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cidade {
            get {
                return this.CidadeField;
            }
            set {
                if ((object.ReferenceEquals(this.CidadeField, value) != true)) {
                    this.CidadeField = value;
                    this.RaisePropertyChanged("Cidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Complemento {
            get {
                return this.ComplementoField;
            }
            set {
                if ((object.ReferenceEquals(this.ComplementoField, value) != true)) {
                    this.ComplementoField = value;
                    this.RaisePropertyChanged("Complemento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataExpedicao {
            get {
                return this.DataExpedicaoField;
            }
            set {
                if ((this.DataExpedicaoField.Equals(value) != true)) {
                    this.DataExpedicaoField = value;
                    this.RaisePropertyChanged("DataExpedicao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataNascimento {
            get {
                return this.DataNascimentoField;
            }
            set {
                if ((this.DataNascimentoField.Equals(value) != true)) {
                    this.DataNascimentoField = value;
                    this.RaisePropertyChanged("DataNascimento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstadoCivil {
            get {
                return this.EstadoCivilField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoCivilField, value) != true)) {
                    this.EstadoCivilField = value;
                    this.RaisePropertyChanged("EstadoCivil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Logradouro {
            get {
                return this.LogradouroField;
            }
            set {
                if ((object.ReferenceEquals(this.LogradouroField, value) != true)) {
                    this.LogradouroField = value;
                    this.RaisePropertyChanged("Logradouro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroField, value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrgaoExpedicao {
            get {
                return this.OrgaoExpedicaoField;
            }
            set {
                if ((object.ReferenceEquals(this.OrgaoExpedicaoField, value) != true)) {
                    this.OrgaoExpedicaoField = value;
                    this.RaisePropertyChanged("OrgaoExpedicao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RG {
            get {
                return this.RGField;
            }
            set {
                if ((object.ReferenceEquals(this.RGField, value) != true)) {
                    this.RGField = value;
                    this.RaisePropertyChanged("RG");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UF {
            get {
                return this.UFField;
            }
            set {
                if ((object.ReferenceEquals(this.UFField, value) != true)) {
                    this.UFField = value;
                    this.RaisePropertyChanged("UF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UF_Expedicao {
            get {
                return this.UF_ExpedicaoField;
            }
            set {
                if ((object.ReferenceEquals(this.UF_ExpedicaoField, value) != true)) {
                    this.UF_ExpedicaoField = value;
                    this.RaisePropertyChanged("UF_Expedicao");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceClientes.IServiceCliente")]
    public interface IServiceCliente {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/Listar", ReplyAction="http://tempuri.org/IServiceCliente/ListarResponse")]
        WebForms.ServiceClientes.Cliente[] Listar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/Listar", ReplyAction="http://tempuri.org/IServiceCliente/ListarResponse")]
        System.Threading.Tasks.Task<WebForms.ServiceClientes.Cliente[]> ListarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/Incluir", ReplyAction="http://tempuri.org/IServiceCliente/IncluirResponse")]
        WebForms.ServiceClientes.IncluirResponse Incluir(WebForms.ServiceClientes.IncluirRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque a operação tem vários valores de retorno.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/Incluir", ReplyAction="http://tempuri.org/IServiceCliente/IncluirResponse")]
        System.Threading.Tasks.Task<WebForms.ServiceClientes.IncluirResponse> IncluirAsync(WebForms.ServiceClientes.IncluirRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/Atualizar", ReplyAction="http://tempuri.org/IServiceCliente/AtualizarResponse")]
        WebForms.ServiceClientes.AtualizarResponse Atualizar(WebForms.ServiceClientes.AtualizarRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque a operação tem vários valores de retorno.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/Atualizar", ReplyAction="http://tempuri.org/IServiceCliente/AtualizarResponse")]
        System.Threading.Tasks.Task<WebForms.ServiceClientes.AtualizarResponse> AtualizarAsync(WebForms.ServiceClientes.AtualizarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/Excluir", ReplyAction="http://tempuri.org/IServiceCliente/ExcluirResponse")]
        WebForms.ServiceClientes.ExcluirResponse Excluir(WebForms.ServiceClientes.ExcluirRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque a operação tem vários valores de retorno.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCliente/Excluir", ReplyAction="http://tempuri.org/IServiceCliente/ExcluirResponse")]
        System.Threading.Tasks.Task<WebForms.ServiceClientes.ExcluirResponse> ExcluirAsync(WebForms.ServiceClientes.ExcluirRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Incluir", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class IncluirRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WebForms.ServiceClientes.Cliente cliente;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public IncluirRequest() {
        }
        
        public IncluirRequest(WebForms.ServiceClientes.Cliente cliente, string mensagem) {
            this.cliente = cliente;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IncluirResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class IncluirResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool IncluirResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public IncluirResponse() {
        }
        
        public IncluirResponse(bool IncluirResult, string mensagem) {
            this.IncluirResult = IncluirResult;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Atualizar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AtualizarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WebForms.ServiceClientes.Cliente cliente;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public AtualizarRequest() {
        }
        
        public AtualizarRequest(WebForms.ServiceClientes.Cliente cliente, string mensagem) {
            this.cliente = cliente;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AtualizarResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AtualizarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool AtualizarResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public AtualizarResponse() {
        }
        
        public AtualizarResponse(bool AtualizarResult, string mensagem) {
            this.AtualizarResult = AtualizarResult;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Excluir", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExcluirRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public ExcluirRequest() {
        }
        
        public ExcluirRequest(int id, string mensagem) {
            this.id = id;
            this.mensagem = mensagem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExcluirResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ExcluirResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool ExcluirResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string mensagem;
        
        public ExcluirResponse() {
        }
        
        public ExcluirResponse(bool ExcluirResult, string mensagem) {
            this.ExcluirResult = ExcluirResult;
            this.mensagem = mensagem;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceClienteChannel : WebForms.ServiceClientes.IServiceCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClienteClient : System.ServiceModel.ClientBase<WebForms.ServiceClientes.IServiceCliente>, WebForms.ServiceClientes.IServiceCliente {
        
        public ServiceClienteClient() {
        }
        
        public ServiceClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebForms.ServiceClientes.Cliente[] Listar(int id) {
            return base.Channel.Listar(id);
        }
        
        public System.Threading.Tasks.Task<WebForms.ServiceClientes.Cliente[]> ListarAsync(int id) {
            return base.Channel.ListarAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebForms.ServiceClientes.IncluirResponse WebForms.ServiceClientes.IServiceCliente.Incluir(WebForms.ServiceClientes.IncluirRequest request) {
            return base.Channel.Incluir(request);
        }
        
        public bool Incluir(WebForms.ServiceClientes.Cliente cliente, ref string mensagem) {
            WebForms.ServiceClientes.IncluirRequest inValue = new WebForms.ServiceClientes.IncluirRequest();
            inValue.cliente = cliente;
            inValue.mensagem = mensagem;
            WebForms.ServiceClientes.IncluirResponse retVal = ((WebForms.ServiceClientes.IServiceCliente)(this)).Incluir(inValue);
            mensagem = retVal.mensagem;
            return retVal.IncluirResult;
        }
        
        public System.Threading.Tasks.Task<WebForms.ServiceClientes.IncluirResponse> IncluirAsync(WebForms.ServiceClientes.IncluirRequest request) {
            return base.Channel.IncluirAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebForms.ServiceClientes.AtualizarResponse WebForms.ServiceClientes.IServiceCliente.Atualizar(WebForms.ServiceClientes.AtualizarRequest request) {
            return base.Channel.Atualizar(request);
        }
        
        public bool Atualizar(WebForms.ServiceClientes.Cliente cliente, ref string mensagem) {
            WebForms.ServiceClientes.AtualizarRequest inValue = new WebForms.ServiceClientes.AtualizarRequest();
            inValue.cliente = cliente;
            inValue.mensagem = mensagem;
            WebForms.ServiceClientes.AtualizarResponse retVal = ((WebForms.ServiceClientes.IServiceCliente)(this)).Atualizar(inValue);
            mensagem = retVal.mensagem;
            return retVal.AtualizarResult;
        }
        
        public System.Threading.Tasks.Task<WebForms.ServiceClientes.AtualizarResponse> AtualizarAsync(WebForms.ServiceClientes.AtualizarRequest request) {
            return base.Channel.AtualizarAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebForms.ServiceClientes.ExcluirResponse WebForms.ServiceClientes.IServiceCliente.Excluir(WebForms.ServiceClientes.ExcluirRequest request) {
            return base.Channel.Excluir(request);
        }
        
        public bool Excluir(int id, ref string mensagem) {
            WebForms.ServiceClientes.ExcluirRequest inValue = new WebForms.ServiceClientes.ExcluirRequest();
            inValue.id = id;
            inValue.mensagem = mensagem;
            WebForms.ServiceClientes.ExcluirResponse retVal = ((WebForms.ServiceClientes.IServiceCliente)(this)).Excluir(inValue);
            mensagem = retVal.mensagem;
            return retVal.ExcluirResult;
        }
        
        public System.Threading.Tasks.Task<WebForms.ServiceClientes.ExcluirResponse> ExcluirAsync(WebForms.ServiceClientes.ExcluirRequest request) {
            return base.Channel.ExcluirAsync(request);
        }
    }
}
