using AutoMapper;
using DataAccess.Entities;
using DTO;

namespace APIurok.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<Medicament,MedicamentDTO>();
            CreateMap<MedicamentDTO,Medicament>();

        }
    }
}
