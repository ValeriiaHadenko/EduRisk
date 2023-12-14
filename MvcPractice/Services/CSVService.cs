using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace MvcPractice.Services
{
    public class CSVService
    {
        public static IEnumerable<T>ReadCSV<T>(string file)
        {
            var reader = new StreamReader(file);

            var config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                Delimiter = ";"
            };

            var csv = new CsvReader(reader, config);

            var records = csv.GetRecords<T>();

            return records;
        }
    }
}

