namespace blog.business.services
{
    using data.context;
    using data.models;
    using repositories;

    public class CategoryService : Repository<Category>, ICategoryRepository
    {
        public CategoryService(blogcontext context) : base(context)
        {

        }
    }
}