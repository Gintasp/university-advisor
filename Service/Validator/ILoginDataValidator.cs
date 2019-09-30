namespace Advisor.Service.Validator
{
    public interface ILoginDataValidator
    {
        bool Validate(string email, string password);
    }
}