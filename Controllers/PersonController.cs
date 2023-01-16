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

        [HttpPut("name")]
        public Person UpdateName([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _personRepository.UpdateName(id, person);
        }

        [HttpPut("surname")]
        public Person UpdateSurname([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _personRepository.UpdateSurname(id, person);
        }

        [HttpPut("personsCode")]
        public Person UpdatePersonsCode([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _personRepository.UpdatePersonsCode(id, person);
        }

        [HttpPut("phoneNumber")]
        public Person UpdatePhoneNumber([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _personRepository.UpdatePhoneNumber(id, person);
        }

        [HttpPut("email")]
        public Person UpdateEmail([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _personRepository.UpdateEmail(id, person);
        }

        [HttpPut("picture")]
        public Person UpdatePicture([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _personRepository.UpdatePicture(id, person);
        }

        [HttpDelete]
        public Person Delete([FromQuery] int id)
        {
            return _personRepository.Delete(id);
        }
    }
}
