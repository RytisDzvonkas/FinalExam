using FinalEgzam.Database;
using FinalEgzam.Database.Entities;
using FinalEgzam.RequestModels;

namespace FinalEgzam.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public readonly ApplicationDbContext _context;
        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Person> GetAll()
        {
            return _context.People.ToList();
        }

        public List<Person> GetPersonById(int id)
        {
            return _context.People.Where(p => p.Id == id).ToList();
        }
        public Person AddNewPerson(PersonRequestModel person)
        {
            var newPerson = new Person()
            {
                Name = person.Name,
                Surname = person.Surname,
                PersonsCode = person.PersonsCode,
                PhoneNumber = person.PhoneNumber,
                Email = person.Email,
                ProfilePicture = person.ProfilePicture,
                ResidenceId = person.ResidenceId,
            };
            _context.People.Add(newPerson);
            _context.SaveChanges();

            return newPerson;
        }

        public Person Update(int id, PersonRequestModel person)
        {
            var PersonToUpdate = _context.People.Single(x => x.Id == id);
            PersonToUpdate.Name = person.Name;
            PersonToUpdate.Surname = person.Surname;
            PersonToUpdate.PersonsCode = person.PersonsCode;
            PersonToUpdate.PhoneNumber = person.PhoneNumber;
            PersonToUpdate.Email = person.Email;
            PersonToUpdate.ProfilePicture = person.ProfilePicture;
            PersonToUpdate.ResidenceId = person.ResidenceId;
            _context.SaveChanges();

            return PersonToUpdate;
        }

        public Person Delete(int id)
        {
            var personToDelete = _context.People.Single(x => x.Id == id);
            _context.People.Remove(personToDelete);
            _context.SaveChanges();
            return personToDelete;
        }
    }
}
