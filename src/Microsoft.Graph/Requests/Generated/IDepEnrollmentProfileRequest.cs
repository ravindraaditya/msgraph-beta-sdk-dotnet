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
    /// The interface IDepEnrollmentProfileRequest.
    /// </summary>
    public partial interface IDepEnrollmentProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DepEnrollmentProfile using POST.
        /// </summary>
        /// <param name="depEnrollmentProfileToCreate">The DepEnrollmentProfile to create.</param>
        /// <returns>The created DepEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentProfile> CreateAsync(DepEnrollmentProfile depEnrollmentProfileToCreate);        /// <summary>
        /// Creates the specified DepEnrollmentProfile using POST.
        /// </summary>
        /// <param name="depEnrollmentProfileToCreate">The DepEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DepEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentProfile> CreateAsync(DepEnrollmentProfile depEnrollmentProfileToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DepEnrollmentProfile.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DepEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DepEnrollmentProfile.
        /// </summary>
        /// <returns>The DepEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentProfile> GetAsync();

        /// <summary>
        /// Gets the specified DepEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DepEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DepEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="depEnrollmentProfileToUpdate">The DepEnrollmentProfile to update.</param>
        /// <returns>The updated DepEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentProfile> UpdateAsync(DepEnrollmentProfile depEnrollmentProfileToUpdate);

        /// <summary>
        /// Updates the specified DepEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="depEnrollmentProfileToUpdate">The DepEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DepEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentProfile> UpdateAsync(DepEnrollmentProfile depEnrollmentProfileToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepEnrollmentProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepEnrollmentProfileRequest Expand(Expression<Func<DepEnrollmentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDepEnrollmentProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDepEnrollmentProfileRequest Select(Expression<Func<DepEnrollmentProfile, object>> selectExpression);

    }
}
