using Infra.Shared.Mapper;
using Library.Domain.Interfaces;
using Library.Domain.Model;
using System.Collections.Generic;

namespace Library.Service.Services
{
    public class BookService : IServiceBook
    {
        private readonly IRepositoryBook _repositoryBook;

        public BookService(IRepositoryBook repositoryBook)
        {
            _repositoryBook = repositoryBook;
        }

        public IEnumerable<BookModel> RecoverAll()
        {
            var books = _repositoryBook.GetAll();
            return books.ConvertToBooks();
        }

        public BookModel RecoverById(int id)
        {
            var book = _repositoryBook.GetById(id);
            return book.ConvertToBook();
        }

        public void Delete(int id) =>
            _repositoryBook.Remove(id);

        public BookModel Insert(BookModel bookModel)
        {
            var book = bookModel.ConvertToBookEntity();

            _repositoryBook.Save(book);
            return book.ConvertToBook();
        }

        public BookModel Update(int id, BookModelUpdate bookModel)
        {
            if (id != bookModel.Id)
            {
                return default;
            }

            var book = bookModel.ConvertToBookEntity();

            _repositoryBook.Save(book);
            return book.ConvertToBook();
        }
    }
}
