namespace Advisor.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public Student() { }

        public Student(string email, string firstName, string lastName, string password)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }
    }
}
