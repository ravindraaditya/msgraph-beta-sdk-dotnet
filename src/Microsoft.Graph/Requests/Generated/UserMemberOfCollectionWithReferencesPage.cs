// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;

    /// <summary>
    /// The type UserMemberOfCollectionWithReferencesPage.
    /// </summary>
    public partial class UserMemberOfCollectionWithReferencesPage : CollectionPage<DirectoryObject>, IUserMemberOfCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IUserMemberOfCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IUserMemberOfCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new UserMemberOfCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}