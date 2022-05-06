using Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLogics.IService
{

    public interface IBaseService<TDTO,TEntity> 
    {
        public IEnumerable<TDTO> Get();

        public TDTO Get(int id);


        public void Add(TDTO entity);


        public void Update(TDTO entity);


        public void Delete(int id);

    }
        
}
