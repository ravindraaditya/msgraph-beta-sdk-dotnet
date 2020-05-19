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
    /// The enum ConditionalAccessClientApp.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ConditionalAccessClientApp
    {
    
        /// <summary>
        /// All
        /// </summary>
        All = 0,
	
        /// <summary>
        /// Browser
        /// </summary>
        Browser = 1,
	
        /// <summary>
        /// Modern
        /// </summary>
        Modern = 2,
	
        /// <summary>
        /// Mobile Apps And Desktop Clients
        /// </summary>
        MobileAppsAndDesktopClients = 3,
	
        /// <summary>
        /// Exchange Active Sync
        /// </summary>
        ExchangeActiveSync = 4,
	
        /// <summary>
        /// Eas Supported
        /// </summary>
        EasSupported = 5,
	
        /// <summary>
        /// Eas Unsupported
        /// </summary>
        EasUnsupported = 6,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 7,
	
    }
}
