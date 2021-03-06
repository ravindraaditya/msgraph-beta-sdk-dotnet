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
    /// The type Approval.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Approval : Entity
    {
    
		///<summary>
		/// The Approval constructor
		///</summary>
        public Approval()
        {
            this.ODataType = "microsoft.graph.approval";
        }
	
        /// <summary>
        /// Gets or sets pending steps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingSteps", Required = Newtonsoft.Json.Required.Default)]
        public IApprovalPendingStepsCollectionPage PendingSteps { get; set; }
    
        /// <summary>
        /// Gets or sets completed steps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completedSteps", Required = Newtonsoft.Json.Required.Default)]
        public IApprovalCompletedStepsCollectionPage CompletedSteps { get; set; }
    
    }
}

