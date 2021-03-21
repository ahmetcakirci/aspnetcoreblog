namespace blog.data.models{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    public class Category:CoreEntity
    {
        [Key]
        public Guid Id { get; set; }
        [
            Required,
            MaxLength(50)
        ]
        public string Name { get; set; }


        public virtual ICollection<Post> Posts { get; set; }
    }
}