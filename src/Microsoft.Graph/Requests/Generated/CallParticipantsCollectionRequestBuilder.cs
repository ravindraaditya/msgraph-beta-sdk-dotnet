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
    /// The type CallParticipantsCollectionRequestBuilder.
    /// </summary>
    public partial class CallParticipantsCollectionRequestBuilder : BaseRequestBuilder, ICallParticipantsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CallParticipantsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CallParticipantsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICallParticipantsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICallParticipantsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CallParticipantsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IParticipantRequestBuilder"/> for the specified CallParticipant.
        /// </summary>
        /// <param name="id">The ID for the CallParticipant.</param>
        /// <returns>The <see cref="IParticipantRequestBuilder"/>.</returns>
        public IParticipantRequestBuilder this[string id]
        {
            get
            {
                return new ParticipantRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ParticipantInvite.
        /// </summary>
        /// <returns>The <see cref="IParticipantInviteRequestBuilder"/>.</returns>
        public IParticipantInviteRequestBuilder Invite(
            IEnumerable<InvitationParticipantInfo> participants,
            string clientContext = null)
        {
            return new ParticipantInviteRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.invite"),
                this.Client,
                participants,
                clientContext);
        }

        /// <summary>
        /// Gets the request builder for ParticipantMuteAll.
        /// </summary>
        /// <returns>The <see cref="IParticipantMuteAllRequestBuilder"/>.</returns>
        public IParticipantMuteAllRequestBuilder MuteAll(
            IEnumerable<string> participants = null,
            string clientContext = null)
        {
            return new ParticipantMuteAllRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.muteAll"),
                this.Client,
                participants,
                clientContext);
        }
    }
}
