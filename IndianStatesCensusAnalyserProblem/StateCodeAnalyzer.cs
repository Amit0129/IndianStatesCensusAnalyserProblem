using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public  class StateCodeAnalyzer
    {
        public int ReadStateCodeData(string filePath)
        {
            //Tc2.2
            if (!File.Exists(filePath))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.FILE_INCORRECT, "Incorrect FilePath");
            }
            //Tc12.3
            if (!filePath.EndsWith(".csv"))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.TYPE_INCORRECT, "Incorrect FileType");
            }
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCodeData>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data);
                    //Console.WriteLine($"SrialNo: {data.SrNo}\tState Name: {data.StateName}\tTIN: {data.TIN}\tStateCode: {data.StateCode}");
                }
                return records.Count - 1;
            }
        }
    }
}
