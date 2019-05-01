// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Teams Device Usage User Detail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamsDeviceUsageUserDetail : Entity
    {
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date LastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeleted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets deleted date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deletedDate", Required = Newtonsoft.Json.Required.Default)]
        public Date DeletedDate { get; set; }
    
        /// <summary>
        /// Gets or sets used web.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usedWeb", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsedWeb { get; set; }
    
        /// <summary>
        /// Gets or sets used windows phone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usedWindowsPhone", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsedWindowsPhone { get; set; }
    
        /// <summary>
        /// Gets or sets usedi os.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usediOS", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsediOS { get; set; }
    
        /// <summary>
        /// Gets or sets used mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usedMac", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsedMac { get; set; }
    
        /// <summary>
        /// Gets or sets used android phone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usedAndroidPhone", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsedAndroidPhone { get; set; }
    
        /// <summary>
        /// Gets or sets used windows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usedWindows", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsedWindows { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
    }
}
