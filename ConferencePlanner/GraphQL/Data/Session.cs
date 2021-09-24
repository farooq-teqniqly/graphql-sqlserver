using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQL.Data
{
    public class Session : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Title { get; set; }

        [Required]
        [StringLength(4000)]
        public string? Abstract { get; set; }

        [Required]
        public DateTimeOffset? StartTime { get; set; }

        [Required]
        public DateTimeOffset? EndTime { get; set; }

        public TimeSpan Duration => EndTime?.Subtract(StartTime ?? EndTime ?? DateTimeOffset.MinValue) ?? TimeSpan.Zero;

        public int? TrackId { get; set; }

        public ICollection<SessionSpeaker> SessionSpeakers { get; set; } = new List<SessionSpeaker>();
        public ICollection<SessionAttendee> SessionAttendees { get; set; } = new List<SessionAttendee>();

        public Track? Track { get; set; }
    }
}
