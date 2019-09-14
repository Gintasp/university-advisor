using Advisor.Model;

namespace Advisor.Validator
{
    public class SignupDataValidator
    {
        public bool Validate(User user, string passConfirm)
        {
            return !(string.IsNullOrWhiteSpace(user.Email)
                || string.IsNullOrWhiteSpace(user.Name)
                || string.IsNullOrWhiteSpace(user.Password)
                || string.IsNullOrWhiteSpace(passConfirm)
                || !user.Password.Equals(passConfirm));
        }
    }
}
