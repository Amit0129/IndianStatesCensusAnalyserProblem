namespace IndianStatesCensusAnalyserProblem
{
    internal class Program
    {
        public static string stateCensusCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";

        public static string stateCodeCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCode.csv";
        static void Main(string[] args)
        {
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath); //Reading StateCensus CSV File

            CSVStateCode cSVStateCode = new CSVStateCode();
            cSVStateCode.ReadStateCodeData(stateCodeCSVFilePath); //Reading StateCode CSV File
        }
    }
}