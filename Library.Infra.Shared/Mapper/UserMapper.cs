using Library.Domain.Entities;
using Library.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Shared.Mapper
{
    public static class UserMapper
    {
        public static User ConvertToUserEntity(this UserModel userModel) =>
            new User(0, userModel.Name, userModel.Email, userModel.Password, userModel.IsAdmin);

        public static User ConvertToUserEntity(this UserModelUpdate userModel) =>
            new User(userModel.Id, userModel.Name, userModel.Email, userModel.Password, userModel.IsAdmin);

        public static IEnumerable<UserModel> ConvertToUsers(this IList<User> users) =>
            new List<UserModel>(users.Select(s => new UserModel(s.Id, s.Name.ToString(), s.Email, s.Password, s.IsAdmin)));

        public static UserModel ConvertToUser(this User user) =>
            new UserModel(user.Id, user.Name.ToString(), user.Email, user.Password, user.IsAdmin);
    }
}
