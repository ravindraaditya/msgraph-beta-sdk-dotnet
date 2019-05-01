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
    /// The enum UpdateClassification.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum UpdateClassification
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Recommended And Important
        /// </summary>
        RecommendedAndImportant = 1,
	
        /// <summary>
        /// Important
        /// </summary>
        Important = 2,
	
        /// <summary>
        /// None
        /// </summary>
        None = 3,
	
    }
}