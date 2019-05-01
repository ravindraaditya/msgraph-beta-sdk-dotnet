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
    /// The interface IChatThreadRequest.
    /// </summary>
    public partial interface IChatThreadRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ChatThread using PUT.
        /// </summary>
        /// <param name="chatThreadToCreate">The ChatThread to create.</param>
        /// <returns>The created ChatThread.</returns>
        System.Threading.Tasks.Task<ChatThread> CreateAsync(ChatThread chatThreadToCreate);        /// <summary>
        /// Creates the specified ChatThread using PUT.
        /// </summary>
        /// <param name="chatThreadToCreate">The ChatThread to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ChatThread.</returns>
        System.Threading.Tasks.Task<ChatThread> CreateAsync(ChatThread chatThreadToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ChatThread.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ChatThread.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ChatThread.
        /// </summary>
        /// <returns>The ChatThread.</returns>
        System.Threading.Tasks.Task<ChatThread> GetAsync();

        /// <summary>
        /// Gets the specified ChatThread.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ChatThread.</returns>
        System.Threading.Tasks.Task<ChatThread> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ChatThread using PATCH.
        /// </summary>
        /// <param name="chatThreadToUpdate">The ChatThread to update.</param>
        /// <returns>The updated ChatThread.</returns>
        System.Threading.Tasks.Task<ChatThread> UpdateAsync(ChatThread chatThreadToUpdate);

        /// <summary>
        /// Updates the specified ChatThread using PATCH.
        /// </summary>
        /// <param name="chatThreadToUpdate">The ChatThread to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ChatThread.</returns>
        System.Threading.Tasks.Task<ChatThread> UpdateAsync(ChatThread chatThreadToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IChatThreadRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IChatThreadRequest Expand(Expression<Func<ChatThread, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IChatThreadRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IChatThreadRequest Select(Expression<Func<ChatThread, object>> selectExpression);

    }
}