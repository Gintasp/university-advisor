namespace Advisor.Service
{
    public class LoginDataValidator
    {
        public bool Validate(string email, string password)
        {
            return !(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password));
        }
    }
}
