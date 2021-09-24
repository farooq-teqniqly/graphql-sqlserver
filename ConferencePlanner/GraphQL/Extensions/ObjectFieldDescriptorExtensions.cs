using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotChocolate.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.Extensions
{
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
