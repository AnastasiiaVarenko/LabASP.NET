using Lab3.Models.NewFolder;

namespace Lab3.Models.ContactModels
{
    public interface IContactService
    {
        int Add(Contact contact);
        Contact? FindById(int id);
        List<Contact> FindAll();
        void DeleteById(int id);
        void Update(Contact contact);
    }
}
