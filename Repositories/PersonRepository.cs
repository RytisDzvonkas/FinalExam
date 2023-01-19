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
            return _context.People.Where(p => p.UserId == id).ToList();
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
                UserId = person.UserId,
            };
            _context.People.Add(newPerson);
            _context.SaveChanges();
            return newPerson;
        }

        public Person UpdateName(int id, PersonRequestModel person)
        {
            var nameToUpdate = _context.People.Single(x => x.UserId == id);
            nameToUpdate.Name = person.Name;
            _context.SaveChanges();
            return nameToUpdate;
        }

        public Person UpdateSurname(int id, PersonRequestModel person)
        {
            var surnameToUpdate = _context.People.Single(x => x.UserId == id);
            surnameToUpdate.Surname = person.Surname;
            _context.SaveChanges();
            return surnameToUpdate;
        }

        public Person UpdatePersonsCode(int id, PersonRequestModel person)
        {
            var personsCodeToUpdate = _context.People.Single(x => x.UserId == id);
            personsCodeToUpdate.PersonsCode = person.PersonsCode;
            _context.SaveChanges();
            return personsCodeToUpdate;
        }

        public Person UpdatePhoneNumber(int id, PersonRequestModel person)
        {
            var phoneNumberToUpdate = _context.People.Single(x => x.UserId == id);
            phoneNumberToUpdate.PhoneNumber = person.PhoneNumber;
            _context.SaveChanges();
            return phoneNumberToUpdate;
        }

        public Person UpdateEmail(int id, PersonRequestModel person)
        {
            var emailToUpdate = _context.People.Single(x => x.UserId == id);
            emailToUpdate.Email = person.Email;
            _context.SaveChanges();
            return emailToUpdate;
        }

        public Person UpdatePicture(int id, byte[] data)
        {
            var pictureToUpdate = _context.People.Single(x => x.UserId == id);
            pictureToUpdate.ProfilePicture = data;
            _context.SaveChanges();
            return pictureToUpdate;
        }

        public Person Delete(int id)
        {
            var personToDelete = _context.People.Single(x => x.UserId == id);
            _context.People.Remove(personToDelete);
            _context.SaveChanges();
            return personToDelete;
        }
    }
}
