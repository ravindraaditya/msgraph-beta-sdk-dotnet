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
    /// The type UserMobileAppIntentAndStatesCollectionRequestBuilder.
    /// </summary>
    public partial class UserMobileAppIntentAndStatesCollectionRequestBuilder : BaseRequestBuilder, IUserMobileAppIntentAndStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserMobileAppIntentAndStatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserMobileAppIntentAndStatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserMobileAppIntentAndStatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserMobileAppIntentAndStatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserMobileAppIntentAndStatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMobileAppIntentAndStateRequestBuilder"/> for the specified UserMobileAppIntentAndState.
        /// </summary>
        /// <param name="id">The ID for the UserMobileAppIntentAndState.</param>
        /// <returns>The <see cref="IMobileAppIntentAndStateRequestBuilder"/>.</returns>
        public IMobileAppIntentAndStateRequestBuilder this[string id]
        {
            get
            {
                return new MobileAppIntentAndStateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
