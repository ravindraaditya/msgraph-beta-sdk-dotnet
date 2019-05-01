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
    /// The interface ISynchronizationRequest.
    /// </summary>
    public partial interface ISynchronizationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Synchronization using PUT.
        /// </summary>
        /// <param name="synchronizationToCreate">The Synchronization to create.</param>
        /// <returns>The created Synchronization.</returns>
        System.Threading.Tasks.Task<Synchronization> CreateAsync(Synchronization synchronizationToCreate);        /// <summary>
        /// Creates the specified Synchronization using PUT.
        /// </summary>
        /// <param name="synchronizationToCreate">The Synchronization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Synchronization.</returns>
        System.Threading.Tasks.Task<Synchronization> CreateAsync(Synchronization synchronizationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Synchronization.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Synchronization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Synchronization.
        /// </summary>
        /// <returns>The Synchronization.</returns>
        System.Threading.Tasks.Task<Synchronization> GetAsync();

        /// <summary>
        /// Gets the specified Synchronization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Synchronization.</returns>
        System.Threading.Tasks.Task<Synchronization> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Synchronization using PATCH.
        /// </summary>
        /// <param name="synchronizationToUpdate">The Synchronization to update.</param>
        /// <returns>The updated Synchronization.</returns>
        System.Threading.Tasks.Task<Synchronization> UpdateAsync(Synchronization synchronizationToUpdate);

        /// <summary>
        /// Updates the specified Synchronization using PATCH.
        /// </summary>
        /// <param name="synchronizationToUpdate">The Synchronization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Synchronization.</returns>
        System.Threading.Tasks.Task<Synchronization> UpdateAsync(Synchronization synchronizationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationRequest Expand(Expression<Func<Synchronization, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationRequest Select(Expression<Func<Synchronization, object>> selectExpression);

    }
}