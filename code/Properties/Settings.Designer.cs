﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRMSecurityProvider.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://crm:5555/mscrmservices/2006/crmservice.asmx")]
        public string CRMSecurityProvider_crm3_webservice_CrmService {
            get {
                return ((string)(this["CRMSecurityProvider_crm3_webservice_CrmService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://crm:5555/mscrmservices/2006/metadataservice.asmx")]
        public string CRMSecurityProvider_crm3_metadataservice_MetadataService {
            get {
                return ((string)(this["CRMSecurityProvider_crm3_metadataservice_MetadataService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://crm.remote:5555/mscrmservices/2007/crmservice.asmx")]
        public string CRMSecurityProvider_crm4_webservice_CrmService {
            get {
                return ((string)(this["CRMSecurityProvider_crm4_webservice_CrmService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://crm.remote:5555/mscrmservices/2007/metadataservice.asmx")]
        public string CRMSecurityProvider_crm4_metadataservice_MetadataService {
            get {
                return ((string)(this["CRMSecurityProvider_crm4_metadataservice_MetadataService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://crm.remote:5555/mscrmservices/2007/AD/crmdiscoveryservice.asmx")]
        public string CRMSecurityProvider_crm4_discoveryservice_CrmDiscoveryService {
            get {
                return ((string)(this["CRMSecurityProvider_crm4_discoveryservice_CrmDiscoveryService"]));
            }
        }
    }
}
