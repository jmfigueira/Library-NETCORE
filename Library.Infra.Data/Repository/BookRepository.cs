using Library.Domain.Entities;
using Library.Domain.Interfaces;
using Library.Infra.Data.Context;
using System.Collections.Generic;

namespace Library.Infra.Data.Repository
{
    public class BookRepository : BaseRepository<Book, int>, IRepositoryBook
    {
        public BookRepository(EFCoreContext sqlContext) : base(sqlContext)
        {
        }

        public void Remove(int id) =>
            base.Delete(id);


        public void Save(Book obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            else
                base.Update(obj);
        }

        public Book GetById(int id) =>
            base.Select(id);

        public IList<Book> GetAll() =>
            base.Select();
    }
}
