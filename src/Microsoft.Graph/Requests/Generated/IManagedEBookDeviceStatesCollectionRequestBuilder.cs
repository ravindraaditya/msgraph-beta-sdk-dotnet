// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedEBookDeviceStatesCollectionRequestBuilder.
    /// </summary>
    public partial interface IManagedEBookDeviceStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedEBookDeviceStatesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedEBookDeviceStatesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceInstallStateRequestBuilder"/> for the specified DeviceInstallState.
        /// </summary>
        /// <param name="id">The ID for the DeviceInstallState.</param>
        /// <returns>The <see cref="IDeviceInstallStateRequestBuilder"/>.</returns>
        IDeviceInstallStateRequestBuilder this[string id] { get; }

        
    }
}