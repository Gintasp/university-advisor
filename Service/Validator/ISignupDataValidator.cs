using Advisor.Model;

namespace Advisor.Service.Validator
{
    public interface ISignupDataValidator
    {
        bool Validate(User user, string passConfirm);
        string GetSignupDataVadilatorErrorMessage();
    }
}