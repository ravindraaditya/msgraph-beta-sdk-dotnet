// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type MobileLobAppRequest.
    /// </summary>
    public partial class MobileLobAppRequest : BaseRequest, IMobileLobAppRequest
    {
        /// <summary>
        /// Constructs a new MobileLobAppRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MobileLobAppRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MobileLobApp using POST.
        /// </summary>
        /// <param name="mobileLobAppToCreate">The MobileLobApp to create.</param>
        /// <returns>The created MobileLobApp.</returns>
        public System.Threading.Tasks.Task<MobileLobApp> CreateAsync(MobileLobApp mobileLobAppToCreate)
        {
            return this.CreateAsync(mobileLobAppToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MobileLobApp using POST.
        /// </summary>
        /// <param name="mobileLobAppToCreate">The MobileLobApp to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileLobApp.</returns>
        public async System.Threading.Tasks.Task<MobileLobApp> CreateAsync(MobileLobApp mobileLobAppToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MobileLobApp>(mobileLobAppToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MobileLobApp.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MobileLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MobileLobApp>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MobileLobApp.
        /// </summary>
        /// <returns>The MobileLobApp.</returns>
        public System.Threading.Tasks.Task<MobileLobApp> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MobileLobApp.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileLobApp.</returns>
        public async System.Threading.Tasks.Task<MobileLobApp> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MobileLobApp>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MobileLobApp using PATCH.
        /// </summary>
        /// <param name="mobileLobAppToUpdate">The MobileLobApp to update.</param>
        /// <returns>The updated MobileLobApp.</returns>
        public System.Threading.Tasks.Task<MobileLobApp> UpdateAsync(MobileLobApp mobileLobAppToUpdate)
        {
            return this.UpdateAsync(mobileLobAppToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MobileLobApp using PATCH.
        /// </summary>
        /// <param name="mobileLobAppToUpdate">The MobileLobApp to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MobileLobApp.</returns>
        public async System.Threading.Tasks.Task<MobileLobApp> UpdateAsync(MobileLobApp mobileLobAppToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MobileLobApp>(mobileLobAppToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileLobAppRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileLobAppRequest Expand(Expression<Func<MobileLobApp, object>> expandExpression)
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
        public IMobileLobAppRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileLobAppRequest Select(Expression<Func<MobileLobApp, object>> selectExpression)
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

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="mobileLobAppToInitialize">The <see cref="MobileLobApp"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MobileLobApp mobileLobAppToInitialize)
        {

            if (mobileLobAppToInitialize != null && mobileLobAppToInitialize.AdditionalData != null)
            {

                if (mobileLobAppToInitialize.ContentVersions != null && mobileLobAppToInitialize.ContentVersions.CurrentPage != null)
                {
                    mobileLobAppToInitialize.ContentVersions.AdditionalData = mobileLobAppToInitialize.AdditionalData;

                    object nextPageLink;
                    mobileLobAppToInitialize.AdditionalData.TryGetValue("contentVersions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        mobileLobAppToInitialize.ContentVersions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}