// <copyright file="Attendee.cs" company="Teqniqly">
// Copyright (c) Teqniqly. All rights reserved.
// </copyright>

namespace GraphQL.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Attendee : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(200)]
        public string? LastName { get; set; }

        [Required]
        [StringLength(200)]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public ICollection<SessionAttendee> SessionAttendees { get; set; } = new List<SessionAttendee>();
    }
}
