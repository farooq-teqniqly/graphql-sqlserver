// <copyright file="UseApplicationDbContextAttribute.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Extensions
{
    using System.Reflection;
    using GraphQL.Data;
    using HotChocolate.Types;
    using HotChocolate.Types.Descriptors;

    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
        {
            descriptor.UseDbContext<ApplicationDbContext>();
        }
    }
}
