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
    /// The type WindowsFeatureUpdateProfileDeviceUpdateStatesCollectionRequestBuilder.
    /// </summary>
    public partial class WindowsFeatureUpdateProfileDeviceUpdateStatesCollectionRequestBuilder : BaseRequestBuilder, IWindowsFeatureUpdateProfileDeviceUpdateStatesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WindowsFeatureUpdateProfileDeviceUpdateStatesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsFeatureUpdateProfileDeviceUpdateStatesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWindowsFeatureUpdateProfileDeviceUpdateStatesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWindowsFeatureUpdateProfileDeviceUpdateStatesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WindowsFeatureUpdateProfileDeviceUpdateStatesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWindowsUpdateStateRequestBuilder"/> for the specified WindowsFeatureUpdateProfileWindowsUpdateState.
        /// </summary>
        /// <param name="id">The ID for the WindowsFeatureUpdateProfileWindowsUpdateState.</param>
        /// <returns>The <see cref="IWindowsUpdateStateRequestBuilder"/>.</returns>
        public IWindowsUpdateStateRequestBuilder this[string id]
        {
            get
            {
                return new WindowsUpdateStateRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}