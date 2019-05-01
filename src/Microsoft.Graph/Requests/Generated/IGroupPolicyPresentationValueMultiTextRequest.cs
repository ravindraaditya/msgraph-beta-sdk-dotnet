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
    /// The interface IGroupPolicyPresentationValueMultiTextRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationValueMultiTextRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationValueMultiText using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationValueMultiTextToCreate">The GroupPolicyPresentationValueMultiText to create.</param>
        /// <returns>The created GroupPolicyPresentationValueMultiText.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueMultiText> CreateAsync(GroupPolicyPresentationValueMultiText groupPolicyPresentationValueMultiTextToCreate);        /// <summary>
        /// Creates the specified GroupPolicyPresentationValueMultiText using PUT.
        /// </summary>
        /// <param name="groupPolicyPresentationValueMultiTextToCreate">The GroupPolicyPresentationValueMultiText to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationValueMultiText.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueMultiText> CreateAsync(GroupPolicyPresentationValueMultiText groupPolicyPresentationValueMultiTextToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValueMultiText.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationValueMultiText.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValueMultiText.
        /// </summary>
        /// <returns>The GroupPolicyPresentationValueMultiText.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueMultiText> GetAsync();

        /// <summary>
        /// Gets the specified GroupPolicyPresentationValueMultiText.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationValueMultiText.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueMultiText> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValueMultiText using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationValueMultiTextToUpdate">The GroupPolicyPresentationValueMultiText to update.</param>
        /// <returns>The updated GroupPolicyPresentationValueMultiText.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueMultiText> UpdateAsync(GroupPolicyPresentationValueMultiText groupPolicyPresentationValueMultiTextToUpdate);

        /// <summary>
        /// Updates the specified GroupPolicyPresentationValueMultiText using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationValueMultiTextToUpdate">The GroupPolicyPresentationValueMultiText to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated GroupPolicyPresentationValueMultiText.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationValueMultiText> UpdateAsync(GroupPolicyPresentationValueMultiText groupPolicyPresentationValueMultiTextToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueMultiTextRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueMultiTextRequest Expand(Expression<Func<GroupPolicyPresentationValueMultiText, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueMultiTextRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationValueMultiTextRequest Select(Expression<Func<GroupPolicyPresentationValueMultiText, object>> selectExpression);

    }
}