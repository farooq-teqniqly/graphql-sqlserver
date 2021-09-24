// <copyright file="SessionSpeaker.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Data
{
    public class SessionSpeaker
    {
        public int SessionId { get; set; }

        public int SpeakerId { get; set; }

        public Session? Session { get; set; }

        public Speaker? Speaker { get; set; }
    }
}