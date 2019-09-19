// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder.
    /// </summary>
    public partial class ApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder : BaseRequestBuilder, IApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IApprovalWorkflowProviderBusinessFlowsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IApprovalWorkflowProviderBusinessFlowsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ApprovalWorkflowProviderBusinessFlowsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IBusinessFlowRequestBuilder"/> for the specified ApprovalWorkflowProviderBusinessFlow.
        /// </summary>
        /// <param name="id">The ID for the ApprovalWorkflowProviderBusinessFlow.</param>
        /// <returns>The <see cref="IBusinessFlowRequestBuilder"/>.</returns>
        public IBusinessFlowRequestBuilder this[string id]
        {
            get
            {
                return new BusinessFlowRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
