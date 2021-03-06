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
    /// The enum GroupAccessType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum GroupAccessType
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Private
        /// </summary>
        Private = 1,
	
        /// <summary>
        /// Secret
        /// </summary>
        Secret = 2,
	
        /// <summary>
        /// Public
        /// </summary>
        Public = 3,
	
    }
}
