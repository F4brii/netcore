using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using application.UseCase.Interfaces;
using domain.entities;
using domain.services;
using infraestructure.repositories;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using application.DTO;

namespace application.UseCase
{
    public class PersonaUseCase : IPersonaUseCase
    {
        private readonly IMapper _mapper;
        public PersonaUseCase()
        {
            // Init Automapper
            var mapConfig = new MapperConfiguration(cfg =>
             {
                 cfg.AddProfile<ApplicationProfile>();
                 cfg.AddExpressionMapping();
             });
            this._mapper = new Mapper(mapConfig);
        }

        public PersonaDTO GetPersona(int Id){
            try{
                using (var repository = new PersonaRepository ()) {
                    Persona persona = new PersonaService(repository).GetPersona(Id);
                    return _mapper.Map<PersonaDTO>(persona);
                }
            }catch(Exception e){
                return null;
            }
        }
    }
}