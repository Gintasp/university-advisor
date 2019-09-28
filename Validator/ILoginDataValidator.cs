namespace Advisor.Validator
{
    public interface ILoginDataValidator
    {
        bool Validate(string email, string password);
    }
}