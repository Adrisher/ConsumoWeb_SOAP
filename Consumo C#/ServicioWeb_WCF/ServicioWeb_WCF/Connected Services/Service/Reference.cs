//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioWeb_WCF.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws/", ConfigurationName="Service.WSOperaciones")]
    public interface WSOperaciones {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento name del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/helloRequest", ReplyAction="http://ws/WSOperaciones/helloResponse")]
        ServicioWeb_WCF.Service.helloResponse hello(ServicioWeb_WCF.Service.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/helloRequest", ReplyAction="http://ws/WSOperaciones/helloResponse")]
        System.Threading.Tasks.Task<ServicioWeb_WCF.Service.helloResponse> helloAsync(ServicioWeb_WCF.Service.helloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://ws/).
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/ProcesarPagoRequest", ReplyAction="http://ws/WSOperaciones/ProcesarPagoResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServicioWeb_WCF.Service.ProcesarPagoResponse ProcesarPago(ServicioWeb_WCF.Service.ProcesarPagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/ProcesarPagoRequest", ReplyAction="http://ws/WSOperaciones/ProcesarPagoResponse")]
        System.Threading.Tasks.Task<ServicioWeb_WCF.Service.ProcesarPagoResponse> ProcesarPagoAsync(ServicioWeb_WCF.Service.ProcesarPagoRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento User del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/LoguinRequest", ReplyAction="http://ws/WSOperaciones/LoguinResponse")]
        ServicioWeb_WCF.Service.LoguinResponse Loguin(ServicioWeb_WCF.Service.LoguinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/LoguinRequest", ReplyAction="http://ws/WSOperaciones/LoguinResponse")]
        System.Threading.Tasks.Task<ServicioWeb_WCF.Service.LoguinResponse> LoguinAsync(ServicioWeb_WCF.Service.LoguinRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="hello", Namespace="http://ws/", Order=0)]
        public ServicioWeb_WCF.Service.helloRequestBody Body;
        
        public helloRequest() {
        }
        
        public helloRequest(ServicioWeb_WCF.Service.helloRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public helloRequestBody() {
        }
        
        public helloRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="helloResponse", Namespace="http://ws/", Order=0)]
        public ServicioWeb_WCF.Service.helloResponseBody Body;
        
        public helloResponse() {
        }
        
        public helloResponse(ServicioWeb_WCF.Service.helloResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class helloResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public helloResponseBody() {
        }
        
        public helloResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcesarPago", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ProcesarPagoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int total;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int pago;
        
        public ProcesarPagoRequest() {
        }
        
        public ProcesarPagoRequest(int total, int pago) {
            this.total = total;
            this.pago = pago;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcesarPagoResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ProcesarPagoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int @return;
        
        public ProcesarPagoResponse() {
        }
        
        public ProcesarPagoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoguinRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Loguin", Namespace="http://ws/", Order=0)]
        public ServicioWeb_WCF.Service.LoguinRequestBody Body;
        
        public LoguinRequest() {
        }
        
        public LoguinRequest(ServicioWeb_WCF.Service.LoguinRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class LoguinRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string User;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        public LoguinRequestBody() {
        }
        
        public LoguinRequestBody(string User, string Password) {
            this.User = User;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoguinResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoguinResponse", Namespace="http://ws/", Order=0)]
        public ServicioWeb_WCF.Service.LoguinResponseBody Body;
        
        public LoguinResponse() {
        }
        
        public LoguinResponse(ServicioWeb_WCF.Service.LoguinResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class LoguinResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool @return;
        
        public LoguinResponseBody() {
        }
        
        public LoguinResponseBody(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSOperacionesChannel : ServicioWeb_WCF.Service.WSOperaciones, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSOperacionesClient : System.ServiceModel.ClientBase<ServicioWeb_WCF.Service.WSOperaciones>, ServicioWeb_WCF.Service.WSOperaciones {
        
        public WSOperacionesClient() {
        }
        
        public WSOperacionesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSOperacionesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSOperacionesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSOperacionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServicioWeb_WCF.Service.helloResponse ServicioWeb_WCF.Service.WSOperaciones.hello(ServicioWeb_WCF.Service.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            ServicioWeb_WCF.Service.helloRequest inValue = new ServicioWeb_WCF.Service.helloRequest();
            inValue.Body = new ServicioWeb_WCF.Service.helloRequestBody();
            inValue.Body.name = name;
            ServicioWeb_WCF.Service.helloResponse retVal = ((ServicioWeb_WCF.Service.WSOperaciones)(this)).hello(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioWeb_WCF.Service.helloResponse> ServicioWeb_WCF.Service.WSOperaciones.helloAsync(ServicioWeb_WCF.Service.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioWeb_WCF.Service.helloResponse> helloAsync(string name) {
            ServicioWeb_WCF.Service.helloRequest inValue = new ServicioWeb_WCF.Service.helloRequest();
            inValue.Body = new ServicioWeb_WCF.Service.helloRequestBody();
            inValue.Body.name = name;
            return ((ServicioWeb_WCF.Service.WSOperaciones)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServicioWeb_WCF.Service.ProcesarPagoResponse ServicioWeb_WCF.Service.WSOperaciones.ProcesarPago(ServicioWeb_WCF.Service.ProcesarPagoRequest request) {
            return base.Channel.ProcesarPago(request);
        }
        
        public int ProcesarPago(int total, int pago) {
            ServicioWeb_WCF.Service.ProcesarPagoRequest inValue = new ServicioWeb_WCF.Service.ProcesarPagoRequest();
            inValue.total = total;
            inValue.pago = pago;
            ServicioWeb_WCF.Service.ProcesarPagoResponse retVal = ((ServicioWeb_WCF.Service.WSOperaciones)(this)).ProcesarPago(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioWeb_WCF.Service.ProcesarPagoResponse> ServicioWeb_WCF.Service.WSOperaciones.ProcesarPagoAsync(ServicioWeb_WCF.Service.ProcesarPagoRequest request) {
            return base.Channel.ProcesarPagoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioWeb_WCF.Service.ProcesarPagoResponse> ProcesarPagoAsync(int total, int pago) {
            ServicioWeb_WCF.Service.ProcesarPagoRequest inValue = new ServicioWeb_WCF.Service.ProcesarPagoRequest();
            inValue.total = total;
            inValue.pago = pago;
            return ((ServicioWeb_WCF.Service.WSOperaciones)(this)).ProcesarPagoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServicioWeb_WCF.Service.LoguinResponse ServicioWeb_WCF.Service.WSOperaciones.Loguin(ServicioWeb_WCF.Service.LoguinRequest request) {
            return base.Channel.Loguin(request);
        }
        
        public bool Loguin(string User, string Password) {
            ServicioWeb_WCF.Service.LoguinRequest inValue = new ServicioWeb_WCF.Service.LoguinRequest();
            inValue.Body = new ServicioWeb_WCF.Service.LoguinRequestBody();
            inValue.Body.User = User;
            inValue.Body.Password = Password;
            ServicioWeb_WCF.Service.LoguinResponse retVal = ((ServicioWeb_WCF.Service.WSOperaciones)(this)).Loguin(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioWeb_WCF.Service.LoguinResponse> ServicioWeb_WCF.Service.WSOperaciones.LoguinAsync(ServicioWeb_WCF.Service.LoguinRequest request) {
            return base.Channel.LoguinAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioWeb_WCF.Service.LoguinResponse> LoguinAsync(string User, string Password) {
            ServicioWeb_WCF.Service.LoguinRequest inValue = new ServicioWeb_WCF.Service.LoguinRequest();
            inValue.Body = new ServicioWeb_WCF.Service.LoguinRequestBody();
            inValue.Body.User = User;
            inValue.Body.Password = Password;
            return ((ServicioWeb_WCF.Service.WSOperaciones)(this)).LoguinAsync(inValue);
        }
    }
}
