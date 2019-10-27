using System;

namespace Advisor.Models
{
    public sealed class DB
    {
        private static readonly Lazy<DatabaseContext> instance = new Lazy<DatabaseContext>(() => new DatabaseContext());

        private DB() { }

        public static DatabaseContext Instance { get { return instance.Value; } }
    }
}
