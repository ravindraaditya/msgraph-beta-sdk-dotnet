// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph.Beta
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Onenote.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Onenote : Entity
    {
    
        /// <summary>
        /// Gets or sets notebooks.
        /// The collection of OneNote notebooks that are owned by the user or group. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notebooks", Required = Newtonsoft.Json.Required.Default)]
        public IOnenoteNotebooksCollectionPage Notebooks { get; set; }
    
        /// <summary>
        /// Gets or sets sections.
        /// The sections in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sections", Required = Newtonsoft.Json.Required.Default)]
        public IOnenoteSectionsCollectionPage Sections { get; set; }
    
        /// <summary>
        /// Gets or sets section groups.
        /// The section groups in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sectionGroups", Required = Newtonsoft.Json.Required.Default)]
        public IOnenoteSectionGroupsCollectionPage SectionGroups { get; set; }
    
        /// <summary>
        /// Gets or sets pages.
        /// The pages in all OneNote notebooks that are owned by the user or group.  Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pages", Required = Newtonsoft.Json.Required.Default)]
        public IOnenotePagesCollectionPage Pages { get; set; }
    
        /// <summary>
        /// Gets or sets resources.
        /// The image and other file resources in OneNote pages. Getting a resources collection is not supported, but you can get the binary content of a specific resource. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resources", Required = Newtonsoft.Json.Required.Default)]
        public IOnenoteResourcesCollectionPage Resources { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// The status of OneNote operations. Getting an operations collection is not supported, but you can get the status of long-running operations if the Operation-Location header is returned in the response. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operations", Required = Newtonsoft.Json.Required.Default)]
        public IOnenoteOperationsCollectionPage Operations { get; set; }
    
    }
}
