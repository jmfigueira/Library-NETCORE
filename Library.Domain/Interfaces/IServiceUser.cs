using Library.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Interfaces
{
    public interface IServiceUser
    {
        UserModel Insert(UserModel userModel);
        UserModel Update(int id, UserModelUpdate userModel);
        void Delete(int id);
        UserModel RecoverById(int id);
        IEnumerable<UserModel> RecoverAll();
    }
}