namespace blog.business.services
{
    using data.context;
    using data.models;
    using repositories;
    public class PostService : Repository<Post>,IPostRepository
    {
        public PostService(blogcontext context) : base(context)
        {

        }
    }
}