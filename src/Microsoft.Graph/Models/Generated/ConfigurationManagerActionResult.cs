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
    /// The type ConfigurationManagerActionResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConfigurationManagerActionResult : DeviceActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationManagerActionResult"/> class.
        /// </summary>
        public ConfigurationManagerActionResult()
        {
            this.ODataType = "microsoft.graph.configurationManagerActionResult";
        }

        /// <summary>
        /// Gets or sets actionDeliveryStatus.
        /// State of the action being delivered to on-prem server
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "actionDeliveryStatus", Required = Newtonsoft.Json.Required.Default)]
        public ConfigurationManagerActionDeliveryStatus? ActionDeliveryStatus { get; set; }
    
        /// <summary>
        /// Gets or sets errorCode.
        /// Error code of Configuration Manager action from client
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorCode { get; set; }
    
    }
}
