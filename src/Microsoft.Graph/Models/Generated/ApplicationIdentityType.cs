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
    /// The enum ApplicationIdentityType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ApplicationIdentityType
    {
    
        /// <summary>
        /// Aad Application
        /// </summary>
        AadApplication = 0,
	
        /// <summary>
        /// Bot
        /// </summary>
        Bot = 1,
	
        /// <summary>
        /// Tenant Bot
        /// </summary>
        TenantBot = 2,
	
        /// <summary>
        /// Office365Connector
        /// </summary>
        Office365Connector = 3,
	
        /// <summary>
        /// Outgoing Webhook
        /// </summary>
        OutgoingWebhook = 4,
	
    }
}
