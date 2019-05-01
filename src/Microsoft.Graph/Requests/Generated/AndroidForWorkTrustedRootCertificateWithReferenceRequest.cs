// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AndroidForWorkTrustedRootCertificateWithReferenceRequest.
    /// </summary>
    public partial class AndroidForWorkTrustedRootCertificateWithReferenceRequest : BaseRequest, IAndroidForWorkTrustedRootCertificateWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new AndroidForWorkTrustedRootCertificateWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidForWorkTrustedRootCertificateWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified AndroidForWorkTrustedRootCertificate.
        /// </summary>
        /// <returns>The AndroidForWorkTrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidForWorkTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkTrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidForWorkTrustedRootCertificate>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified AndroidForWorkTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="androidForWorkTrustedRootCertificateToCreate">The AndroidForWorkTrustedRootCertificate to create.</param>
        /// <returns>The created AndroidForWorkTrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> CreateAsync(AndroidForWorkTrustedRootCertificate androidForWorkTrustedRootCertificateToCreate)
        {
            return this.CreateAsync(androidForWorkTrustedRootCertificateToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AndroidForWorkTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="androidForWorkTrustedRootCertificateToCreate">The AndroidForWorkTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkTrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> CreateAsync(AndroidForWorkTrustedRootCertificate androidForWorkTrustedRootCertificateToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidForWorkTrustedRootCertificate>(androidForWorkTrustedRootCertificateToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified AndroidForWorkTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidForWorkTrustedRootCertificateToUpdate">The AndroidForWorkTrustedRootCertificate to update.</param>
        /// <returns>The updated AndroidForWorkTrustedRootCertificate.</returns>
        public System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> UpdateAsync(AndroidForWorkTrustedRootCertificate androidForWorkTrustedRootCertificateToUpdate)
        {
            return this.UpdateAsync(androidForWorkTrustedRootCertificateToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AndroidForWorkTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidForWorkTrustedRootCertificateToUpdate">The AndroidForWorkTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AndroidForWorkTrustedRootCertificate.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> UpdateAsync(AndroidForWorkTrustedRootCertificate androidForWorkTrustedRootCertificateToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidForWorkTrustedRootCertificate>(androidForWorkTrustedRootCertificateToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified AndroidForWorkTrustedRootCertificate.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AndroidForWorkTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidForWorkTrustedRootCertificate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkTrustedRootCertificateWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkTrustedRootCertificateWithReferenceRequest Expand(Expression<Func<AndroidForWorkTrustedRootCertificate, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkTrustedRootCertificateWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkTrustedRootCertificateWithReferenceRequest Select(Expression<Func<AndroidForWorkTrustedRootCertificate, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

    }
}