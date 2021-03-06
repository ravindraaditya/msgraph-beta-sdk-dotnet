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
    /// The type CompanySalesCreditMemoLinesCollectionRequestBuilder.
    /// </summary>
    public partial class CompanySalesCreditMemoLinesCollectionRequestBuilder : BaseRequestBuilder, ICompanySalesCreditMemoLinesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanySalesCreditMemoLinesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanySalesCreditMemoLinesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanySalesCreditMemoLinesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanySalesCreditMemoLinesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanySalesCreditMemoLinesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISalesCreditMemoLineRequestBuilder"/> for the specified CompanySalesCreditMemoLine.
        /// </summary>
        /// <param name="id">The ID for the CompanySalesCreditMemoLine.</param>
        /// <returns>The <see cref="ISalesCreditMemoLineRequestBuilder"/>.</returns>
        public ISalesCreditMemoLineRequestBuilder this[string id]
        {
            get
            {
                return new SalesCreditMemoLineRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
