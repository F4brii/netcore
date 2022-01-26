using System;
using domain.entities;
using domain.repositories;
using domain.services;
using infraestructure.repositories;

namespace application
{
    public class Class1
    {
        private Ipersona _repository;
        private PersonaService _service;

        public Class1()
        {
            _repository = new PersonaRepository();
            _service = new PersonaService(_repository);
        }
        public Persona GetPersona(int Id)
        {
            return _service.GetPersona(Id);
        }
    }
}
