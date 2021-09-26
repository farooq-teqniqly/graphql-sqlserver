// <copyright file="Payload.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Common
{
    using System.Collections.Generic;

    public abstract class Payload
    {
        public Payload(IReadOnlyList<UserError>? errors = null)
        {
            this.Errors = errors;
        }

        public IReadOnlyList<UserError>? Errors { get; }
    }
}
