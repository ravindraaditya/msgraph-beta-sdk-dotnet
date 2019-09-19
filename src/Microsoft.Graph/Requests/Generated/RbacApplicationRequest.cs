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
    /// The type RbacApplicationRequest.
    /// </summary>
    public partial class RbacApplicationRequest : BaseRequest, IRbacApplicationRequest
    {
        /// <summary>
        /// Constructs a new RbacApplicationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RbacApplicationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RbacApplication using POST.
        /// </summary>
        /// <param name="rbacApplicationToCreate">The RbacApplication to create.</param>
        /// <returns>The created RbacApplication.</returns>
        public System.Threading.Tasks.Task<RbacApplication> CreateAsync(RbacApplication rbacApplicationToCreate)
        {
            return this.CreateAsync(rbacApplicationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RbacApplication using POST.
        /// </summary>
        /// <param name="rbacApplicationToCreate">The RbacApplication to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RbacApplication.</returns>
        public async System.Threading.Tasks.Task<RbacApplication> CreateAsync(RbacApplication rbacApplicationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<RbacApplication>(rbacApplicationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified RbacApplication.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RbacApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<RbacApplication>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified RbacApplication.
        /// </summary>
        /// <returns>The RbacApplication.</returns>
        public System.Threading.Tasks.Task<RbacApplication> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RbacApplication.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RbacApplication.</returns>
        public async System.Threading.Tasks.Task<RbacApplication> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<RbacApplication>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified RbacApplication using PATCH.
        /// </summary>
        /// <param name="rbacApplicationToUpdate">The RbacApplication to update.</param>
        /// <returns>The updated RbacApplication.</returns>
        public System.Threading.Tasks.Task<RbacApplication> UpdateAsync(RbacApplication rbacApplicationToUpdate)
        {
            return this.UpdateAsync(rbacApplicationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RbacApplication using PATCH.
        /// </summary>
        /// <param name="rbacApplicationToUpdate">The RbacApplication to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RbacApplication.</returns>
        public async System.Threading.Tasks.Task<RbacApplication> UpdateAsync(RbacApplication rbacApplicationToUpdate, CancellationToken cancellationToken)
        {
			if (rbacApplicationToUpdate.AdditionalData != null)
			{
				if (rbacApplicationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					rbacApplicationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, rbacApplicationToUpdate.GetType().Name)
						});
				}
			}
            if (rbacApplicationToUpdate.AdditionalData != null)
            {
                if (rbacApplicationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    rbacApplicationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, rbacApplicationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<RbacApplication>(rbacApplicationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationRequest Expand(Expression<Func<RbacApplication, object>> expandExpression)
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
        public IRbacApplicationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationRequest Select(Expression<Func<RbacApplication, object>> selectExpression)
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
        /// <param name="rbacApplicationToInitialize">The <see cref="RbacApplication"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RbacApplication rbacApplicationToInitialize)
        {

            if (rbacApplicationToInitialize != null && rbacApplicationToInitialize.AdditionalData != null)
            {

                if (rbacApplicationToInitialize.RoleDefinitions != null && rbacApplicationToInitialize.RoleDefinitions.CurrentPage != null)
                {
                    rbacApplicationToInitialize.RoleDefinitions.AdditionalData = rbacApplicationToInitialize.AdditionalData;

                    object nextPageLink;
                    rbacApplicationToInitialize.AdditionalData.TryGetValue("roleDefinitions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        rbacApplicationToInitialize.RoleDefinitions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (rbacApplicationToInitialize.RoleAssignments != null && rbacApplicationToInitialize.RoleAssignments.CurrentPage != null)
                {
                    rbacApplicationToInitialize.RoleAssignments.AdditionalData = rbacApplicationToInitialize.AdditionalData;

                    object nextPageLink;
                    rbacApplicationToInitialize.AdditionalData.TryGetValue("roleAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        rbacApplicationToInitialize.RoleAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
