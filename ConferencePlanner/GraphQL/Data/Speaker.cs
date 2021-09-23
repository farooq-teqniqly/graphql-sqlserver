using System.ComponentModel.DataAnnotations;

namespace GraphQL.Data
{
    public class Speaker : IEntity
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Bio { get; set; }

        [StringLength(1000)]
        public string WebSite { get; set; }
        public int Id { get; set; }
    }
}
