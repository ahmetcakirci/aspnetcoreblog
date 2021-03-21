namespace blog.data.models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class PostImage : CoreEntity
    {
        [Key]
        public Guid Id { get; set; }

        public string ImageUrl { get; set; }
        public bool Active { get; set; }

        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}