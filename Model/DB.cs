namespace Advisor.Model
{
    public sealed class DB
    {
        private static DatabaseContext instance = null;

        private DB() { }

        public static DatabaseContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseContext();
                }

                return instance;
            }
        }
    }
}
