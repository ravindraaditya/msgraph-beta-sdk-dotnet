// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EducationClassSchoolsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class EducationClassSchoolsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IEducationClassSchoolsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationClassSchoolsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationClassSchoolsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationClassSchoolsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationClassSchoolsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new EducationClassSchoolsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationSchoolWithReferenceRequestBuilder"/> for the specified EducationClassEducationSchool.
        /// </summary>
        /// <param name="id">The ID for the EducationClassEducationSchool.</param>
        /// <returns>The <see cref="IEducationSchoolWithReferenceRequestBuilder"/>.</returns>
        public IEducationSchoolWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new EducationSchoolWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IEducationClassSchoolsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IEducationClassSchoolsCollectionReferencesRequestBuilder"/>.</returns>
        public IEducationClassSchoolsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new EducationClassSchoolsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}