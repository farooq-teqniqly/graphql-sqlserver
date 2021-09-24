// <copyright file="Query.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

using System.Threading;
using GraphQL.DataLoader;

namespace GraphQL
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using GraphQL.Data;
    using GraphQL.Extensions;
    using HotChocolate;
    using Microsoft.EntityFrameworkCore;

    public class Query
    {
        [UseApplicationDbContext]
        public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) => context.Speakers.ToListAsync();

        public Task<Speaker> GetSpeakerAsync(
            int id,
            SpeakerByIdDataLoader dataLoader,
            CancellationToken cancellationToken) => dataLoader.LoadAsync(id, cancellationToken);
    }
}
