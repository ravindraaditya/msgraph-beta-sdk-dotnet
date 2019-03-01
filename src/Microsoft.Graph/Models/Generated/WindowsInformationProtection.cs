// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Windows Information Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsInformationProtection : ManagedAppPolicy
    {
    
		///<summary>
		/// The internal WindowsInformationProtection constructor
		///</summary>
        protected internal WindowsInformationProtection()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets enforcement level.
        /// WIP enforcement level.See the Enum definition for supported values. Possible values are: noProtection, encryptAndAuditOnly, encryptAuditAndPrompt, encryptAuditAndBlock.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enforcementLevel", Required = Newtonsoft.Json.Required.Default)]
        public WindowsInformationProtectionEnforcementLevel? EnforcementLevel { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise domain.
        /// Primary enterprise domain
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseDomain", Required = Newtonsoft.Json.Required.Default)]
        public string EnterpriseDomain { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise protected domain names.
        /// List of enterprise domains to be protected
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseProtectedDomainNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionResourceCollection> EnterpriseProtectedDomainNames { get; set; }
    
        /// <summary>
        /// Gets or sets protection under lock config required.
        /// Specifies whether the protection under lock feature (also known as encrypt under pin) should be configured
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protectionUnderLockConfigRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? ProtectionUnderLockConfigRequired { get; set; }
    
        /// <summary>
        /// Gets or sets data recovery certificate.
        /// Specifies a recovery certificate that can be used for data recovery of encrypted files. This is the same as the data recovery agent(DRA) certificate for encrypting file system(EFS)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataRecoveryCertificate", Required = Newtonsoft.Json.Required.Default)]
        public WindowsInformationProtectionDataRecoveryCertificate DataRecoveryCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets revoke on unenroll disabled.
        /// This policy controls whether to revoke the WIP keys when a device unenrolls from the management service. If set to 1 (Don't revoke keys), the keys will not be revoked and the user will continue to have access to protected files after unenrollment. If the keys are not revoked, there will be no revoked file cleanup subsequently.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revokeOnUnenrollDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? RevokeOnUnenrollDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets rights management services template id.
        /// TemplateID GUID to use for RMS encryption. The RMS template allows the IT admin to configure the details about who has access to RMS-protected file and how long they have access
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rightsManagementServicesTemplateId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? RightsManagementServicesTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets azure rights management services allowed.
        /// Specifies whether to allow Azure RMS encryption for WIP
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureRightsManagementServicesAllowed", Required = Newtonsoft.Json.Required.Default)]
        public bool? AzureRightsManagementServicesAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets icons visible.
        /// Determines whether overlays are added to icons for WIP protected files in Explorer and enterprise only app tiles in the Start menu. Starting in Windows 10, version 1703 this setting also configures the visibility of the WIP icon in the title bar of a WIP-protected app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "iconsVisible", Required = Newtonsoft.Json.Required.Default)]
        public bool? IconsVisible { get; set; }
    
        /// <summary>
        /// Gets or sets protected apps.
        /// Protected applications can access enterprise data and the data handled by those applications are protected with encryption
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protectedApps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionApp> ProtectedApps { get; set; }
    
        /// <summary>
        /// Gets or sets exempt apps.
        /// Exempt applications can also access enterprise data, but the data handled by those applications are not protected. This is because some critical enterprise applications may have compatibility problems with encrypted data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exemptApps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionApp> ExemptApps { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise network domain names.
        /// This is the list of domains that comprise the boundaries of the enterprise. Data from one of these domains that is sent to a device will be considered enterprise data and protected These locations will be considered a safe destination for enterprise data to be shared to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseNetworkDomainNames", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionResourceCollection> EnterpriseNetworkDomainNames { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise proxied domains.
        /// Contains a list of Enterprise resource domains hosted in the cloud that need to be protected. Connections to these resources are considered enterprise data. If a proxy is paired with a cloud resource, traffic to the cloud resource will be routed through the enterprise network via the denoted proxy server (on Port 80). A proxy server used for this purpose must also be configured using the EnterpriseInternalProxyServers policy
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseProxiedDomains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionProxiedDomainCollection> EnterpriseProxiedDomains { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise ipranges.
        /// Sets the enterprise IP ranges that define the computers in the enterprise network. Data that comes from those computers will be considered part of the enterprise and protected. These locations will be considered a safe destination for enterprise data to be shared to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseIPRanges", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionIPRangeCollection> EnterpriseIPRanges { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise ipranges are authoritative.
        /// Boolean value that tells the client to accept the configured list and not to use heuristics to attempt to find other subnets. Default is false
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseIPRangesAreAuthoritative", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnterpriseIPRangesAreAuthoritative { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise proxy servers.
        /// This is a list of proxy servers. Any server not on this list is considered non-enterprise
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseProxyServers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionResourceCollection> EnterpriseProxyServers { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise internal proxy servers.
        /// This is the comma-separated list of internal proxy servers. For example, '157.54.14.28, 157.54.11.118, 10.202.14.167, 157.53.14.163, 157.69.210.59'. These proxies have been configured by the admin to connect to specific resources on the Internet. They are considered to be enterprise network locations. The proxies are only leveraged in configuring the EnterpriseProxiedDomains policy to force traffic to the matched domains through these proxies
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseInternalProxyServers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionResourceCollection> EnterpriseInternalProxyServers { get; set; }
    
        /// <summary>
        /// Gets or sets enterprise proxy servers are authoritative.
        /// Boolean value that tells the client to accept the configured list of proxies and not try to detect other work proxies. Default is false
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enterpriseProxyServersAreAuthoritative", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnterpriseProxyServersAreAuthoritative { get; set; }
    
        /// <summary>
        /// Gets or sets neutral domain resources.
        /// List of domain names that can used for work or personal resource
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "neutralDomainResources", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionResourceCollection> NeutralDomainResources { get; set; }
    
        /// <summary>
        /// Gets or sets indexing encrypted stores or items blocked.
        /// This switch is for the Windows Search Indexer, to allow or disallow indexing of items
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "indexingEncryptedStoresOrItemsBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? IndexingEncryptedStoresOrItemsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets smb auto encrypted file extensions.
        /// Specifies a list of file extensions, so that files with these extensions are encrypted when copying from an SMB share within the corporate boundary
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smbAutoEncryptedFileExtensions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<WindowsInformationProtectionResourceCollection> SmbAutoEncryptedFileExtensions { get; set; }
    
        /// <summary>
        /// Gets or sets is assigned.
        /// Indicates if the policy is deployed to any inclusion groups or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAssigned", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets protected app locker files.
        /// Another way to input protected apps through xml files
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protectedAppLockerFiles", Required = Newtonsoft.Json.Required.Default)]
        public IWindowsInformationProtectionProtectedAppLockerFilesCollectionPage ProtectedAppLockerFiles { get; set; }
    
        /// <summary>
        /// Gets or sets exempt app locker files.
        /// Another way to input exempt apps through xml files
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exemptAppLockerFiles", Required = Newtonsoft.Json.Required.Default)]
        public IWindowsInformationProtectionExemptAppLockerFilesCollectionPage ExemptAppLockerFiles { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Navigation property to list of security groups targeted for policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IWindowsInformationProtectionAssignmentsCollectionPage Assignments { get; set; }
    
    }
}
