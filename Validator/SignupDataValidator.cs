using Advisor.Model;
using System.Text.RegularExpressions;

namespace Advisor.Validator
{
    public class SignupDataValidator
    {
        private string errorMessage;
        private User user;

        public bool Validate(User user, string passConfirm)
        {
           this.user = user;
            if ((CheckForEmptyFields(passConfirm) &&
                 CheckEmailByRegex() &&
                 CheckPasswordByRegex()))
            {
                errorMessage = null;
                return true;
            }

            return false;
        }
        public string GetSignupDataVadilatorErrorMessage()
        {
            return errorMessage;
        }
        private bool CheckEmailByRegex()
        {
            Regex r = new Regex(@"^([\w\.]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(user.Email)) return true;

            errorMessage = "Invalid email.";
            return false;
        }
        private bool CheckPasswordByRegex()
        {
            Regex r = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
            if(r.IsMatch(user.Password)) return true;

            errorMessage = "Password must contain at least eight characters, one uppercase letter, one lowercase letter and one number";
            return false;

        }
        private bool CheckForEmptyFields(string passConfirm)
        {
            if (!(string.IsNullOrWhiteSpace(user.Email)
                || string.IsNullOrWhiteSpace(user.FirstName)
                || string.IsNullOrWhiteSpace(user.LastName)
                || string.IsNullOrWhiteSpace(user.Password)
                || string.IsNullOrWhiteSpace(passConfirm))) return true;
                      
             errorMessage = "Please enter all required fields.";
             return false;
            
        } 
    }
}
