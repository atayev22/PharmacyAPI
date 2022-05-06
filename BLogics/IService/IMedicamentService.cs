using BLogics.IService;
using DataAccess.Entities;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLogics.Service
{
    public interface IMedicamentService : IBaseService<MedicamentDTO,Medicament>
    {
      
    }
}
