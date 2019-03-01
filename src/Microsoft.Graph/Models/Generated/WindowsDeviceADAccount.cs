// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WindowsDeviceADAccount.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsDeviceADAccount : WindowsDeviceAccount
    {

        /// <summary>
        /// Gets or sets domainName.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainName", Required = Newtonsoft.Json.Required.Default)]
        public string DomainName { get; set; }
    
        /// <summary>
        /// Gets or sets userName.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
    }
}