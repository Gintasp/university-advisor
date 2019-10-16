using Advisor.Service.Validator;
using Xunit;

namespace Advisor.Tests
{
    public class LoginDataValidatorTest
    {
        [Fact]
        public void ValidateTest()
        {
            LoginDataValidator validator = new LoginDataValidator();

            Assert.True(validator.Validate("email", "pass"));
            Assert.True(validator.Validate("email ", " pass"));

            Assert.False(validator.Validate(" ", " pass"));
            Assert.False(validator.Validate("", " pass"));
            Assert.False(validator.Validate(null, " pass"));
            Assert.False(validator.Validate("email", ""));
            Assert.False(validator.Validate("email", " "));
            Assert.False(validator.Validate("email", null));
            Assert.False(validator.Validate(null, null));
            Assert.False(validator.Validate("", ""));
            Assert.False(validator.Validate(" ", " "));
        }
    }
}
