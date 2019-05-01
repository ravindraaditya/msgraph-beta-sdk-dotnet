// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDefaultDeviceCompliancePolicyRequest.
    /// </summary>
    public partial interface IDefaultDeviceCompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DefaultDeviceCompliancePolicy using PUT.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToCreate">The DefaultDeviceCompliancePolicy to create.</param>
        /// <returns>The created DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> CreateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToCreate);        /// <summary>
        /// Creates the specified DefaultDeviceCompliancePolicy using PUT.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToCreate">The DefaultDeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> CreateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <returns>The DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> GetAsync();

        /// <summary>
        /// Gets the specified DefaultDeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy to update.</param>
        /// <returns>The updated DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> UpdateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate);

        /// <summary>
        /// Updates the specified DefaultDeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="defaultDeviceCompliancePolicyToUpdate">The DefaultDeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DefaultDeviceCompliancePolicy.</returns>
        System.Threading.Tasks.Task<DefaultDeviceCompliancePolicy> UpdateAsync(DefaultDeviceCompliancePolicy defaultDeviceCompliancePolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDefaultDeviceCompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDefaultDeviceCompliancePolicyRequest Expand(Expression<Func<DefaultDeviceCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDefaultDeviceCompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDefaultDeviceCompliancePolicyRequest Select(Expression<Func<DefaultDeviceCompliancePolicy, object>> selectExpression);

    }
}