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
    /// The enum VideoResolutionFormat.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum VideoResolutionFormat
    {
    
        /// <summary>
        /// Sd360p
        /// </summary>
        Sd360p = 0,
	
        /// <summary>
        /// Sd540p
        /// </summary>
        Sd540p = 1,
	
        /// <summary>
        /// Hd720p
        /// </summary>
        Hd720p = 2,
	
        /// <summary>
        /// Hd1080p
        /// </summary>
        Hd1080p = 3,
	
    }
}