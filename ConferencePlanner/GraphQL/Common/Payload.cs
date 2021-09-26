// <copyright file="Payload.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Payload
    {
        public Payload(IReadOnlyList<UserError>? errors = null)
        {
            this.Errors = errors;
        }

        public IReadOnlyList<UserError>? Errors { get; }
    }
}
