using Advisor.Model;

namespace Advisor.Validator
{
    public interface ISignupDataValidator
    {
        bool Validate(User user, string passConfirm);
        string GetSignupDataVadilatorErrorMessage();
    }
}