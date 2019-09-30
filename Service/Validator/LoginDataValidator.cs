namespace Advisor.Service.Validator
{
    public class LoginDataValidator : ILoginDataValidator
    {
        public bool Validate(string email, string password)
        {
            return !(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password));
        }
    }
}
