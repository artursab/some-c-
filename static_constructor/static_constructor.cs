
using System.Text;
using System.Threading.Tasks;

namespace statcla
{


    class DbRepository
    {
        private static string connectionString;

        static DbRepository()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();

            connectionString = configurationManager.GetConnectionString();

        }

        public void GetData()
        {
            Console.WriteLine("Using: " + connectionString);
        }

        class ConfigurationManager
        {
            public string GetConnectionString()
            {
                return "local Db";
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            DbRepository repository = new DbRepository();

            repository.GetData();
        }
    }

}

