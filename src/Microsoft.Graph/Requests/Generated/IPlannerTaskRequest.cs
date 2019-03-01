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
    /// The interface IPlannerTaskRequest.
    /// </summary>
    public partial interface IPlannerTaskRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerTask using PUT.
        /// </summary>
        /// <param name="plannerTaskToCreate">The PlannerTask to create.</param>
        /// <returns>The created PlannerTask.</returns>
        System.Threading.Tasks.Task<PlannerTask> CreateAsync(PlannerTask plannerTaskToCreate);        /// <summary>
        /// Creates the specified PlannerTask using PUT.
        /// </summary>
        /// <param name="plannerTaskToCreate">The PlannerTask to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerTask.</returns>
        System.Threading.Tasks.Task<PlannerTask> CreateAsync(PlannerTask plannerTaskToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerTask.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlannerTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerTask.
        /// </summary>
        /// <returns>The PlannerTask.</returns>
        System.Threading.Tasks.Task<PlannerTask> GetAsync();

        /// <summary>
        /// Gets the specified PlannerTask.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerTask.</returns>
        System.Threading.Tasks.Task<PlannerTask> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerTask using PATCH.
        /// </summary>
        /// <param name="plannerTaskToUpdate">The PlannerTask to update.</param>
        /// <returns>The updated PlannerTask.</returns>
        System.Threading.Tasks.Task<PlannerTask> UpdateAsync(PlannerTask plannerTaskToUpdate);

        /// <summary>
        /// Updates the specified PlannerTask using PATCH.
        /// </summary>
        /// <param name="plannerTaskToUpdate">The PlannerTask to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated PlannerTask.</returns>
        System.Threading.Tasks.Task<PlannerTask> UpdateAsync(PlannerTask plannerTaskToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerTaskRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerTaskRequest Expand(Expression<Func<PlannerTask, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerTaskRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerTaskRequest Select(Expression<Func<PlannerTask, object>> selectExpression);

    }
}