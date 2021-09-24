// <copyright file="ObjectFieldDescriptorExtensions.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Extensions
{
    using HotChocolate.Types;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ObjectFieldDescriptorExtensions
    {
        public static IObjectFieldDescriptor UseDbContext<TContext>(this IObjectFieldDescriptor descriptor)
            where TContext : DbContext
        {
            return descriptor.UseScopedService<TContext>(
                serviceProvider => serviceProvider.GetRequiredService<IDbContextFactory<TContext>>().CreateDbContext(),
                disposeAsync: (_, context) => context.DisposeAsync());
        }
    }
}
