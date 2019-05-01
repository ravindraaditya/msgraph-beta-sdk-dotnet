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
    /// The type IosWebContentFilterAutoFilter.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosWebContentFilterAutoFilter : IosWebContentFilterBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosWebContentFilterAutoFilter"/> class.
        /// </summary>
        public IosWebContentFilterAutoFilter()
        {
            this.ODataType = "microsoft.graph.iosWebContentFilterAutoFilter";
        }

        /// <summary>
        /// Gets or sets allowedUrls.
        /// Additional URLs allowed for access
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedUrls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AllowedUrls { get; set; }
    
        /// <summary>
        /// Gets or sets blockedUrls.
        /// Additional URLs blocked for access
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockedUrls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BlockedUrls { get; set; }
    
    }
}