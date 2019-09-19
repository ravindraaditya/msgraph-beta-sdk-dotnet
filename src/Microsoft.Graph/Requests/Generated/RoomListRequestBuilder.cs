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
    /// The type RoomListRequestBuilder.
    /// </summary>
    public partial class RoomListRequestBuilder : PlaceRequestBuilder, IRoomListRequestBuilder
    {

        /// <summary>
        /// Constructs a new RoomListRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RoomListRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IRoomListRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IRoomListRequest Request(IEnumerable<Option> options)
        {
            return new RoomListRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Rooms.
        /// </summary>
        /// <returns>The <see cref="IRoomListRoomsCollectionRequestBuilder"/>.</returns>
        public IRoomListRoomsCollectionRequestBuilder Rooms
        {
            get
            {
                return new RoomListRoomsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("rooms"), this.Client);
            }
        }
    
    }
}
