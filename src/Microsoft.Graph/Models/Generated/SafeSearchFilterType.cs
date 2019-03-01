// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph.Beta
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum SafeSearchFilterType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SafeSearchFilterType
    {
    
        /// <summary>
        /// user Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// strict
        /// </summary>
        Strict = 1,
	
        /// <summary>
        /// moderate
        /// </summary>
        Moderate = 2,
	
    }
}