using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.Interfaces
{
    public interface IRepositoryBook
    {
        void Save(Book obj);

        void Remove(int id);

        Book GetById(int id);

        IList<Book> GetAll();
    }
}
