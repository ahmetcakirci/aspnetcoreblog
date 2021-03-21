namespace blog.business.services
{
    using System;
    using data.context;
    using data.models;
    using repositories;

    public class PostImageService : Repository<PostImage>, IPostImageRepository
    {
        public PostImageService(blogcontext context) : base(context)
        {

        }

        void SetFalse(Guid id){

        }
    }
}