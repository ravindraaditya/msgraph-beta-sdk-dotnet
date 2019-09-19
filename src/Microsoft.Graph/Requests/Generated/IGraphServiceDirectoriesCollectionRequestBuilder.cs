// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServiceDirectoriesCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServiceDirectoriesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServiceDirectoriesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServiceDirectoriesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IDirectoryDefinitionRequestBuilder"/> for the specified DirectoryDefinition.
        /// </summary>
        /// <param name="id">The ID for the DirectoryDefinition.</param>
        /// <returns>The <see cref="IDirectoryDefinitionRequestBuilder"/>.</returns>
        IDirectoryDefinitionRequestBuilder this[string id] { get; }

        
    }
}
