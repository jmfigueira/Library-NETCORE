using Library.Domain.Interfaces;
using Library.Domain.Model;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Library.Tests.Entities
{
    public class BookTests
    {
        private IServiceBook _mock;

        public BookTests()
        {
            _mock = Substitute.For<IServiceBook>();

            var books = new List<BookModel>() { new BookModel(0, "bookName", "description", "author", "interpreter", "ptbr", DateTime.Now, 0) };

            _mock.RecoverAll().Returns(books);
        }

        [Fact]
        public void ShouldReturnErroWhenBookNotExist()
        {
            var book = new BookModel(1, "bookName1", "description", "author", "interpreter", "ptbr", DateTime.Now, 0);

            var allBooks = _mock.RecoverAll();

            Assert.Null(allBooks.Where(x => x.Id == book.Id).FirstOrDefault());
        }
    }
}
