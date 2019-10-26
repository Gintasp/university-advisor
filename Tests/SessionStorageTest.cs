using Advisor.Models;
using Advisor.Service.Auth;
using Xunit;

namespace Advisor.Tests
{
    public class SessionStorageTest
    {
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<SessionStorage>(SessionStorage.Instance);
        }

        [Fact]
        public void UserTest()
        {
            User user = new User()
            {
                Email = "test@test.com",
                Name = "John Doe"
            };
            SessionStorage storage = SessionStorage.Instance;
            storage.User = user;

            Assert.Equal(storage.User, user);
            Assert.IsType<User>(storage.User);
        }
    }
}
