// <copyright file="SpeakerPayloadBase.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Speakers
{
    using System.Collections.Generic;
    using GraphQL.Common;
    using GraphQL.Data;

    public class SpeakerPayloadBase : Payload
    {
        public SpeakerPayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        protected SpeakerPayloadBase(Speaker speaker)
        {
            this.Speaker = speaker;
        }

        public Speaker? Speaker { get; }
    }
}
