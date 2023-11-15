using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CSVParser.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CSVParser.DataAccess;

namespace CSVParser.Core
{
    public class Parser
    {
        public void ReadFromCSV()
        {
            string filePath = @"C:\Users\mjcha\Downloads\stardata.csv";
            List<StarModel> stars = new List<StarModel>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Read();
                csv.ReadHeader();                
                
                try {
                    while (csv.Read())
                    {
                        csv.Context.RegisterClassMap<StarModelMapper>();
                        var records = csv.GetRecords<StarModel>().ToList();

                        Console.WriteLine("Writing to DB...");

                        
                        using (var dbContext = new ApplicationDbContext())
                        {
                            

                            dbContext.Stars.AddRange(records);
                            int affectedRows = dbContext.SaveChanges();

                            if (affectedRows > 0)
                            {
                                Console.WriteLine($"{affectedRows} were affected.\nSaveChanges successfully.");
                            } else
                            {
                                Console.WriteLine("No changes were made to the database.");
                            }
                        }

                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
