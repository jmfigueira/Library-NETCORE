using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.Interfaces
{
    public interface IRepositoryUser
    {
        void Save(User obj);

        void Remove(int id);

        User GetById(int id);

        IList<User> GetAll();
    }
}
