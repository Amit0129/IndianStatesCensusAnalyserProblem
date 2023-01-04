﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesCensusAnalyserProblem
{
    public class StateCensusAnalyzer
    {
        public int ReadStateCensusData(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.FILE_INCORRECT, "Incorrect FilePath");
            }
            if (!filepath.EndsWith(".csv"))
            {
                throw new StateCensusAndCodeException(StateCensusAndCodeException.ExceptionType.TYPE_INCORRECT, "Incorrect FileType");
            }
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StateCensusData>().ToList();
                foreach (var data in records)
                {
                    //Console.WriteLine($"State name: {data.State} Population: {data.Population} AreaInSqKm :{data.AreaInSqKm} DensityPerSqKm: {data.DensityPerSqKm}");
                    Console.WriteLine(data);
                }
                return records.Count - 1;
            }
        }
    }
}