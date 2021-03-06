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
    /// The interface ILocationManagementConditionRequest.
    /// </summary>
    public partial interface ILocationManagementConditionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified LocationManagementCondition using POST.
        /// </summary>
        /// <param name="locationManagementConditionToCreate">The LocationManagementCondition to create.</param>
        /// <returns>The created LocationManagementCondition.</returns>
        System.Threading.Tasks.Task<LocationManagementCondition> CreateAsync(LocationManagementCondition locationManagementConditionToCreate);        /// <summary>
        /// Creates the specified LocationManagementCondition using POST.
        /// </summary>
        /// <param name="locationManagementConditionToCreate">The LocationManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LocationManagementCondition.</returns>
        System.Threading.Tasks.Task<LocationManagementCondition> CreateAsync(LocationManagementCondition locationManagementConditionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified LocationManagementCondition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified LocationManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified LocationManagementCondition.
        /// </summary>
        /// <returns>The LocationManagementCondition.</returns>
        System.Threading.Tasks.Task<LocationManagementCondition> GetAsync();

        /// <summary>
        /// Gets the specified LocationManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LocationManagementCondition.</returns>
        System.Threading.Tasks.Task<LocationManagementCondition> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified LocationManagementCondition using PATCH.
        /// </summary>
        /// <param name="locationManagementConditionToUpdate">The LocationManagementCondition to update.</param>
        /// <returns>The updated LocationManagementCondition.</returns>
        System.Threading.Tasks.Task<LocationManagementCondition> UpdateAsync(LocationManagementCondition locationManagementConditionToUpdate);

        /// <summary>
        /// Updates the specified LocationManagementCondition using PATCH.
        /// </summary>
        /// <param name="locationManagementConditionToUpdate">The LocationManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated LocationManagementCondition.</returns>
        System.Threading.Tasks.Task<LocationManagementCondition> UpdateAsync(LocationManagementCondition locationManagementConditionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ILocationManagementConditionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ILocationManagementConditionRequest Expand(Expression<Func<LocationManagementCondition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ILocationManagementConditionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ILocationManagementConditionRequest Select(Expression<Func<LocationManagementCondition, object>> selectExpression);

    }
}
