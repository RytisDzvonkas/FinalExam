using FinalEgzam.Database.Entities;
using FinalEgzam.RequestModels;

namespace FinalEgzam.Repositories
{
    public interface IPersonRepository
    {
        List<Person> GetAll();
        List<Person> GetPersonById(int id);
        Person AddNewPerson(PersonRequestModel person);
        Person UpdateName(int id, PersonRequestModel person);
        Person UpdateSurname(int id, PersonRequestModel person);
        Person UpdatePersonsCode(int id, PersonRequestModel person);
        Person UpdatePhoneNumber(int id, PersonRequestModel person);
        Person UpdateEmail(int id, PersonRequestModel person);
        Person UpdatePicture(int id, PersonRequestModel person);
        Person Delete(int id);
    }
}
