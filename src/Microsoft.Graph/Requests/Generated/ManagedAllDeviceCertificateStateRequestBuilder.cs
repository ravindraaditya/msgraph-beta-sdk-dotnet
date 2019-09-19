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
    /// The type ManagedAllDeviceCertificateStateRequestBuilder.
    /// </summary>
    public partial class ManagedAllDeviceCertificateStateRequestBuilder : EntityRequestBuilder, IManagedAllDeviceCertificateStateRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedAllDeviceCertificateStateRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedAllDeviceCertificateStateRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IManagedAllDeviceCertificateStateRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IManagedAllDeviceCertificateStateRequest Request(IEnumerable<Option> options)
        {
            return new ManagedAllDeviceCertificateStateRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
