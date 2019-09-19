// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ApprovalWorkflowProviderRequestBuilder.
    /// </summary>
    public partial class ApprovalWorkflowProviderRequestBuilder : EntityRequestBuilder, IApprovalWorkflowProviderRequestBuilder
    {

        /// <summary>
        /// Constructs a new ApprovalWorkflowProviderRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ApprovalWorkflowProviderRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IApprovalWorkflowProviderRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IApprovalWorkflowProviderRequest Request(IEnumerable<Option> options)
        {
            return new ApprovalWorkflowProviderRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for BusinessFlows.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder"/>.</returns>
        public IApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder BusinessFlows
        {
            get
            {
                return new ApprovalWorkflowProviderBusinessFlowsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("businessFlows"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PolicyTemplates.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderPolicyTemplatesCollectionRequestBuilder"/>.</returns>
        public IApprovalWorkflowProviderPolicyTemplatesCollectionRequestBuilder PolicyTemplates
        {
            get
            {
                return new ApprovalWorkflowProviderPolicyTemplatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("policyTemplates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Requests.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderRequestsCollectionRequestBuilder"/>.</returns>
        public IApprovalWorkflowProviderRequestsCollectionRequestBuilder Requests
        {
            get
            {
                return new ApprovalWorkflowProviderRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("requests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RequestsAwaitingMyDecision.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder"/>.</returns>
        public IApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder RequestsAwaitingMyDecision
        {
            get
            {
                return new ApprovalWorkflowProviderRequestsAwaitingMyDecisionCollectionRequestBuilder(this.AppendSegmentToRequestUrl("requestsAwaitingMyDecision"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for BusinessFlowsWithRequestsAwaitingMyDecision.
        /// </summary>
        /// <returns>The <see cref="IApprovalWorkflowProviderBusinessFlowsWithRequestsAwaitingMyDecisionCollectionRequestBuilder"/>.</returns>
        public IApprovalWorkflowProviderBusinessFlowsWithRequestsAwaitingMyDecisionCollectionRequestBuilder BusinessFlowsWithRequestsAwaitingMyDecision
        {
            get
            {
                return new ApprovalWorkflowProviderBusinessFlowsWithRequestsAwaitingMyDecisionCollectionRequestBuilder(this.AppendSegmentToRequestUrl("businessFlowsWithRequestsAwaitingMyDecision"), this.Client);
            }
        }
    
    }
}
