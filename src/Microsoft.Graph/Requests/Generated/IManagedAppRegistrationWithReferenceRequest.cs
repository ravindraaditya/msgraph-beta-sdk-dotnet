// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedAppRegistrationWithReferenceRequest.
    /// </summary>
    public partial interface IManagedAppRegistrationWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <returns>The ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified ManagedAppRegistration using PUT.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <returns>The created ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> CreateAsync(ManagedAppRegistration managedAppRegistrationToCreate);        /// <summary>
        /// Creates the specified ManagedAppRegistration using PUT.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> CreateAsync(ManagedAppRegistration managedAppRegistrationToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <returns>The updated ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> UpdateAsync(ManagedAppRegistration managedAppRegistrationToUpdate);

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> UpdateAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified ManagedAppRegistration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRegistrationWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRegistrationWithReferenceRequest Expand(Expression<Func<ManagedAppRegistration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRegistrationWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRegistrationWithReferenceRequest Select(Expression<Func<ManagedAppRegistration, object>> selectExpression);

    }
}