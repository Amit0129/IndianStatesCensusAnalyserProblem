using IndianStatesCensusAnalyserProblem;
namespace IndianStateCensusTest
{
    public class Tests
    {
        public static string stateCensusCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";
        [Test]
       public void GivenStateCensusData_WhenAnalyze_ShouldReturnNumberOfRecordMatches()
        {
            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            Assert.AreEqual(cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath), stateCodeAnalyzer.ReadStateCensusData(stateCensusCSVFilePath));

        }
    }
}