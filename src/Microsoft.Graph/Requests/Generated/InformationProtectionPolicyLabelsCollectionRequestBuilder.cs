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
    /// The type InformationProtectionPolicyLabelsCollectionRequestBuilder.
    /// </summary>
    public partial class InformationProtectionPolicyLabelsCollectionRequestBuilder : BaseRequestBuilder, IInformationProtectionPolicyLabelsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new InformationProtectionPolicyLabelsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public InformationProtectionPolicyLabelsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IInformationProtectionPolicyLabelsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IInformationProtectionPolicyLabelsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new InformationProtectionPolicyLabelsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IInformationProtectionLabelRequestBuilder"/> for the specified InformationProtectionPolicyInformationProtectionLabel.
        /// </summary>
        /// <param name="id">The ID for the InformationProtectionPolicyInformationProtectionLabel.</param>
        /// <returns>The <see cref="IInformationProtectionLabelRequestBuilder"/>.</returns>
        public IInformationProtectionLabelRequestBuilder this[string id]
        {
            get
            {
                return new InformationProtectionLabelRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
