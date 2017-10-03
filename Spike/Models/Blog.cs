using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spike.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required]
        public string Url { get; set; }

        public int Rating { get; set; }

        public List<Post> Posts { get; set; }
    }
}
