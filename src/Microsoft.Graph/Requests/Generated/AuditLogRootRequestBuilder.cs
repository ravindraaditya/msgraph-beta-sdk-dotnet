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
    /// The type AuditLogRootRequestBuilder.
    /// </summary>
    public partial class AuditLogRootRequestBuilder : EntityRequestBuilder, IAuditLogRootRequestBuilder
    {

        /// <summary>
        /// Constructs a new AuditLogRootRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AuditLogRootRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAuditLogRootRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAuditLogRootRequest Request(IEnumerable<Option> options)
        {
            return new AuditLogRootRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SignIns.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootSignInsCollectionRequestBuilder"/>.</returns>
        public IAuditLogRootSignInsCollectionRequestBuilder SignIns
        {
            get
            {
                return new AuditLogRootSignInsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("signIns"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DirectoryAudits.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootDirectoryAuditsCollectionRequestBuilder"/>.</returns>
        public IAuditLogRootDirectoryAuditsCollectionRequestBuilder DirectoryAudits
        {
            get
            {
                return new AuditLogRootDirectoryAuditsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("directoryAudits"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RestrictedSignIns.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootRestrictedSignInsCollectionRequestBuilder"/>.</returns>
        public IAuditLogRootRestrictedSignInsCollectionRequestBuilder RestrictedSignIns
        {
            get
            {
                return new AuditLogRootRestrictedSignInsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("restrictedSignIns"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DirectoryProvisioning.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootDirectoryProvisioningCollectionRequestBuilder"/>.</returns>
        public IAuditLogRootDirectoryProvisioningCollectionRequestBuilder DirectoryProvisioning
        {
            get
            {
                return new AuditLogRootDirectoryProvisioningCollectionRequestBuilder(this.AppendSegmentToRequestUrl("directoryProvisioning"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Provisioning.
        /// </summary>
        /// <returns>The <see cref="IAuditLogRootProvisioningCollectionRequestBuilder"/>.</returns>
        public IAuditLogRootProvisioningCollectionRequestBuilder Provisioning
        {
            get
            {
                return new AuditLogRootProvisioningCollectionRequestBuilder(this.AppendSegmentToRequestUrl("provisioning"), this.Client);
            }
        }
    
    }
}
