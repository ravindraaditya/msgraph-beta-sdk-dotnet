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
    /// The interface IFieldValueSetRequest.
    /// </summary>
    public partial interface IFieldValueSetRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified FieldValueSet using PUT.
        /// </summary>
        /// <param name="fieldValueSetToCreate">The FieldValueSet to create.</param>
        /// <returns>The created FieldValueSet.</returns>
        System.Threading.Tasks.Task<FieldValueSet> CreateAsync(FieldValueSet fieldValueSetToCreate);        /// <summary>
        /// Creates the specified FieldValueSet using PUT.
        /// </summary>
        /// <param name="fieldValueSetToCreate">The FieldValueSet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FieldValueSet.</returns>
        System.Threading.Tasks.Task<FieldValueSet> CreateAsync(FieldValueSet fieldValueSetToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified FieldValueSet.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified FieldValueSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified FieldValueSet.
        /// </summary>
        /// <returns>The FieldValueSet.</returns>
        System.Threading.Tasks.Task<FieldValueSet> GetAsync();

        /// <summary>
        /// Gets the specified FieldValueSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FieldValueSet.</returns>
        System.Threading.Tasks.Task<FieldValueSet> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified FieldValueSet using PATCH.
        /// </summary>
        /// <param name="fieldValueSetToUpdate">The FieldValueSet to update.</param>
        /// <returns>The updated FieldValueSet.</returns>
        System.Threading.Tasks.Task<FieldValueSet> UpdateAsync(FieldValueSet fieldValueSetToUpdate);

        /// <summary>
        /// Updates the specified FieldValueSet using PATCH.
        /// </summary>
        /// <param name="fieldValueSetToUpdate">The FieldValueSet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated FieldValueSet.</returns>
        System.Threading.Tasks.Task<FieldValueSet> UpdateAsync(FieldValueSet fieldValueSetToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFieldValueSetRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFieldValueSetRequest Expand(Expression<Func<FieldValueSet, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFieldValueSetRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFieldValueSetRequest Select(Expression<Func<FieldValueSet, object>> selectExpression);

    }
}