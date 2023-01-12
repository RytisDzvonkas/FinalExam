using FinalEgzam.Database.Entities;
using FinalEgzam.RequestModels;

namespace FinalEgzam.Repositories
{
    public interface IResidenceRepository
    {
        List<Residence> GetAll();
        List<Residence> GetResidenceById(int id);
        Residence AddNewResidence(ResidenceRequestModel residence);
        Residence Update(int id, ResidenceRequestModel residence);
        Residence Delete(int id);
    }
}
