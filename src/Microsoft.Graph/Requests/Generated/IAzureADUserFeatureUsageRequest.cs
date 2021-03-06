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
    /// The interface IAzureADUserFeatureUsageRequest.
    /// </summary>
    public partial interface IAzureADUserFeatureUsageRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AzureADUserFeatureUsage using POST.
        /// </summary>
        /// <param name="azureADUserFeatureUsageToCreate">The AzureADUserFeatureUsage to create.</param>
        /// <returns>The created AzureADUserFeatureUsage.</returns>
        System.Threading.Tasks.Task<AzureADUserFeatureUsage> CreateAsync(AzureADUserFeatureUsage azureADUserFeatureUsageToCreate);        /// <summary>
        /// Creates the specified AzureADUserFeatureUsage using POST.
        /// </summary>
        /// <param name="azureADUserFeatureUsageToCreate">The AzureADUserFeatureUsage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AzureADUserFeatureUsage.</returns>
        System.Threading.Tasks.Task<AzureADUserFeatureUsage> CreateAsync(AzureADUserFeatureUsage azureADUserFeatureUsageToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AzureADUserFeatureUsage.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AzureADUserFeatureUsage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AzureADUserFeatureUsage.
        /// </summary>
        /// <returns>The AzureADUserFeatureUsage.</returns>
        System.Threading.Tasks.Task<AzureADUserFeatureUsage> GetAsync();

        /// <summary>
        /// Gets the specified AzureADUserFeatureUsage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AzureADUserFeatureUsage.</returns>
        System.Threading.Tasks.Task<AzureADUserFeatureUsage> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AzureADUserFeatureUsage using PATCH.
        /// </summary>
        /// <param name="azureADUserFeatureUsageToUpdate">The AzureADUserFeatureUsage to update.</param>
        /// <returns>The updated AzureADUserFeatureUsage.</returns>
        System.Threading.Tasks.Task<AzureADUserFeatureUsage> UpdateAsync(AzureADUserFeatureUsage azureADUserFeatureUsageToUpdate);

        /// <summary>
        /// Updates the specified AzureADUserFeatureUsage using PATCH.
        /// </summary>
        /// <param name="azureADUserFeatureUsageToUpdate">The AzureADUserFeatureUsage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AzureADUserFeatureUsage.</returns>
        System.Threading.Tasks.Task<AzureADUserFeatureUsage> UpdateAsync(AzureADUserFeatureUsage azureADUserFeatureUsageToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAzureADUserFeatureUsageRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAzureADUserFeatureUsageRequest Expand(Expression<Func<AzureADUserFeatureUsage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAzureADUserFeatureUsageRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAzureADUserFeatureUsageRequest Select(Expression<Func<AzureADUserFeatureUsage, object>> selectExpression);

    }
}
