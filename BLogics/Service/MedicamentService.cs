using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess;
using DataAccess.Entities;
using DTO;
using Repo.IRepositories;

namespace BLogics.Service
{
    public class MedicamentService : BaseService<MedicamentDTO,Medicament>, IMedicamentService
    {
        public MedicamentService(IRepository<Medicament> rep, IMapper mapper) : base(rep, mapper)
        {

        }

        public override void Add(MedicamentDTO entity)
        {
            base.Add(entity);
        }

        public override void Delete(int id)
        {
            base.Delete(id);
            
        }

        public override IEnumerable<MedicamentDTO> Get()
        {
            return base.Get();
        }

        public override MedicamentDTO Get(int id)
        {
            return base.Get(id);
        }

        public override void Update(MedicamentDTO entity)
        {
            base.Update(entity);
        }
    }
}
