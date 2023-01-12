using FinalEgzam.Database.Entities;
using FinalEgzam.RequestModels;

namespace FinalEgzam.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        List<Person> GetPersonById(int id);
        Person AddNewPerson(PersonRequestModel person);
        Person Update(int id, PersonRequestModel person);
        Person Delete(int id);
    }
}
