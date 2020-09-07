using Library.Domain.Entities;
using Library.Domain.Interfaces;
using Library.Infra.Data.Context;
using System.Collections.Generic;

namespace Library.Infra.Data.Repository
{
    public class UserRepository : BaseRepository<User, int>, IRepositoryUser
    {
        public UserRepository(EFCoreContext mySqlContext) : base(mySqlContext)
        {
        }

        public void Remove(int id) =>
            base.Delete(id);


        public void Save(User obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            else
                base.Update(obj);
        }

        public User GetById(int id) =>
            base.Select(id);

        public IList<User> GetAll() =>
            base.Select();
    }
}
