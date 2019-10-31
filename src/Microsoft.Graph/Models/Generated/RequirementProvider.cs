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
    /// The enum RequirementProvider.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RequirementProvider
    {
    
        /// <summary>
        /// MFA
        /// </summary>
        MFA = 0,
	
        /// <summary>
        /// CA
        /// </summary>
        CA = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}