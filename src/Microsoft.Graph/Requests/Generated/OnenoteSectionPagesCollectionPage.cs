// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionPage.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;

    /// <summary>
    /// The type OnenoteSectionPagesCollectionPage.
    /// </summary>
    public partial class OnenoteSectionPagesCollectionPage : CollectionPage<OnenotePage>, IOnenoteSectionPagesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IOnenoteSectionPagesCollectionRequest"/> instance.
        /// </summary>
        public IOnenoteSectionPagesCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new OnenoteSectionPagesCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}