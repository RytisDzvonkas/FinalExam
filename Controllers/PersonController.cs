using FinalEgzam.Database.Entities;
using FinalEgzam.Repositories;
using FinalEgzam.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FinalEgzam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public List<Person> Get()
        {
            return _personRepository.GetAll();
        }

        [HttpGet("id")]
        public List<Person> GetPersonById([FromQuery] int id)
        {
            return _personRepository.GetPersonById(id);
        }

        [HttpPost]
        public Person Add([FromBody] PersonRequestModel person)
        {
            return _personRepository.AddNewPerson(person);
        }

        [HttpPut]
        public Person Update([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _personRepository.Update(id, person);
        }

        [HttpDelete]
        public Person Delete([FromQuery] int id)
        {
            return _personRepository.Delete(id);
        }
    }
}
