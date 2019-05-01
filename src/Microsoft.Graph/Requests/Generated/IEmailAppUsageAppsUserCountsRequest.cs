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
    /// The interface IEmailAppUsageAppsUserCountsRequest.
    /// </summary>
    public partial interface IEmailAppUsageAppsUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EmailAppUsageAppsUserCounts using PUT.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToCreate">The EmailAppUsageAppsUserCounts to create.</param>
        /// <returns>The created EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> CreateAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToCreate);        /// <summary>
        /// Creates the specified EmailAppUsageAppsUserCounts using PUT.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToCreate">The EmailAppUsageAppsUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> CreateAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified EmailAppUsageAppsUserCounts.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified EmailAppUsageAppsUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EmailAppUsageAppsUserCounts.
        /// </summary>
        /// <returns>The EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified EmailAppUsageAppsUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EmailAppUsageAppsUserCounts using PATCH.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToUpdate">The EmailAppUsageAppsUserCounts to update.</param>
        /// <returns>The updated EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> UpdateAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToUpdate);

        /// <summary>
        /// Updates the specified EmailAppUsageAppsUserCounts using PATCH.
        /// </summary>
        /// <param name="emailAppUsageAppsUserCountsToUpdate">The EmailAppUsageAppsUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EmailAppUsageAppsUserCounts.</returns>
        System.Threading.Tasks.Task<EmailAppUsageAppsUserCounts> UpdateAsync(EmailAppUsageAppsUserCounts emailAppUsageAppsUserCountsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageAppsUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageAppsUserCountsRequest Expand(Expression<Func<EmailAppUsageAppsUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageAppsUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailAppUsageAppsUserCountsRequest Select(Expression<Func<EmailAppUsageAppsUserCounts, object>> selectExpression);

    }
}