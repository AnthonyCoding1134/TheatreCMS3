using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Blog.Models
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign key to BlogAuthor
        public int BlogAuthorId { get; set; }

        [ForeignKey("BlogAuthorId")]
        public virtual BlogAuthor BlogAuthor { get; set; }
    }

}