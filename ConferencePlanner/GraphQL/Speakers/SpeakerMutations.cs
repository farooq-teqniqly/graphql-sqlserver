// <copyright file="SpeakerMutations.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Speakers
{
    using System.Threading.Tasks;
    using GraphQL.Data;
    using GraphQL.Extensions;
    using HotChocolate;
    using HotChocolate.Types;

    [ExtendObjectType(Name = "Mutation")]
    public class SpeakerMutations
    {
        [UseApplicationDbContext]
        public async Task<AddSpeakerPayload> AddSpeakerAsync(
            AddSpeakerInput input,
            [ScopedService] ApplicationDbContext context)
        {
            var speaker = new Speaker
            {
                Name = input.name,
                Bio = input.bio,
                WebSite = input.webSite,
            };

            await context.Speakers.AddAsync(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }
    }
}
