using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using application;
using domain.entities;
using application.UseCase.Interfaces;
using application.UseCase;
using application.DTO;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaUseCase _useCase;
        public PersonaController()
        {
            _useCase = new PersonaUseCase();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult (_useCase.GetPersona(1));
        }
    }
}
