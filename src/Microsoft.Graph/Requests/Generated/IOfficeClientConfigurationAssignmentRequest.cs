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
    /// The interface IOfficeClientConfigurationAssignmentRequest.
    /// </summary>
    public partial interface IOfficeClientConfigurationAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OfficeClientConfigurationAssignment using PUT.
        /// </summary>
        /// <param name="officeClientConfigurationAssignmentToCreate">The OfficeClientConfigurationAssignment to create.</param>
        /// <returns>The created OfficeClientConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<OfficeClientConfigurationAssignment> CreateAsync(OfficeClientConfigurationAssignment officeClientConfigurationAssignmentToCreate);        /// <summary>
        /// Creates the specified OfficeClientConfigurationAssignment using PUT.
        /// </summary>
        /// <param name="officeClientConfigurationAssignmentToCreate">The OfficeClientConfigurationAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OfficeClientConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<OfficeClientConfigurationAssignment> CreateAsync(OfficeClientConfigurationAssignment officeClientConfigurationAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OfficeClientConfigurationAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OfficeClientConfigurationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OfficeClientConfigurationAssignment.
        /// </summary>
        /// <returns>The OfficeClientConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<OfficeClientConfigurationAssignment> GetAsync();

        /// <summary>
        /// Gets the specified OfficeClientConfigurationAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OfficeClientConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<OfficeClientConfigurationAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OfficeClientConfigurationAssignment using PATCH.
        /// </summary>
        /// <param name="officeClientConfigurationAssignmentToUpdate">The OfficeClientConfigurationAssignment to update.</param>
        /// <returns>The updated OfficeClientConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<OfficeClientConfigurationAssignment> UpdateAsync(OfficeClientConfigurationAssignment officeClientConfigurationAssignmentToUpdate);

        /// <summary>
        /// Updates the specified OfficeClientConfigurationAssignment using PATCH.
        /// </summary>
        /// <param name="officeClientConfigurationAssignmentToUpdate">The OfficeClientConfigurationAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OfficeClientConfigurationAssignment.</returns>
        System.Threading.Tasks.Task<OfficeClientConfigurationAssignment> UpdateAsync(OfficeClientConfigurationAssignment officeClientConfigurationAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeClientConfigurationAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeClientConfigurationAssignmentRequest Expand(Expression<Func<OfficeClientConfigurationAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeClientConfigurationAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOfficeClientConfigurationAssignmentRequest Select(Expression<Func<OfficeClientConfigurationAssignment, object>> selectExpression);

    }
}