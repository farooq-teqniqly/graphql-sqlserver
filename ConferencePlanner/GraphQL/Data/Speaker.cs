// <copyright file="Speaker.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Speaker : IEntity
    {
        [Required]
        [StringLength(200)]
        public string? Name { get; set; }

        [StringLength(4000)]
        public string? Bio { get; set; }

        [StringLength(1000)]
        public string? WebSite { get; set; }

        public int Id { get; set; }

        public ICollection<SessionSpeaker> SessionSpeakers { get; set; } = new List<SessionSpeaker>();
    }
}
