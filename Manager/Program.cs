using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=SRV2\\PUPILS;Initial Catalog=Shop_214662124;Integrated Security=True;Encrypt=False";

            DataAccess dataAccess = new DataAccess();

            string toContinue = "y";
            while(toContinue == "y")
            {
                dataAccess.InsertCategory(connectionString);
                Console.WriteLine("Would you like to continue? y/n");
                toContinue = Console.ReadLine();
            }

            dataAccess.ReadCategories(connectionString);
            
        }
    }
}
