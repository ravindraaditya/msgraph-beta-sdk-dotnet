// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AddContentFooterAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AddContentFooterAction : InformationProtectionAction
    {

        /// <summary>
        /// Gets or sets uiElementName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "uiElementName", Required = Newtonsoft.Json.Required.Default)]
        public string UiElementName { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text", Required = Newtonsoft.Json.Required.Default)]
        public string Text { get; set; }
    
        /// <summary>
        /// Gets or sets fontName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fontName", Required = Newtonsoft.Json.Required.Default)]
        public string FontName { get; set; }
    
        /// <summary>
        /// Gets or sets fontSize.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fontSize", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FontSize { get; set; }
    
        /// <summary>
        /// Gets or sets fontColor.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fontColor", Required = Newtonsoft.Json.Required.Default)]
        public string FontColor { get; set; }
    
        /// <summary>
        /// Gets or sets alignment.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alignment", Required = Newtonsoft.Json.Required.Default)]
        public ContentAlignment? Alignment { get; set; }
    
        /// <summary>
        /// Gets or sets margin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "margin", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Margin { get; set; }
    
    }
}
