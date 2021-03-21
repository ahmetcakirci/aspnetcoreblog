namespace blog.data.models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    public class Post : CoreEntity
    {
        [Key]
        public Guid Id { get; set; }
        [
            Required,
            MaxLength(100)
        ]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
        public DateTime CratedDate { get; set; }
        public string FullName { get; set; }


        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<PostImage> PostImage { get; set; }
    }
}