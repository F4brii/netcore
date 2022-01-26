using System;
using domain.entities;
using domain.repositories;

namespace domain.services
{
    public class PersonaService
    {
        private readonly Ipersona _repository;

        public PersonaService(Ipersona repository)
        {
            this._repository = repository;
        }

        public Persona GetPersona (int Id) {
            try {
                return _repository.GetPersona(Id);
            } catch (Exception) {
                throw;
            }

        }
    }
}