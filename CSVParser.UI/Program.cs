using CSVParser.Core;
using CSVParser.DataAccess;

namespace CSVParser.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                try
                {
                        Parser p = new Parser();
                        p.ReadFromCSV();
                } 
                catch (Exception ex) {
                    Console.WriteLine("Failed\n");
                    Console.WriteLine(ex.Message);
                }                
            }

        }
    }
}