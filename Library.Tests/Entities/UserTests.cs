using Library.Domain.Entities;
using Library.Domain.Interfaces;
using Library.Domain.Model;
using NSubstitute;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Library.Tests.Entities
{
    public class UserTests
    {
        private IServiceUser _mock;

        public UserTests()
        {
            _mock = Substitute.For<IServiceUser>();

            var users = new List<UserModel>() { new UserModel(0, "admin", "admin@admin.com.br", "admin", true) };

            _mock.RecoverAll().Returns(users);
        }

        [Fact]
        public void ShouldReturnErroWhenBookNotExist()
        {
            var user = new UserModel(1, "usernew", "usernew@usernew.com.br", "usernew", true);

            var allUsers = _mock.RecoverAll();

            Assert.Null(allUsers.Where(x => x.Id == user.Id).FirstOrDefault());
        }
    }
}
