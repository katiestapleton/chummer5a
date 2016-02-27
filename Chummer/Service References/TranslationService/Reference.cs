/*  This file is part of Chummer5a.
 *
 *  Chummer5a is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Chummer5a is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Chummer5a.  If not, see <http://www.gnu.org/licenses/>.
 *
 *  You can obtain the full source code for Chummer5a at
 *  https://github.com/chummer5a/chummer5a
 */
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chummer.TranslationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.dndjunkie.com/", ConfigurationName="TranslationService.translationSoap")]
    public interface translationSoap {
        
        // CODEGEN: Generating message contract since element name strUserName from namespace http://www.dndjunkie.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.dndjunkie.com/CanUploadLanguage", ReplyAction="*")]
        Chummer.TranslationService.CanUploadLanguageResponse CanUploadLanguage(Chummer.TranslationService.CanUploadLanguageRequest request);
        
        // CODEGEN: Generating message contract since element name strUserName from namespace http://www.dndjunkie.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.dndjunkie.com/UploadLanguage", ReplyAction="*")]
        Chummer.TranslationService.UploadLanguageResponse UploadLanguage(Chummer.TranslationService.UploadLanguageRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CanUploadLanguageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CanUploadLanguage", Namespace="http://www.dndjunkie.com/", Order=0)]
        public Chummer.TranslationService.CanUploadLanguageRequestBody Body;
        
        public CanUploadLanguageRequest() {
        }
        
        public CanUploadLanguageRequest(Chummer.TranslationService.CanUploadLanguageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dndjunkie.com/")]
    public partial class CanUploadLanguageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strUserName;
        
        public CanUploadLanguageRequestBody() {
        }
        
        public CanUploadLanguageRequestBody(string strUserName) {
            this.strUserName = strUserName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CanUploadLanguageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CanUploadLanguageResponse", Namespace="http://www.dndjunkie.com/", Order=0)]
        public Chummer.TranslationService.CanUploadLanguageResponseBody Body;
        
        public CanUploadLanguageResponse() {
        }
        
        public CanUploadLanguageResponse(Chummer.TranslationService.CanUploadLanguageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dndjunkie.com/")]
    public partial class CanUploadLanguageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CanUploadLanguageResult;
        
        public CanUploadLanguageResponseBody() {
        }
        
        public CanUploadLanguageResponseBody(bool CanUploadLanguageResult) {
            this.CanUploadLanguageResult = CanUploadLanguageResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadLanguageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadLanguage", Namespace="http://www.dndjunkie.com/", Order=0)]
        public Chummer.TranslationService.UploadLanguageRequestBody Body;
        
        public UploadLanguageRequest() {
        }
        
        public UploadLanguageRequest(Chummer.TranslationService.UploadLanguageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dndjunkie.com/")]
    public partial class UploadLanguageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string strUserName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strFileName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public byte[] bytFile;
        
        public UploadLanguageRequestBody() {
        }
        
        public UploadLanguageRequestBody(string strUserName, string strFileName, byte[] bytFile) {
            this.strUserName = strUserName;
            this.strFileName = strFileName;
            this.bytFile = bytFile;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadLanguageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadLanguageResponse", Namespace="http://www.dndjunkie.com/", Order=0)]
        public Chummer.TranslationService.UploadLanguageResponseBody Body;
        
        public UploadLanguageResponse() {
        }
        
        public UploadLanguageResponse(Chummer.TranslationService.UploadLanguageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dndjunkie.com/")]
    public partial class UploadLanguageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UploadLanguageResult;
        
        public UploadLanguageResponseBody() {
        }
        
        public UploadLanguageResponseBody(int UploadLanguageResult) {
            this.UploadLanguageResult = UploadLanguageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface translationSoapChannel : Chummer.TranslationService.translationSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class translationSoapClient : System.ServiceModel.ClientBase<Chummer.TranslationService.translationSoap>, Chummer.TranslationService.translationSoap {
        
        public translationSoapClient() {
        }
        
        public translationSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public translationSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public translationSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public translationSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Chummer.TranslationService.CanUploadLanguageResponse Chummer.TranslationService.translationSoap.CanUploadLanguage(Chummer.TranslationService.CanUploadLanguageRequest request) {
            return base.Channel.CanUploadLanguage(request);
        }
        
        public bool CanUploadLanguage(string strUserName) {
            Chummer.TranslationService.CanUploadLanguageRequest inValue = new Chummer.TranslationService.CanUploadLanguageRequest();
            inValue.Body = new Chummer.TranslationService.CanUploadLanguageRequestBody();
            inValue.Body.strUserName = strUserName;
            Chummer.TranslationService.CanUploadLanguageResponse retVal = ((Chummer.TranslationService.translationSoap)(this)).CanUploadLanguage(inValue);
            return retVal.Body.CanUploadLanguageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Chummer.TranslationService.UploadLanguageResponse Chummer.TranslationService.translationSoap.UploadLanguage(Chummer.TranslationService.UploadLanguageRequest request) {
            return base.Channel.UploadLanguage(request);
        }
        
        public int UploadLanguage(string strUserName, string strFileName, byte[] bytFile) {
            Chummer.TranslationService.UploadLanguageRequest inValue = new Chummer.TranslationService.UploadLanguageRequest();
            inValue.Body = new Chummer.TranslationService.UploadLanguageRequestBody();
            inValue.Body.strUserName = strUserName;
            inValue.Body.strFileName = strFileName;
            inValue.Body.bytFile = bytFile;
            Chummer.TranslationService.UploadLanguageResponse retVal = ((Chummer.TranslationService.translationSoap)(this)).UploadLanguage(inValue);
            return retVal.Body.UploadLanguageResult;
        }
    }
}
