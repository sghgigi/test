using ContactsApi.Models;
using System.Collections.Generic;

namespace ContactsApi.Repository
{
    public interface IContactsRepository
    {
        void Add(Contacts item);
        IEnumerable<Contacts> GetAll();
        Contacts Find(string key);
        void Remove(string key);
        void Update(Contacts item);
    }
}
