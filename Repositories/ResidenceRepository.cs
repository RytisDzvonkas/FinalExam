using FinalEgzam.Database.Entities;
using FinalEgzam.Database;
using FinalEgzam.RequestModels;

namespace FinalEgzam.Repositories
{
    public class ResidenceRepository : IResidenceRepository
    {
        public readonly ApplicationDbContext _context;
        public ResidenceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Residence> GetAll()
        {
            return _context.Residences.ToList();
        }

        public List<Residence> GetResidenceById(int id)
        {
            return _context.Residences.Where(p => p.UserId == id).ToList();
        }
        public Residence AddNewResidence(ResidenceRequestModel residence)
        {
            var newResidence = new Residence()
            {
                City = residence.City,
                Street = residence.Street,
                HouseNumber = residence.HouseNumber,
                FlatNumber = residence.FlatNumber,
                UserId = residence.UserId,
            };
            _context.Residences.Add(newResidence);
            _context.SaveChanges();

            return newResidence;
        }

        public Residence Update(int id, ResidenceRequestModel residence)
        {
            var ResidenceToUpdate = _context.Residences.Single(x => x.UserId == id);
            ResidenceToUpdate.City = residence.City;
            ResidenceToUpdate.Street = residence.Street;
            ResidenceToUpdate.HouseNumber = residence.HouseNumber;
            ResidenceToUpdate.FlatNumber = residence.FlatNumber;
            _context.SaveChanges();

            return ResidenceToUpdate;
        }

        public Residence Delete(int id)
        {
            var residenceToDelete = _context.Residences.Single(x => x.UserId == id);
            _context.Residences.Remove(residenceToDelete);
            _context.SaveChanges();
            return residenceToDelete;
        }
    }
}

