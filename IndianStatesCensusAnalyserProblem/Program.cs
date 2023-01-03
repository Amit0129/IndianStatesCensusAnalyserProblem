namespace IndianStatesCensusAnalyserProblem
{
    internal class Program
    {
        public static string stateCensusCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";
        static void Main(string[] args)
        {
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath);
        }
    }
}