// <copyright file="AddSpeakerInput.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Speakers
{
    public record AddSpeakerInput(
        string name,
        string? bio,
        string? webSite);
}
