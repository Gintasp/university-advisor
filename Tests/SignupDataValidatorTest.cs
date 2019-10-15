using Advisor.Model;
using Advisor.Service.Validator;
using Xunit;

namespace Advisor.Tests
{
    public class SignupDataValidatorTest
    {
        [Fact]
        public void ValidateTest()
        {
            SignupDataValidator validator = new SignupDataValidator();
            User userBadPass = new User()
            {
                Email = "test@test.com",
                Name = "John Doe",
                Password = "password",
            };
            User userBadEmail = new User()
            {
                Email = "bad.email",
                Name = "John Doe",
                Password = "Password1",
            };
            User user = new User()
            {
                Email = "test@test.com",
                Name = "John Doe",
                Password = "Password1",
            };
            User userEmptyEmail = new User()
            {
                Email = "",
                Name = "John Doe",
                Password = "Password1",
            };
            User userEmptyName = new User()
            {
                Email = "test@test.com",
                Name = "",
                Password = "Password1",
            };
            User userEmptyPass = new User()
            {
                Email = "test@test.com",
                Name = "John Doe",
                Password = "",
            };


            Assert.False(validator.Validate(userBadPass, "password"));
            Assert.Equal("Password must contain at least eight characters, one uppercase letter, one lowercase letter and one number", validator.GetSignupDataValidatorErrorMessage());
            Assert.NotEqual("Other error message.", validator.GetSignupDataValidatorErrorMessage());

            Assert.False(validator.Validate(userBadEmail, "Password1"));
            Assert.Equal("Invalid email.", validator.GetSignupDataValidatorErrorMessage());

            Assert.True(validator.Validate(user, "Password1"));
            Assert.Null(validator.GetSignupDataValidatorErrorMessage());

            Assert.False(validator.Validate(userEmptyEmail, "Password1"));
            Assert.Equal("Please enter all required fields.", validator.GetSignupDataValidatorErrorMessage());
            Assert.False(validator.Validate(userEmptyName, "Password1"));
            Assert.Equal("Please enter all required fields.", validator.GetSignupDataValidatorErrorMessage());
            Assert.False(validator.Validate(userEmptyPass, "Password1"));
            Assert.Equal("Please enter all required fields.", validator.GetSignupDataValidatorErrorMessage());

            Assert.True(validator.Validate(user, "Password1"));
            Assert.Null(validator.GetSignupDataValidatorErrorMessage());
        }
    }
}
