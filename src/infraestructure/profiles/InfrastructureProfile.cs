using AutoMapper;
using domain.entities;
using infraestructure.models;

namespace infraestructure.profiles
{
    public class InfraestrutureProfile : Profile
    {
        public InfraestrutureProfile(){
            CreateMap<PersonaModel, Persona>().ReverseMap();
        }
    }
}