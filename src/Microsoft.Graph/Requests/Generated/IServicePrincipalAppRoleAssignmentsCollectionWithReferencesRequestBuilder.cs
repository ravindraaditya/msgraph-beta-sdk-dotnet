// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IServicePrincipalAppRoleAssignmentsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAppRoleAssignmentWithReferenceRequestBuilder"/> for the specified AppRoleAssignment.
        /// </summary>
        /// <param name="id">The ID for the AppRoleAssignment.</param>
        /// <returns>The <see cref="IAppRoleAssignmentWithReferenceRequestBuilder"/>.</returns>
        IAppRoleAssignmentWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalAppRoleAssignmentsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalAppRoleAssignmentsCollectionReferencesRequestBuilder"/>.</returns>
        IServicePrincipalAppRoleAssignmentsCollectionReferencesRequestBuilder References { get; }

    }
}