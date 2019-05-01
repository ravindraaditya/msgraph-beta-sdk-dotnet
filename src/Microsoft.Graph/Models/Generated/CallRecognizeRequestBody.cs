// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type CallRecognizeRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CallRecognizeRequestBody
    {
    
        /// <summary>
        /// Gets or sets Prompts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "prompts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Prompt> Prompts { get; set; }
    
        /// <summary>
        /// Gets or sets BargeInAllowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bargeInAllowed", Required = Newtonsoft.Json.Required.Default)]
        public bool? BargeInAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets Culture.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "culture", Required = Newtonsoft.Json.Required.Default)]
        public string Culture { get; set; }
    
        /// <summary>
        /// Gets or sets InitialSilenceTimeoutInSeconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initialSilenceTimeoutInSeconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InitialSilenceTimeoutInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets InterDigitTimeoutInSeconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interDigitTimeoutInSeconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InterDigitTimeoutInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets Choices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "choices", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RecognitionOption> Choices { get; set; }
    
        /// <summary>
        /// Gets or sets CollectDigits.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "collectDigits", Required = Newtonsoft.Json.Required.Default)]
        public CollectDigits CollectDigits { get; set; }
    
        /// <summary>
        /// Gets or sets ClientContext.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientContext", Required = Newtonsoft.Json.Required.Default)]
        public string ClientContext { get; set; }
    
    }
}