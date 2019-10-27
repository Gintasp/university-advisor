using Advisor.Models;

namespace Advisor.Service.Auth
{
    public sealed class SessionStorage
    {
        private static SessionStorage instance = null;
        public User User { get; set; }
        private SessionStorage() { }

        public static SessionStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SessionStorage();
                }

                return instance;
            }
        }
    }
}
