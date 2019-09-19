// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum AnalyticsActivityType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AnalyticsActivityType
    {
    
        /// <summary>
        /// Email
        /// </summary>
        Email = 0,
	
        /// <summary>
        /// Meeting
        /// </summary>
        Meeting = 1,
	
        /// <summary>
        /// Focus
        /// </summary>
        Focus = 2,
	
        /// <summary>
        /// Chat
        /// </summary>
        Chat = 3,
	
        /// <summary>
        /// Call
        /// </summary>
        Call = 4,
	
    }
}
