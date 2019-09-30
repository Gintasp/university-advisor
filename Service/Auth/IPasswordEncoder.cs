namespace Advisor.Service.Auth
{
    public interface IPasswordEncoder
    {
        string Encode(string password, int iterations);
        string Encode(string password);
        bool IsHashSupported(string encodedString);
        bool Verify(string password, string encodedPassword);
    }
}
