// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ICommsApplicationCallsCollectionRequestBuilder.
    /// </summary>
    public partial interface ICommsApplicationCallsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ICommsApplicationCallsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ICommsApplicationCallsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ICallRequestBuilder"/> for the specified Call.
        /// </summary>
        /// <param name="id">The ID for the Call.</param>
        /// <returns>The <see cref="ICallRequestBuilder"/>.</returns>
        ICallRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for CallLogTeleconferenceDeviceQuality.
        /// </summary>
        /// <returns>The <see cref="ICallLogTeleconferenceDeviceQualityRequestBuilder"/>.</returns>
        ICallLogTeleconferenceDeviceQualityRequestBuilder LogTeleconferenceDeviceQuality(
            TeleconferenceDeviceQuality quality);
    }
}
