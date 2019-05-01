// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type CallRecognizeRequestBuilder.
    /// </summary>
    public partial class CallRecognizeRequestBuilder : BaseActionMethodRequestBuilder<ICallRecognizeRequest>, ICallRecognizeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="CallRecognizeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="prompts">A prompts parameter for the OData method call.</param>
        /// <param name="bargeInAllowed">A bargeInAllowed parameter for the OData method call.</param>
        /// <param name="culture">A culture parameter for the OData method call.</param>
        /// <param name="initialSilenceTimeoutInSeconds">A initialSilenceTimeoutInSeconds parameter for the OData method call.</param>
        /// <param name="interDigitTimeoutInSeconds">A interDigitTimeoutInSeconds parameter for the OData method call.</param>
        /// <param name="choices">A choices parameter for the OData method call.</param>
        /// <param name="collectDigits">A collectDigits parameter for the OData method call.</param>
        /// <param name="clientContext">A clientContext parameter for the OData method call.</param>
        public CallRecognizeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Prompt> prompts,
            bool? bargeInAllowed,
            string culture,
            Int32? initialSilenceTimeoutInSeconds,
            Int32? interDigitTimeoutInSeconds,
            IEnumerable<RecognitionOption> choices,
            CollectDigits collectDigits,
            string clientContext)
            : base(requestUrl, client)
        {
            this.SetParameter("prompts", prompts, true);
            this.SetParameter("bargeInAllowed", bargeInAllowed, true);
            this.SetParameter("culture", culture, true);
            this.SetParameter("initialSilenceTimeoutInSeconds", initialSilenceTimeoutInSeconds, true);
            this.SetParameter("interDigitTimeoutInSeconds", interDigitTimeoutInSeconds, true);
            this.SetParameter("choices", choices, true);
            this.SetParameter("collectDigits", collectDigits, true);
            this.SetParameter("clientContext", clientContext, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ICallRecognizeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new CallRecognizeRequest(functionUrl, this.Client, options);

            if (this.HasParameter("prompts"))
            {
                request.RequestBody.Prompts = this.GetParameter<IEnumerable<Prompt>>("prompts");
            }

            if (this.HasParameter("bargeInAllowed"))
            {
                request.RequestBody.BargeInAllowed = this.GetParameter<bool?>("bargeInAllowed");
            }

            if (this.HasParameter("culture"))
            {
                request.RequestBody.Culture = this.GetParameter<string>("culture");
            }

            if (this.HasParameter("initialSilenceTimeoutInSeconds"))
            {
                request.RequestBody.InitialSilenceTimeoutInSeconds = this.GetParameter<Int32?>("initialSilenceTimeoutInSeconds");
            }

            if (this.HasParameter("interDigitTimeoutInSeconds"))
            {
                request.RequestBody.InterDigitTimeoutInSeconds = this.GetParameter<Int32?>("interDigitTimeoutInSeconds");
            }

            if (this.HasParameter("choices"))
            {
                request.RequestBody.Choices = this.GetParameter<IEnumerable<RecognitionOption>>("choices");
            }

            if (this.HasParameter("collectDigits"))
            {
                request.RequestBody.CollectDigits = this.GetParameter<CollectDigits>("collectDigits");
            }

            if (this.HasParameter("clientContext"))
            {
                request.RequestBody.ClientContext = this.GetParameter<string>("clientContext");
            }

            return request;
        }
    }
}