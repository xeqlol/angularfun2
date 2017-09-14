using HomeCinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Data.Repositories
{
    class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private HomeCinemaContext dataContext;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected HomeCinemaContext DbContext
        {
            get { return dataContext ?? dataContext = DbFactory.Init(); }
        }

        public EntityBaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
        }

        public virtual IQueryable<T> GetAll()
        {
            return DbContext.Set<T>();
        }

        public virtual IQueryable<T> All
        {
            get { return GetAll(); }
        }

        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = DbContext.Set<T>();
            foreach(var includeProperty in includeProperties)
            {
                query = query.include
            }
        }
    }
}
