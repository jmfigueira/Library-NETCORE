using Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Interfaces
{
    public interface IServiceBook
    {
        BookModel Insert(BookModel userModel);
        BookModel Update(int id, BookModelUpdate userModel);
        void Delete(int id);
        BookModel RecoverById(int id);
        IEnumerable<BookModel> RecoverAll();
    }
}