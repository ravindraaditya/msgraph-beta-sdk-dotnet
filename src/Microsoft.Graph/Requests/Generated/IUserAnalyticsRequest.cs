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
    /// The interface IUserAnalyticsRequest.
    /// </summary>
    public partial interface IUserAnalyticsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserAnalytics using POST.
        /// </summary>
        /// <param name="userAnalyticsToCreate">The UserAnalytics to create.</param>
        /// <returns>The created UserAnalytics.</returns>
        System.Threading.Tasks.Task<UserAnalytics> CreateAsync(UserAnalytics userAnalyticsToCreate);        /// <summary>
        /// Creates the specified UserAnalytics using POST.
        /// </summary>
        /// <param name="userAnalyticsToCreate">The UserAnalytics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserAnalytics.</returns>
        System.Threading.Tasks.Task<UserAnalytics> CreateAsync(UserAnalytics userAnalyticsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified UserAnalytics.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified UserAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserAnalytics.
        /// </summary>
        /// <returns>The UserAnalytics.</returns>
        System.Threading.Tasks.Task<UserAnalytics> GetAsync();

        /// <summary>
        /// Gets the specified UserAnalytics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserAnalytics.</returns>
        System.Threading.Tasks.Task<UserAnalytics> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserAnalytics using PATCH.
        /// </summary>
        /// <param name="userAnalyticsToUpdate">The UserAnalytics to update.</param>
        /// <returns>The updated UserAnalytics.</returns>
        System.Threading.Tasks.Task<UserAnalytics> UpdateAsync(UserAnalytics userAnalyticsToUpdate);

        /// <summary>
        /// Updates the specified UserAnalytics using PATCH.
        /// </summary>
        /// <param name="userAnalyticsToUpdate">The UserAnalytics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserAnalytics.</returns>
        System.Threading.Tasks.Task<UserAnalytics> UpdateAsync(UserAnalytics userAnalyticsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserAnalyticsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserAnalyticsRequest Expand(Expression<Func<UserAnalytics, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserAnalyticsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserAnalyticsRequest Select(Expression<Func<UserAnalytics, object>> selectExpression);

    }
}
