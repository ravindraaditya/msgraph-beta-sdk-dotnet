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
    /// The type ApprovalSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ApprovalSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApprovalSettings"/> class.
        /// </summary>
        public ApprovalSettings()
        {
            this.ODataType = "microsoft.graph.approvalSettings";
        }

        /// <summary>
        /// Gets or sets isApprovalRequired.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isApprovalRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsApprovalRequired { get; set; }
    
        /// <summary>
        /// Gets or sets isApprovalRequiredForExtension.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isApprovalRequiredForExtension", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsApprovalRequiredForExtension { get; set; }
    
        /// <summary>
        /// Gets or sets isRequestorJustificationRequired.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isRequestorJustificationRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsRequestorJustificationRequired { get; set; }
    
        /// <summary>
        /// Gets or sets approvalMode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "approvalMode", Required = Newtonsoft.Json.Required.Default)]
        public string ApprovalMode { get; set; }
    
        /// <summary>
        /// Gets or sets approvalStages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "approvalStages", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ApprovalStage> ApprovalStages { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
