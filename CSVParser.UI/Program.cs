using CSVParser.Core;
using CSVParser.DataAccess;
using CSVParser.Models;
using Microsoft.EntityFrameworkCore;

namespace CSVParser.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string USB_FilePath = @"D:\stardata.csv";

            if (!File.Exists(USB_FilePath))
            {
                Console.WriteLine($"{USB_FilePath} does not exist.");
            } else
            {
                SQLDataWriter dataWriter = new SQLDataWriter();

                CSVReaderService csvReader = new CSVReaderService();
                List<StarModel> stars = csvReader.ReadFromCSV(USB_FilePath);

                dataWriter.SaveRecordsToDatabase(stars);
                
            }
        }
    }
}