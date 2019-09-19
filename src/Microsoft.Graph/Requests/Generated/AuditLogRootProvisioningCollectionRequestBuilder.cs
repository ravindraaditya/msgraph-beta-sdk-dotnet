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
    /// The type AuditLogRootProvisioningCollectionRequestBuilder.
    /// </summary>
    public partial class AuditLogRootProvisioningCollectionRequestBuilder : BaseRequestBuilder, IAuditLogRootProvisioningCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AuditLogRootProvisioningCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuditLogRootProvisioningCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAuditLogRootProvisioningCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAuditLogRootProvisioningCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AuditLogRootProvisioningCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IProvisioningObjectSummaryRequestBuilder"/> for the specified AuditLogRootProvisioningObjectSummary.
        /// </summary>
        /// <param name="id">The ID for the AuditLogRootProvisioningObjectSummary.</param>
        /// <returns>The <see cref="IProvisioningObjectSummaryRequestBuilder"/>.</returns>
        public IProvisioningObjectSummaryRequestBuilder this[string id]
        {
            get
            {
                return new ProvisioningObjectSummaryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
