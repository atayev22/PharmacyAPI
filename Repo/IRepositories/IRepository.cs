using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.IRepositories
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> Get();

        public TEntity Get(int id);     


        public void Add(TEntity entity);


        public void Update(TEntity entity);


        public void Delete(int id);
    }

}
