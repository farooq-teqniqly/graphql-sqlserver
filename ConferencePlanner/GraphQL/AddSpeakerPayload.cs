// <copyright file="AddSpeakerPayload.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL
{
    using GraphQL.Data;

    public class AddSpeakerPayload
    {
        public AddSpeakerPayload(Speaker speaker)
        {
            this.Speaker = speaker;
        }

        public Speaker Speaker { get; }
    }
}
