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
using System.Collections;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace CSVParser.Core
{
    public class SQLDataWriter
    {        
        public void SaveRecordsToDatabase(List<StarModel> records)
        {
            try
            {
                Console.WriteLine("Attempting to write List to Database...");
                using (var dbContext = new ApplicationDbContext())
                {
                    dbContext.AddRange(records);

                    try
                    {
                        int affectedRows = dbContext.SaveChanges();

                        if (affectedRows > 0)
                        {
                            Console.WriteLine($"{affectedRows} were affected.\nUpdate successful.");
                        } else
                        {
                            Console.WriteLine("No changes were made to the database.");
                        }

                    } catch (DbUpdateException ex)
                    {
                        Console.WriteLine($"Error saving changes to the database: {ex.Message}");
                        Console.WriteLine(ex.StackTrace);
                    }
                    dbContext.SaveChanges();
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
