using FinalEgzam.Database.Entities;
using FinalEgzam.Repositories;
using FinalEgzam.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace FinalEgzam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResidenceController : ControllerBase
    {
        private readonly IResidenceRepository _residenceRepository;
        public ResidenceController(IResidenceRepository residenceRepository)
        {
            _residenceRepository = residenceRepository;
        }

        [HttpGet]
        public List<Residence> Get()
        {
            return _residenceRepository.GetAll();
        }

        [HttpGet("id")]
        public List<Residence> GetResidenceById([FromQuery] int id)
        {
            return _residenceRepository.GetResidenceById(id);
        }

        [HttpPost]
        public Residence Add([FromBody] ResidenceRequestModel residence)
        {
            return _residenceRepository.AddNewResidence(residence);
        }

        [HttpPut]
        public Residence Update([FromQuery] int id, [FromBody] ResidenceRequestModel residence)
        {
            return _residenceRepository.Update(id, residence);
        }

        [HttpDelete]
        public Residence Delete([FromQuery] int id)
        {
            return _residenceRepository.Delete(id);
        }
    }
}
