using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignsAndExceptions
{
    public class DbConnection
    {
        private static DbConnection Instance;
        public string ConnectionString { get; set; }

        private DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
            Console.WriteLine("Connecting to: " + connectionString);
        }

        public static DbConnection GetInstance()
        {
            if (Instance == null)
            {
                // create a new instance
                Instance = new DbConnection("ToastWorld");
            }

            // return the existing instance
            return Instance;
        }

        public void DoStuff()
        {
            Console.WriteLine("Doing things on the database for: " + ConnectionString);
        }
    }
}
