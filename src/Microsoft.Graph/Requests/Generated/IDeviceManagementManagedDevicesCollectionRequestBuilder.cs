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
    /// The interface IDeviceManagementManagedDevicesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementManagedDevicesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementManagedDevicesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementManagedDevicesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IManagedDeviceRequestBuilder"/> for the specified ManagedDevice.
        /// </summary>
        /// <param name="id">The ID for the ManagedDevice.</param>
        /// <returns>The <see cref="IManagedDeviceRequestBuilder"/>.</returns>
        IManagedDeviceRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for ManagedDeviceExecuteAction.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceExecuteActionRequestBuilder"/>.</returns>
        IManagedDeviceExecuteActionRequestBuilder ExecuteAction(
            ManagedDeviceRemoteAction actionName,
            bool? keepEnrollmentData = null,
            bool? keepUserData = null,
            IEnumerable<string> deviceIds = null,
            string notificationTitle = null,
            string notificationBody = null);
    }
}
