using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using System.Text;

namespace CommerceProject.Services
{
    public static class ExportToSpreadsheet
    {
        public static void create_csv(List<TransactionModel> tlist)
        {
            
            var csvpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"TransactionReport.csv");
            using (var streamWriter = new StreamWriter(csvpath, false))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture, false))
                {
                    
                    
                    csvWriter.Context.RegisterClassMap<TransactionModelClassMap>();
                    csvWriter.WriteRecords<TransactionModel>(tlist);

                    
                }
                
            }
        }

    }
}
