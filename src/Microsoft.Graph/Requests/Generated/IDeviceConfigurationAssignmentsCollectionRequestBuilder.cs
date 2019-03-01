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
    /// The interface IDeviceConfigurationAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceConfigurationAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceConfigurationAssignmentsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceConfigurationAssignmentsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDeviceConfigurationAssignmentRequestBuilder"/> for the specified DeviceConfigurationAssignment.
        /// </summary>
        /// <param name="id">The ID for the DeviceConfigurationAssignment.</param>
        /// <returns>The <see cref="IDeviceConfigurationAssignmentRequestBuilder"/>.</returns>
        IDeviceConfigurationAssignmentRequestBuilder this[string id] { get; }

        
    }
}