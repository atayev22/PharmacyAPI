
using AutoMapper;
using BLogics.IService;
using DataAccess.Entities;
using Repo.IRepositories;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLogics.Service
{
    public class BaseService<TDTO, TEntity> : IBaseService<TDTO, TEntity> where TEntity : BaseEntity
    {
        public readonly IRepository<TEntity> rep;
        public readonly IMapper mapper;

        public BaseService(IRepository<TEntity> rep,IMapper mapper)
        {
            this.rep = rep;
            this.mapper = mapper;
        }

        public virtual void Add(TDTO entity)
        {
            var data = mapper.Map<TEntity>(entity);
            rep.Add(data);
        }

        public virtual void Delete(int id)
        {   
             rep.Delete(id);             
        }

        public virtual IEnumerable<TDTO> Get()
        {
            var data = rep.Get();
            var resp=mapper.Map<IEnumerable<TDTO>>(data);
            return resp;
        }

        public virtual TDTO Get(int id)
        {
            var data = rep.Get(id);
            var resp = mapper.Map<TDTO>(data);
            return resp;
        }

        public virtual void Update(TDTO entity)
        {
            var data = mapper.Map<TEntity>(entity);
            rep.Update(data);
        }
    }
}
