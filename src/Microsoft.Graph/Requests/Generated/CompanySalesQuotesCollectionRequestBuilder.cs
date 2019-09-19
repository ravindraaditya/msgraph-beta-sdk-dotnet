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
    /// The type CompanySalesQuotesCollectionRequestBuilder.
    /// </summary>
    public partial class CompanySalesQuotesCollectionRequestBuilder : BaseRequestBuilder, ICompanySalesQuotesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanySalesQuotesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanySalesQuotesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanySalesQuotesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanySalesQuotesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanySalesQuotesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISalesQuoteRequestBuilder"/> for the specified CompanySalesQuote.
        /// </summary>
        /// <param name="id">The ID for the CompanySalesQuote.</param>
        /// <returns>The <see cref="ISalesQuoteRequestBuilder"/>.</returns>
        public ISalesQuoteRequestBuilder this[string id]
        {
            get
            {
                return new SalesQuoteRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
