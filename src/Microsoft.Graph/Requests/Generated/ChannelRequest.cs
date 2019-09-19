// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ChannelRequest.
    /// </summary>
    public partial class ChannelRequest : BaseRequest, IChannelRequest
    {
        /// <summary>
        /// Constructs a new ChannelRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ChannelRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Channel using POST.
        /// </summary>
        /// <param name="channelToCreate">The Channel to create.</param>
        /// <returns>The created Channel.</returns>
        public System.Threading.Tasks.Task<Channel> CreateAsync(Channel channelToCreate)
        {
            return this.CreateAsync(channelToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Channel using POST.
        /// </summary>
        /// <param name="channelToCreate">The Channel to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Channel.</returns>
        public async System.Threading.Tasks.Task<Channel> CreateAsync(Channel channelToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Channel>(channelToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Channel.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Channel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Channel>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Channel.
        /// </summary>
        /// <returns>The Channel.</returns>
        public System.Threading.Tasks.Task<Channel> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Channel.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Channel.</returns>
        public async System.Threading.Tasks.Task<Channel> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Channel>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Channel using PATCH.
        /// </summary>
        /// <param name="channelToUpdate">The Channel to update.</param>
        /// <returns>The updated Channel.</returns>
        public System.Threading.Tasks.Task<Channel> UpdateAsync(Channel channelToUpdate)
        {
            return this.UpdateAsync(channelToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Channel using PATCH.
        /// </summary>
        /// <param name="channelToUpdate">The Channel to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Channel.</returns>
        public async System.Threading.Tasks.Task<Channel> UpdateAsync(Channel channelToUpdate, CancellationToken cancellationToken)
        {
			if (channelToUpdate.AdditionalData != null)
			{
				if (channelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					channelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, channelToUpdate.GetType().Name)
						});
				}
			}
            if (channelToUpdate.AdditionalData != null)
            {
                if (channelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    channelToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, channelToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Channel>(channelToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IChannelRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IChannelRequest Expand(Expression<Func<Channel, object>> expandExpression)
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
        public IChannelRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IChannelRequest Select(Expression<Func<Channel, object>> selectExpression)
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
        /// <param name="channelToInitialize">The <see cref="Channel"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Channel channelToInitialize)
        {

            if (channelToInitialize != null && channelToInitialize.AdditionalData != null)
            {

                if (channelToInitialize.Messages != null && channelToInitialize.Messages.CurrentPage != null)
                {
                    channelToInitialize.Messages.AdditionalData = channelToInitialize.AdditionalData;

                    object nextPageLink;
                    channelToInitialize.AdditionalData.TryGetValue("messages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        channelToInitialize.Messages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (channelToInitialize.ChatThreads != null && channelToInitialize.ChatThreads.CurrentPage != null)
                {
                    channelToInitialize.ChatThreads.AdditionalData = channelToInitialize.AdditionalData;

                    object nextPageLink;
                    channelToInitialize.AdditionalData.TryGetValue("chatThreads@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        channelToInitialize.ChatThreads.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (channelToInitialize.Tabs != null && channelToInitialize.Tabs.CurrentPage != null)
                {
                    channelToInitialize.Tabs.AdditionalData = channelToInitialize.AdditionalData;

                    object nextPageLink;
                    channelToInitialize.AdditionalData.TryGetValue("tabs@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        channelToInitialize.Tabs.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (channelToInitialize.Members != null && channelToInitialize.Members.CurrentPage != null)
                {
                    channelToInitialize.Members.AdditionalData = channelToInitialize.AdditionalData;

                    object nextPageLink;
                    channelToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        channelToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
