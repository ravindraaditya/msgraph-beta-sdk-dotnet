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
    /// The interface IYammerDeviceUsageUserDetailRequest.
    /// </summary>
    public partial interface IYammerDeviceUsageUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified YammerDeviceUsageUserDetail using PUT.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToCreate">The YammerDeviceUsageUserDetail to create.</param>
        /// <returns>The created YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> CreateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToCreate);        /// <summary>
        /// Creates the specified YammerDeviceUsageUserDetail using PUT.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToCreate">The YammerDeviceUsageUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> CreateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <returns>The YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> GetAsync();

        /// <summary>
        /// Gets the specified YammerDeviceUsageUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified YammerDeviceUsageUserDetail using PATCH.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToUpdate">The YammerDeviceUsageUserDetail to update.</param>
        /// <returns>The updated YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> UpdateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToUpdate);

        /// <summary>
        /// Updates the specified YammerDeviceUsageUserDetail using PATCH.
        /// </summary>
        /// <param name="yammerDeviceUsageUserDetailToUpdate">The YammerDeviceUsageUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated YammerDeviceUsageUserDetail.</returns>
        System.Threading.Tasks.Task<YammerDeviceUsageUserDetail> UpdateAsync(YammerDeviceUsageUserDetail yammerDeviceUsageUserDetailToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IYammerDeviceUsageUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IYammerDeviceUsageUserDetailRequest Expand(Expression<Func<YammerDeviceUsageUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IYammerDeviceUsageUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IYammerDeviceUsageUserDetailRequest Select(Expression<Func<YammerDeviceUsageUserDetail, object>> selectExpression);

    }
}