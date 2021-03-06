namespace blog.business.services
{
    using System;
    using repositories;
    using data.models;
    using System.Collections.Generic;
    using data.context;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;

    public class Repository<T> : IRepository<T> where T : CoreEntity
    {
        private readonly blogcontext _context;
        private DbSet<T> _entities;
        public Repository(blogcontext context)
        {
            this._context = context;
            this._entities = context.Set<T>();
        }


        public void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity");
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity");
            _context.SaveChanges();
        }

        public void Delete(Guid Id)
        {
            if (Id == null) throw  new ArgumentNullException("Entity");
            T entity = _entities.SingleOrDefault(s => s.Id == Id);
            if (entity == null) throw new ArgumentNullException("Entity");
            _entities.Add(entity);
            _context.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
             return _entities.AsEnumerable();
        }
        public T GetById(Guid Id)
        {
             if (Id == null) throw new ArgumentNullException("entity");
            return _entities.SingleOrDefault(s => s.Id == Id);
        }
    }
}