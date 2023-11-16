using CsvHelper.Configuration;
using CsvHelper;
using CSVParser.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser.Core
{
    public class CSVReaderService
    {
        public List<StarModel> ReadFromCSV(string filePath)
        {
            SQLDataWriter sqliteDataWriter = new SQLDataWriter();

            using (var reader = new StreamReader(filePath)) // check for file open or not found
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Read();
                csv.ReadHeader();
                csv.Context.RegisterClassMap<StarModelMapper>();

                // Declare the list before the loop
                List<StarModel> records = new List<StarModel>();

                try
                {
                    Console.WriteLine("Reading from the CSV...");
                    while (csv.Read())
                    {
                        var record = csv.GetRecord<StarModel>();
                        if (record != null)
                        {
                            records.Add(record);
                        } else
                        {
                            Console.WriteLine("Records were null.");
                        }
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine($"Total records read: {records.Count}");
                int count = 0;

                foreach (var r in records)
                {
                    if (count < 15)
                    {
                        Console.WriteLine($"{r.Id - r.DistanceFromSolInParsecs}");
                        count++;
                    } else
                    {
                        break;
                    }
                }
                return records;
            }
        }
    }
}
