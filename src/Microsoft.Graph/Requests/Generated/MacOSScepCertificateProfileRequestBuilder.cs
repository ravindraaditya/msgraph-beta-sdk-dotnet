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
    /// The type MacOSScepCertificateProfileRequestBuilder.
    /// </summary>
    public partial class MacOSScepCertificateProfileRequestBuilder : MacOSCertificateProfileBaseRequestBuilder, IMacOSScepCertificateProfileRequestBuilder
    {

        /// <summary>
        /// Constructs a new MacOSScepCertificateProfileRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MacOSScepCertificateProfileRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IMacOSScepCertificateProfileRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IMacOSScepCertificateProfileRequest Request(IEnumerable<Option> options)
        {
            return new MacOSScepCertificateProfileRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RootCertificate.
        /// </summary>
        /// <returns>The <see cref="IMacOSTrustedRootCertificateWithReferenceRequestBuilder"/>.</returns>
        public IMacOSTrustedRootCertificateWithReferenceRequestBuilder RootCertificate
        {
            get
            {
                return new MacOSTrustedRootCertificateWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("rootCertificate"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceCertificateStates.
        /// </summary>
        /// <returns>The <see cref="IMacOSScepCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder"/>.</returns>
        public IMacOSScepCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder ManagedDeviceCertificateStates
        {
            get
            {
                return new MacOSScepCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("managedDeviceCertificateStates"), this.Client);
            }
        }
    
    }
}
