using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositories
{
    public  class Repository : IRepository
    {
        protected AppDbContext dbContext;

        protected Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }

    public class Repository<TEntity> : Repository , IRepository<TEntity>  where TEntity : BaseEntity
    {


        protected DbSet<TEntity> dbSet;

        public Repository(AppDbContext dbContext) :base(dbContext)
        {
            this.dbSet = dbContext.Set<TEntity>();
        }




        public virtual IEnumerable<TEntity> Get()
        {
           
            return dbSet;
        }

        public virtual TEntity Get(int id)
        {
            var value = dbSet.Find(id);
            if (value == null)
            {
                throw new Exception("NET value");
            }
            return value;
        }


        public virtual void Add(TEntity entity)
        {
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }


        public virtual void Update(TEntity entity)
        {
            dbSet.Update(entity);
            dbContext.SaveChanges();
        }


        public virtual void Delete(int id)
        {

            var value = Get(id);
            dbSet.Remove(value);
            dbContext.SaveChanges();

        }
    }
}
