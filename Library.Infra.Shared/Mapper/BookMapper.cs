using Library.Domain.Entities;
using Library.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Shared.Mapper
{
    public static class BookMapper
    {
        public static Book ConvertToBookEntity(this BookModel bookModel) =>
            new Book(0, bookModel.Name, bookModel.Description, bookModel.Author);

        public static Book ConvertToBookEntity(this BookModelUpdate bookModel) =>
            new Book(bookModel.Id, bookModel.Name, bookModel.Description, bookModel.Author);

        public static IEnumerable<BookModel> ConvertToBooks(this IList<Book> books) =>
            new List<BookModel>(books.Select(s => new BookModel(s.Id, s.Name.ToString(), s.Description, s.Author)));

        public static BookModel ConvertToBook(this Book book) =>
            new BookModel(book.Id, book.Name.ToString(), book.Description, book.Author);
    }
}
