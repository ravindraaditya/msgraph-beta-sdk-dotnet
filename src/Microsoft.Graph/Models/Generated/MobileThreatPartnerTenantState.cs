// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum MobileThreatPartnerTenantState.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum MobileThreatPartnerTenantState
    {
    
        /// <summary>
        /// unavailable
        /// </summary>
        Unavailable = 0,
	
        /// <summary>
        /// available
        /// </summary>
        Available = 1,
	
        /// <summary>
        /// enabled
        /// </summary>
        Enabled = 2,
	
        /// <summary>
        /// unresponsive
        /// </summary>
        Unresponsive = 3,
	
    }
}