// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceCompliancePolicyStateRequest.
    /// </summary>
    public partial interface IDeviceCompliancePolicyStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceCompliancePolicyState using PUT.
        /// </summary>
        /// <param name="deviceCompliancePolicyStateToCreate">The DeviceCompliancePolicyState to create.</param>
        /// <returns>The created DeviceCompliancePolicyState.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyState> CreateAsync(DeviceCompliancePolicyState deviceCompliancePolicyStateToCreate);        /// <summary>
        /// Creates the specified DeviceCompliancePolicyState using PUT.
        /// </summary>
        /// <param name="deviceCompliancePolicyStateToCreate">The DeviceCompliancePolicyState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicyState.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyState> CreateAsync(DeviceCompliancePolicyState deviceCompliancePolicyStateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyState.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyState.
        /// </summary>
        /// <returns>The DeviceCompliancePolicyState.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyState> GetAsync();

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicyState.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyState using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyStateToUpdate">The DeviceCompliancePolicyState to update.</param>
        /// <returns>The updated DeviceCompliancePolicyState.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyState> UpdateAsync(DeviceCompliancePolicyState deviceCompliancePolicyStateToUpdate);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyState using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyStateToUpdate">The DeviceCompliancePolicyState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceCompliancePolicyState.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyState> UpdateAsync(DeviceCompliancePolicyState deviceCompliancePolicyStateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyStateRequest Expand(Expression<Func<DeviceCompliancePolicyState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyStateRequest Select(Expression<Func<DeviceCompliancePolicyState, object>> selectExpression);

    }
}