﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1026
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AntServiceStack.Plugins.DynamicPolicy
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using AntServiceStack.ProtoBuf;
    using AntServiceStack.ServiceHost;
    using System.Threading;
    using System.Threading.Tasks;
    using AntServiceStack.Common.Types;
    using AntServiceStack.se

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute("GetServiceSettingsRequest", Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = false)]
    [DataContract(Name = "GetServiceSettingsRequest", Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class GetServiceSettingsRequestType
    {

        private string serviceNameField;

        private string serviceNamespaceField;

        [DataMember()]
        [ProtoMember(1)]
        public string ServiceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }

        [DataMember()]
        [ProtoMember(2)]
        public string ServiceNamespace
        {
            get
            {
                return this.serviceNamespaceField;
            }
            set
            {
                this.serviceNamespaceField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute("GetServiceSettingsResponse", Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = false)]
    [DataContract(Name = "GetServiceSettingsResponse", Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class GetServiceSettingsResponseType : IHasResponseStatus
    {

        private ServiceSettingsDTO serviceSettingsField;

        private ResponseStatusType responseStatusField;

        [DataMember()]
        [ProtoMember(1)]
        public ServiceSettingsDTO ServiceSettings
        {
            get
            {
                return this.serviceSettingsField;
            }
            set
            {
                this.serviceSettingsField = value;
            }
        }

        [DataMember()]
        [ProtoMember(2)]
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class ServiceSettingsDTO
    {

        private bool enableIPWhiteListCheckField;

        private List<string> iPWhiteListField;

        private bool enableIPRateLimitingCheckField;

        private int iPRateLimitField;

        private bool enableAppIdWhiteListCheckField;

        private List<string> appIdWhiteListField;

        private bool enableAppIdRateLimitingCheckField;

        private int appIdRateLimitField;

        private List<OperationTimeoutSettingDTO> operationTimeoutSettingsField;

        private bool circuitBreakerForceClosedField;

        private bool logErrorWithRequestInfoField;

        private int threadPoolSizeField;

        private bool logCommonRequestInfoField;

        private bool enableServiceRateLimitingCheckField;

        private int serviceRateLimitField;

        private bool enableOperationRateLimitingCheckField;

        private List<OperationRateLimitSettingDTO> operationRateLimitSettingsField;

        private bool enableAppIdBlackListCheckField;

        private List<string> appIdBlackListField;

        private bool enableIPBlackListCheckField;

        private List<string> iPBlackListField;

        private List<IPRateLimitSettingDTO> iPRateLimitSettingsField;

        private List<AppIdRateLimitSettingDTO> appIdRateLimitSettingsField;

        [DataMember()]
        [ProtoMember(1)]
        public bool EnableIPWhiteListCheck
        {
            get
            {
                return this.enableIPWhiteListCheckField;
            }
            set
            {
                this.enableIPWhiteListCheckField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("IPWhiteList")]
        [DataMember()]
        [ProtoMember(2)]
        public List<string> IPWhiteList
        {
            get
            {
                if ((this.iPWhiteListField == null))
                {
                    this.iPWhiteListField = new List<string>();
                }
                return this.iPWhiteListField;
            }
            set
            {
                this.iPWhiteListField = value;
            }
        }

        [DataMember()]
        [ProtoMember(3)]
        public bool EnableIPRateLimitingCheck
        {
            get
            {
                return this.enableIPRateLimitingCheckField;
            }
            set
            {
                this.enableIPRateLimitingCheckField = value;
            }
        }

        [DataMember()]
        [ProtoMember(4)]
        public int IPRateLimit
        {
            get
            {
                return this.iPRateLimitField;
            }
            set
            {
                this.iPRateLimitField = value;
            }
        }

        [DataMember()]
        [ProtoMember(5)]
        public bool EnableAppIdWhiteListCheck
        {
            get
            {
                return this.enableAppIdWhiteListCheckField;
            }
            set
            {
                this.enableAppIdWhiteListCheckField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("AppIdWhiteList")]
        [DataMember()]
        [ProtoMember(6)]
        public List<string> AppIdWhiteList
        {
            get
            {
                if ((this.appIdWhiteListField == null))
                {
                    this.appIdWhiteListField = new List<string>();
                }
                return this.appIdWhiteListField;
            }
            set
            {
                this.appIdWhiteListField = value;
            }
        }

        [DataMember()]
        [ProtoMember(7)]
        public bool EnableAppIdRateLimitingCheck
        {
            get
            {
                return this.enableAppIdRateLimitingCheckField;
            }
            set
            {
                this.enableAppIdRateLimitingCheckField = value;
            }
        }

        [DataMember()]
        [ProtoMember(8)]
        public int AppIdRateLimit
        {
            get
            {
                return this.appIdRateLimitField;
            }
            set
            {
                this.appIdRateLimitField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("OperationTimeoutSettings")]
        [DataMember()]
        [ProtoMember(9)]
        public List<OperationTimeoutSettingDTO> OperationTimeoutSettings
        {
            get
            {
                if ((this.operationTimeoutSettingsField == null))
                {
                    this.operationTimeoutSettingsField = new List<OperationTimeoutSettingDTO>();
                }
                return this.operationTimeoutSettingsField;
            }
            set
            {
                this.operationTimeoutSettingsField = value;
            }
        }

        [DataMember()]
        [ProtoMember(10)]
        public bool CircuitBreakerForceClosed
        {
            get
            {
                return this.circuitBreakerForceClosedField;
            }
            set
            {
                this.circuitBreakerForceClosedField = value;
            }
        }

        [DataMember()]
        [ProtoMember(11)]
        public bool LogErrorWithRequestInfo
        {
            get
            {
                return this.logErrorWithRequestInfoField;
            }
            set
            {
                this.logErrorWithRequestInfoField = value;
            }
        }

        [DataMember()]
        [ProtoMember(12)]
        public int ThreadPoolSize
        {
            get
            {
                return this.threadPoolSizeField;
            }
            set
            {
                this.threadPoolSizeField = value;
            }
        }

        [DataMember()]
        [ProtoMember(13)]
        public bool LogCommonRequestInfo
        {
            get
            {
                return this.logCommonRequestInfoField;
            }
            set
            {
                this.logCommonRequestInfoField = value;
            }
        }

        [DataMember()]
        [ProtoMember(14)]
        public bool EnableServiceRateLimitingCheck
        {
            get
            {
                return this.enableServiceRateLimitingCheckField;
            }
            set
            {
                this.enableServiceRateLimitingCheckField = value;
            }
        }

        [DataMember()]
        [ProtoMember(15)]
        public int ServiceRateLimit
        {
            get
            {
                return this.serviceRateLimitField;
            }
            set
            {
                this.serviceRateLimitField = value;
            }
        }

        [DataMember()]
        [ProtoMember(16)]
        public bool EnableOperationRateLimitingCheck
        {
            get
            {
                return this.enableOperationRateLimitingCheckField;
            }
            set
            {
                this.enableOperationRateLimitingCheckField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("OperationRateLimitSettings")]
        [DataMember()]
        [ProtoMember(17)]
        public List<OperationRateLimitSettingDTO> OperationRateLimitSettings
        {
            get
            {
                if ((this.operationRateLimitSettingsField == null))
                {
                    this.operationRateLimitSettingsField = new List<OperationRateLimitSettingDTO>();
                }
                return this.operationRateLimitSettingsField;
            }
            set
            {
                this.operationRateLimitSettingsField = value;
            }
        }

        [DataMember()]
        [ProtoMember(18)]
        public bool EnableAppIdBlackListCheck
        {
            get
            {
                return this.enableAppIdBlackListCheckField;
            }
            set
            {
                this.enableAppIdBlackListCheckField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("AppIdBlackList")]
        [DataMember()]
        [ProtoMember(19)]
        public List<string> AppIdBlackList
        {
            get
            {
                if ((this.appIdBlackListField == null))
                {
                    this.appIdBlackListField = new List<string>();
                }
                return this.appIdBlackListField;
            }
            set
            {
                this.appIdBlackListField = value;
            }
        }

        [DataMember()]
        [ProtoMember(20)]
        public bool EnableIPBlackListCheck
        {
            get
            {
                return this.enableIPBlackListCheckField;
            }
            set
            {
                this.enableIPBlackListCheckField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("IPBlackList")]
        [DataMember()]
        [ProtoMember(21)]
        public List<string> IPBlackList
        {
            get
            {
                if ((this.iPBlackListField == null))
                {
                    this.iPBlackListField = new List<string>();
                }
                return this.iPBlackListField;
            }
            set
            {
                this.iPBlackListField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("IPRateLimitSettings")]
        [DataMember()]
        [ProtoMember(22)]
        public List<IPRateLimitSettingDTO> IPRateLimitSettings
        {
            get
            {
                if ((this.iPRateLimitSettingsField == null))
                {
                    this.iPRateLimitSettingsField = new List<IPRateLimitSettingDTO>();
                }
                return this.iPRateLimitSettingsField;
            }
            set
            {
                this.iPRateLimitSettingsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("AppIdRateLimitSettings")]
        [DataMember()]
        [ProtoMember(23)]
        public List<AppIdRateLimitSettingDTO> AppIdRateLimitSettings
        {
            get
            {
                if ((this.appIdRateLimitSettingsField == null))
                {
                    this.appIdRateLimitSettingsField = new List<AppIdRateLimitSettingDTO>();
                }
                return this.appIdRateLimitSettingsField;
            }
            set
            {
                this.appIdRateLimitSettingsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class OperationTimeoutSettingDTO
    {

        private string operationNameField;

        private int timeoutField;

        [DataMember()]
        [ProtoMember(1)]
        public string OperationName
        {
            get
            {
                return this.operationNameField;
            }
            set
            {
                this.operationNameField = value;
            }
        }

        [DataMember()]
        [ProtoMember(2)]
        public int Timeout
        {
            get
            {
                return this.timeoutField;
            }
            set
            {
                this.timeoutField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class OperationRateLimitSettingDTO
    {

        private string operationNameField;

        private int rateLimitField;

        [DataMember()]
        [ProtoMember(1)]
        public string OperationName
        {
            get
            {
                return this.operationNameField;
            }
            set
            {
                this.operationNameField = value;
            }
        }

        [DataMember()]
        [ProtoMember(2)]
        public int RateLimit
        {
            get
            {
                return this.rateLimitField;
            }
            set
            {
                this.rateLimitField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class IPRateLimitSettingDTO
    {

        private string ipField;

        private int rateLimitField;

        [DataMember()]
        [ProtoMember(1)]
        public string IP
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }

        [DataMember()]
        [ProtoMember(2)]
        public int RateLimit
        {
            get
            {
                return this.rateLimitField;
            }
            set
            {
                this.rateLimitField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class AppIdRateLimitSettingDTO
    {

        private string appIdField;

        private int rateLimitField;

        [DataMember()]
        [ProtoMember(1)]
        public string AppId
        {
            get
            {
                return this.appIdField;
            }
            set
            {
                this.appIdField = value;
            }
        }

        [DataMember()]
        [ProtoMember(2)]
        public int RateLimit
        {
            get
            {
                return this.rateLimitField;
            }
            set
            {
                this.rateLimitField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute("GetSnapshotRequest", Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = false)]
    [DataContract(Name = "GetSnapshotRequest", Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class GetSnapshotRequestType
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute("GetSnapshotResponse", Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = false)]
    [DataContract(Name = "GetSnapshotResponse", Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class GetSnapshotResponseType : IHasResponseStatus
    {

        private string repositoryServiceUrlField;

        private string policyEnvironmentField;

        private int policySyncIntervalField;

        private string lookupServiceSettingsRepositoryServiceOperationUrlField;

        private string serviceStartTimeField;

        private long totalSyncCountField;

        private long succeededSyncCountField;

        private long failedSyncCountField;

        private bool isPolicySyncRunningField;

        private string lastSyncTimeField;

        private bool lastSyncSucceededField;

        private string lastSyncErrorCodeField;

        private string lastSyncErrorMessageField;

        private int countField;

        private List<ServiceSettingsCacheDTO> serviceSettingsCacheField;

        private ResponseStatusType responseStatusField;

        [DataMember()]
        [ProtoMember(1)]
        public string RepositoryServiceUrl
        {
            get
            {
                return this.repositoryServiceUrlField;
            }
            set
            {
                this.repositoryServiceUrlField = value;
            }
        }

        [DataMember()]
        [ProtoMember(2)]
        public string PolicyEnvironment
        {
            get
            {
                return this.policyEnvironmentField;
            }
            set
            {
                this.policyEnvironmentField = value;
            }
        }

        [DataMember()]
        [ProtoMember(3)]
        public int PolicySyncInterval
        {
            get
            {
                return this.policySyncIntervalField;
            }
            set
            {
                this.policySyncIntervalField = value;
            }
        }

        [DataMember()]
        [ProtoMember(4)]
        public string LookupServiceSettingsRepositoryServiceOperationUrl
        {
            get
            {
                return this.lookupServiceSettingsRepositoryServiceOperationUrlField;
            }
            set
            {
                this.lookupServiceSettingsRepositoryServiceOperationUrlField = value;
            }
        }

        [DataMember()]
        [ProtoMember(5)]
        public string ServiceStartTime
        {
            get
            {
                return this.serviceStartTimeField;
            }
            set
            {
                this.serviceStartTimeField = value;
            }
        }

        [DataMember()]
        [ProtoMember(6)]
        public long TotalSyncCount
        {
            get
            {
                return this.totalSyncCountField;
            }
            set
            {
                this.totalSyncCountField = value;
            }
        }

        [DataMember()]
        [ProtoMember(7)]
        public long SucceededSyncCount
        {
            get
            {
                return this.succeededSyncCountField;
            }
            set
            {
                this.succeededSyncCountField = value;
            }
        }

        [DataMember()]
        [ProtoMember(8)]
        public long FailedSyncCount
        {
            get
            {
                return this.failedSyncCountField;
            }
            set
            {
                this.failedSyncCountField = value;
            }
        }

        [DataMember()]
        [ProtoMember(9)]
        public bool IsPolicySyncRunning
        {
            get
            {
                return this.isPolicySyncRunningField;
            }
            set
            {
                this.isPolicySyncRunningField = value;
            }
        }

        [DataMember()]
        [ProtoMember(10)]
        public string LastSyncTime
        {
            get
            {
                return this.lastSyncTimeField;
            }
            set
            {
                this.lastSyncTimeField = value;
            }
        }

        [DataMember()]
        [ProtoMember(11)]
        public bool LastSyncSucceeded
        {
            get
            {
                return this.lastSyncSucceededField;
            }
            set
            {
                this.lastSyncSucceededField = value;
            }
        }

        [DataMember()]
        [ProtoMember(12)]
        public string LastSyncErrorCode
        {
            get
            {
                return this.lastSyncErrorCodeField;
            }
            set
            {
                this.lastSyncErrorCodeField = value;
            }
        }

        [DataMember()]
        [ProtoMember(13)]
        public string LastSyncErrorMessage
        {
            get
            {
                return this.lastSyncErrorMessageField;
            }
            set
            {
                this.lastSyncErrorMessageField = value;
            }
        }

        [DataMember()]
        [ProtoMember(14)]
        public int Count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ServiceSettingsCache")]
        [DataMember()]
        [ProtoMember(15)]
        public List<ServiceSettingsCacheDTO> ServiceSettingsCache
        {
            get
            {
                if ((this.serviceSettingsCacheField == null))
                {
                    this.serviceSettingsCacheField = new List<ServiceSettingsCacheDTO>();
                }
                return this.serviceSettingsCacheField;
            }
            set
            {
                this.serviceSettingsCacheField = value;
            }
        }

        [DataMember()]
        [ProtoMember(16)]
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1026")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1", IsNullable = true)]
    [DataContract(Namespace = "http://soa.ctrip.com/framework/soa/policyservice/v1")]
    [ProtoContract()]
    public partial class ServiceSettingsCacheDTO
    {

        private string identityField;

        private ServiceSettingsDTO settingsField;

        [DataMember()]
        [ProtoMember(1)]
        public string Identity
        {
            get
            {
                return this.identityField;
            }
            set
            {
                this.identityField = value;
            }
        }

        [DataMember()]
        [ProtoMember(2)]
        public ServiceSettingsDTO Settings
        {
            get
            {
                return this.settingsField;
            }
            set
            {
                this.settingsField = value;
            }
        }
    }

    /// <summary>
    /// Service client auto-generated by SOA tool, DO NOT CHANGE!
    /// 
    /// 
    /// </summary>
    public class PolicyServiceClient : ServiceClientBase<PolicyServiceClient>
    {

        public const string CodeGeneratorVersion = "2.0.6.1";

        public const string OriginalServiceName = "PolicyService";

        public const string OriginalServiceNamespace = "http://soa.ctrip.com/framework/soa/policyservice/v1";

        public const string OriginalServiceType = "NonSLB";

        private PolicyServiceClient(string baseUri) :
                base(baseUri)
        {
        }

        private PolicyServiceClient(string serviceName, string serviceNamespace, string subEnv) :
                base(serviceName, serviceNamespace, subEnv)
        {
        }

        public virtual CheckHealthResponseType CheckHealth(CheckHealthRequestType checkHealthIn)
        {
            return base.Invoke<CheckHealthResponseType>("CheckHealth", checkHealthIn);
        }

        public virtual Task<CheckHealthResponseType> CreateAsyncTaskOfCheckHealth(CheckHealthRequestType checkHealthIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<CheckHealthRequestType, CheckHealthResponseType>("CheckHealth", checkHealthIn, cancellationToken, taskCreationOptions);
        }

        public virtual Task<CheckHealthResponseType> StartIOCPTaskOfCheckHealth(CheckHealthRequestType checkHealthIn)
        {
            return base.StartIOCPTask<CheckHealthResponseType>("CheckHealth", checkHealthIn);
        }

        public virtual GetServiceSettingsResponseType GetServiceSettings(GetServiceSettingsRequestType getServiceSettingsIn)
        {
            return base.Invoke<GetServiceSettingsResponseType>("GetServiceSettings", getServiceSettingsIn);
        }

        public virtual Task<GetServiceSettingsResponseType> CreateAsyncTaskOfGetServiceSettings(GetServiceSettingsRequestType getServiceSettingsIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<GetServiceSettingsRequestType, GetServiceSettingsResponseType>("GetServiceSettings", getServiceSettingsIn, cancellationToken, taskCreationOptions);
        }

        public virtual Task<GetServiceSettingsResponseType> StartIOCPTaskOfGetServiceSettings(GetServiceSettingsRequestType getServiceSettingsIn)
        {
            return base.StartIOCPTask<GetServiceSettingsResponseType>("GetServiceSettings", getServiceSettingsIn);
        }

        public virtual GetSnapshotResponseType GetSnapshot(GetSnapshotRequestType getSnapshotIn)
        {
            return base.Invoke<GetSnapshotResponseType>("GetSnapshot", getSnapshotIn);
        }

        public virtual Task<GetSnapshotResponseType> CreateAsyncTaskOfGetSnapshot(GetSnapshotRequestType getSnapshotIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<GetSnapshotRequestType, GetSnapshotResponseType>("GetSnapshot", getSnapshotIn, cancellationToken, taskCreationOptions);
        }

        public virtual Task<GetSnapshotResponseType> StartIOCPTaskOfGetSnapshot(GetSnapshotRequestType getSnapshotIn)
        {
            return base.StartIOCPTask<GetSnapshotResponseType>("GetSnapshot", getSnapshotIn);
        }
    }
}
