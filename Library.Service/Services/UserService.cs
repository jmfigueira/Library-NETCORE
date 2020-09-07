using Infra.Shared.Mapper;
using Library.Domain.Interfaces;
using Library.Domain.Model;
using System.Collections.Generic;

namespace Library.Service.Services
{
    public class UserService : IServiceUser
    {
        private readonly IRepositoryUser _repositoryUser;

        public UserService(IRepositoryUser repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        public IEnumerable<UserModel> RecoverAll()
        {
            var users = _repositoryUser.GetAll();
            return users.ConvertToUsers();
        }

        public UserModel RecoverById(int id)
        {
            var user = _repositoryUser.GetById(id);
            return user.ConvertToUser();
        }

        public void Delete(int id) =>
            _repositoryUser.Remove(id);

        public UserModel Insert(UserModel userModel)
        {
            var user = userModel.ConvertToUserEntity();

            _repositoryUser.Save(user);
            return user.ConvertToUser();
        }

        public UserModel Update(int id, UserModelUpdate userModel)
        {
            if (id != userModel.Id)
            {
                return default;
            }

            var user = userModel.ConvertToUserEntity();

            _repositoryUser.Save(user);
            return user.ConvertToUser();
        }
    }
}
