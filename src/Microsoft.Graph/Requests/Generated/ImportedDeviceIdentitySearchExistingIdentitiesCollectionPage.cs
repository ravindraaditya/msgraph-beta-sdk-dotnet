// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type ImportedDeviceIdentitySearchExistingIdentitiesCollectionPage.
    /// </summary>
    public partial class ImportedDeviceIdentitySearchExistingIdentitiesCollectionPage : CollectionPage<ImportedDeviceIdentity>, IImportedDeviceIdentitySearchExistingIdentitiesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IImportedDeviceIdentitySearchExistingIdentitiesRequest"/> instance.
        /// </summary>
        public IImportedDeviceIdentitySearchExistingIdentitiesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ImportedDeviceIdentitySearchExistingIdentitiesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
