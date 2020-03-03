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
    /// The type IosRedirectSingleSignOnExtension.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosRedirectSingleSignOnExtension : IosSingleSignOnExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosRedirectSingleSignOnExtension"/> class.
        /// </summary>
        public IosRedirectSingleSignOnExtension()
        {
            this.ODataType = "microsoft.graph.iosRedirectSingleSignOnExtension";
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
        /// Gets or sets configurations.
        /// Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyTypedValuePair> Configurations { get; set; }
    
        /// <summary>
        /// Gets or sets urlPrefixes.
        /// One or more URL prefixes of identity providers on whose behalf the app extension performs single sign-on. URLs must begin with http:// or https://. All URL prefixes must be unique for all profiles.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "urlPrefixes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> UrlPrefixes { get; set; }
    
    }
}
