//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppCalcolatore.ServiceReferenceCalcolatore {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCalcolatore.WsCalcolatoreSoap")]
    public interface WsCalcolatoreSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Somma", ReplyAction="*")]
        int Somma(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Somma", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SommaAsync(int x, int y);
        
        // CODEGEN: Generazione di un contratto di messaggio perché il nome di elemento RitornaCalcoliSessioneResult dallo spazio dei nomi http://tempuri.org/ non è contrassegnato come nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RitornaCalcoliSessione", ReplyAction="*")]
        WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneResponse RitornaCalcoliSessione(WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RitornaCalcoliSessione", ReplyAction="*")]
        System.Threading.Tasks.Task<WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneResponse> RitornaCalcoliSessioneAsync(WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RitornaCalcoliSessioneRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RitornaCalcoliSessione", Namespace="http://tempuri.org/", Order=0)]
        public WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequestBody Body;
        
        public RitornaCalcoliSessioneRequest() {
        }
        
        public RitornaCalcoliSessioneRequest(WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class RitornaCalcoliSessioneRequestBody {
        
        public RitornaCalcoliSessioneRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RitornaCalcoliSessioneResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RitornaCalcoliSessioneResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneResponseBody Body;
        
        public RitornaCalcoliSessioneResponse() {
        }
        
        public RitornaCalcoliSessioneResponse(WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RitornaCalcoliSessioneResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebAppCalcolatore.ServiceReferenceCalcolatore.ArrayOfString RitornaCalcoliSessioneResult;
        
        public RitornaCalcoliSessioneResponseBody() {
        }
        
        public RitornaCalcoliSessioneResponseBody(WebAppCalcolatore.ServiceReferenceCalcolatore.ArrayOfString RitornaCalcoliSessioneResult) {
            this.RitornaCalcoliSessioneResult = RitornaCalcoliSessioneResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WsCalcolatoreSoapChannel : WebAppCalcolatore.ServiceReferenceCalcolatore.WsCalcolatoreSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsCalcolatoreSoapClient : System.ServiceModel.ClientBase<WebAppCalcolatore.ServiceReferenceCalcolatore.WsCalcolatoreSoap>, WebAppCalcolatore.ServiceReferenceCalcolatore.WsCalcolatoreSoap {
        
        public WsCalcolatoreSoapClient() {
        }
        
        public WsCalcolatoreSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsCalcolatoreSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsCalcolatoreSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsCalcolatoreSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Somma(int x, int y) {
            return base.Channel.Somma(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SommaAsync(int x, int y) {
            return base.Channel.SommaAsync(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneResponse WebAppCalcolatore.ServiceReferenceCalcolatore.WsCalcolatoreSoap.RitornaCalcoliSessione(WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequest request) {
            return base.Channel.RitornaCalcoliSessione(request);
        }
        
        public WebAppCalcolatore.ServiceReferenceCalcolatore.ArrayOfString RitornaCalcoliSessione() {
            WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequest inValue = new WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequest();
            inValue.Body = new WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequestBody();
            WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneResponse retVal = ((WebAppCalcolatore.ServiceReferenceCalcolatore.WsCalcolatoreSoap)(this)).RitornaCalcoliSessione(inValue);
            return retVal.Body.RitornaCalcoliSessioneResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneResponse> WebAppCalcolatore.ServiceReferenceCalcolatore.WsCalcolatoreSoap.RitornaCalcoliSessioneAsync(WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequest request) {
            return base.Channel.RitornaCalcoliSessioneAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneResponse> RitornaCalcoliSessioneAsync() {
            WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequest inValue = new WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequest();
            inValue.Body = new WebAppCalcolatore.ServiceReferenceCalcolatore.RitornaCalcoliSessioneRequestBody();
            return ((WebAppCalcolatore.ServiceReferenceCalcolatore.WsCalcolatoreSoap)(this)).RitornaCalcoliSessioneAsync(inValue);
        }
    }
}
