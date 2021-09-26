// <copyright file="UserError.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Common
{
    public class UserError
    {
        public UserError(string message, string code)
        {
            this.Message = message;
            this.Code = code;
        }

        public string Message { get; }

        public string Code { get; }
    }
}