// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DefaultManagedAppProtectionAppsCollectionRequestBuilder.
    /// </summary>
    public partial class DefaultManagedAppProtectionAppsCollectionRequestBuilder : BaseRequestBuilder, IDefaultManagedAppProtectionAppsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DefaultManagedAppProtectionAppsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DefaultManagedAppProtectionAppsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDefaultManagedAppProtectionAppsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDefaultManagedAppProtectionAppsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DefaultManagedAppProtectionAppsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedMobileAppRequestBuilder"/> for the specified DefaultManagedAppProtectionManagedMobileApp.
        /// </summary>
        /// <param name="id">The ID for the DefaultManagedAppProtectionManagedMobileApp.</param>
        /// <returns>The <see cref="IManagedMobileAppRequestBuilder"/>.</returns>
        public IManagedMobileAppRequestBuilder this[string id]
        {
            get
            {
                return new ManagedMobileAppRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}