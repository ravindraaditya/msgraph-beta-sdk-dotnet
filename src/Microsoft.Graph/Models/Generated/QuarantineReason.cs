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
    /// The enum QuarantineReason.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum QuarantineReason
    {
    
        /// <summary>
        /// Encountered Base Escrow Threshold
        /// </summary>
        EncounteredBaseEscrowThreshold = 0,
	
        /// <summary>
        /// Encountered Total Escrow Threshold
        /// </summary>
        EncounteredTotalEscrowThreshold = 1,
	
        /// <summary>
        /// Encountered Escrow Proportion Threshold
        /// </summary>
        EncounteredEscrowProportionThreshold = 2,
	
        /// <summary>
        /// Encountered Quarantine Exception
        /// </summary>
        EncounteredQuarantineException = 4,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 8,
	
        /// <summary>
        /// Quarantined On Demand
        /// </summary>
        QuarantinedOnDemand = 16,
	
        /// <summary>
        /// Too Many Deletes
        /// </summary>
        TooManyDeletes = 32,
	
    }
}
