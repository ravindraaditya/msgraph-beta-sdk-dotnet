// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type MacOSCredentialSingleSignOnExtension.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSCredentialSingleSignOnExtension : MacOSSingleSignOnExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MacOSCredentialSingleSignOnExtension"/> class.
        /// </summary>
        public MacOSCredentialSingleSignOnExtension()
        {
            this.ODataType = "microsoft.graph.macOSCredentialSingleSignOnExtension";
        }

        /// <summary>
        /// Gets or sets extensionIdentifier.
        /// Gets or sets the bundle ID of the app extension that performs SSO for the specified URLs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensionIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string ExtensionIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets teamIdentifier.
        /// Gets or sets the team ID of the app extension that performs SSO for the specified URLs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string TeamIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets domains.
        /// Gets or sets a list of hosts or domain names for which the app extension performs SSO.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Domains { get; set; }
    
        /// <summary>
        /// Gets or sets realm.
        /// Gets or sets the case-sensitive realm name for this profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "realm", Required = Newtonsoft.Json.Required.Default)]
        public string Realm { get; set; }
    
        /// <summary>
        /// Gets or sets configurations.
        /// Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyTypedValuePair> Configurations { get; set; }
    
    }
}
