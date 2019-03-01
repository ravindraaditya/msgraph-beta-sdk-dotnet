// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum LocationUniqueIdType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LocationUniqueIdType
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// location Store
        /// </summary>
        LocationStore = 1,
	
        /// <summary>
        /// directory
        /// </summary>
        Directory = 2,
	
        /// <summary>
        /// private
        /// </summary>
        Private = 3,
	
        /// <summary>
        /// bing
        /// </summary>
        Bing = 4,
	
    }
}