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
    /// The interface IPasswordAuthenticationMethodRequest.
    /// </summary>
    public partial interface IPasswordAuthenticationMethodRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PasswordAuthenticationMethod using POST.
        /// </summary>
        /// <param name="passwordAuthenticationMethodToCreate">The PasswordAuthenticationMethod to create.</param>
        /// <returns>The created PasswordAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordAuthenticationMethod> CreateAsync(PasswordAuthenticationMethod passwordAuthenticationMethodToCreate);        /// <summary>
        /// Creates the specified PasswordAuthenticationMethod using POST.
        /// </summary>
        /// <param name="passwordAuthenticationMethodToCreate">The PasswordAuthenticationMethod to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PasswordAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordAuthenticationMethod> CreateAsync(PasswordAuthenticationMethod passwordAuthenticationMethodToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PasswordAuthenticationMethod.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PasswordAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PasswordAuthenticationMethod.
        /// </summary>
        /// <returns>The PasswordAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordAuthenticationMethod> GetAsync();

        /// <summary>
        /// Gets the specified PasswordAuthenticationMethod.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PasswordAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordAuthenticationMethod> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PasswordAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="passwordAuthenticationMethodToUpdate">The PasswordAuthenticationMethod to update.</param>
        /// <returns>The updated PasswordAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordAuthenticationMethod> UpdateAsync(PasswordAuthenticationMethod passwordAuthenticationMethodToUpdate);

        /// <summary>
        /// Updates the specified PasswordAuthenticationMethod using PATCH.
        /// </summary>
        /// <param name="passwordAuthenticationMethodToUpdate">The PasswordAuthenticationMethod to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PasswordAuthenticationMethod.</returns>
        System.Threading.Tasks.Task<PasswordAuthenticationMethod> UpdateAsync(PasswordAuthenticationMethod passwordAuthenticationMethodToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPasswordAuthenticationMethodRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPasswordAuthenticationMethodRequest Expand(Expression<Func<PasswordAuthenticationMethod, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPasswordAuthenticationMethodRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPasswordAuthenticationMethodRequest Select(Expression<Func<PasswordAuthenticationMethod, object>> selectExpression);

    }
}
