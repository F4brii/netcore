using domain.repositories;
using domain.entities;
using infraestructure.context;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using infraestructure.profiles;
using infraestructure.models;

namespace infraestructure.repositories
{
    public class PersonaRepository : Ipersona, IDisposable
    {
        private readonly IMapper _mapper;
        public PersonaRepository()
        {

            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<InfraestrutureProfile>();
                cfg.AddExpressionMapping();
            });
            this._mapper = new Mapper(mapConfig);
        }

        public void Dispose() { }

        public Persona GetPersona(int Id){
            try
            {                
                using (var context = new Pscontext())
                {
                    PersonaModel objeto = context.Personas.Where(s => s.Id == Id).FirstOrDefault();           
                    return _mapper.Map<Persona>(objeto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}