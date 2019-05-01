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
    /// The enum AppleSubjectNameFormat.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AppleSubjectNameFormat
    {
    
        /// <summary>
        /// Common Name
        /// </summary>
        CommonName = 0,
	
        /// <summary>
        /// Common Name As Email
        /// </summary>
        CommonNameAsEmail = 1,
	
        /// <summary>
        /// Custom
        /// </summary>
        Custom = 2,
	
        /// <summary>
        /// Common Name Including Email
        /// </summary>
        CommonNameIncludingEmail = 3,
	
        /// <summary>
        /// Common Name As IMEI
        /// </summary>
        CommonNameAsIMEI = 5,
	
        /// <summary>
        /// Common Name As Serial Number
        /// </summary>
        CommonNameAsSerialNumber = 6,
	
    }
}