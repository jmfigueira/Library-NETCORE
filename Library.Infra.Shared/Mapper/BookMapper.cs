using Library.Domain.Entities;
using Library.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Shared.Mapper
{
    public static class BookMapper
    {
        public static Book ConvertToBookEntity(this BookModel bookModel) =>
            new Book(0, bookModel.Title, bookModel.Description, bookModel.Author, bookModel.Interpreter, bookModel.Language,
                bookModel.Launch, bookModel.Price);

        public static Book ConvertToBookEntity(this BookModelUpdate bookModel) =>
            new Book(bookModel.Id, bookModel.Title, bookModel.Description, bookModel.Author, bookModel.Interpreter, bookModel.Language,
                bookModel.Launch, bookModel.Price);

        public static IEnumerable<BookModel> ConvertToBooks(this IList<Book> books) =>
            new List<BookModel>(books.Select(s => new BookModel(s.Id, s.Title.ToString(), s.Description, s.Author, s.Interpreter,
                s.Language, s.Launch, s.Price)));

        public static BookModel ConvertToBook(this Book book) =>
            new BookModel(book.Id, book.Title.ToString(), book.Description, book.Author, book.Interpreter, book.Language,
                book.Launch, book.Price);
    }
}
