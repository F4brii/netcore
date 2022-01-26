using AutoMapper;
using domain.entities;
using application.DTO;

namespace application.DTO
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<PersonaDTO, Persona>().ReverseMap();
        }
    }
}