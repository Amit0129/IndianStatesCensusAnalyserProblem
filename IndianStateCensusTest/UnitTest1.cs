using IndianStatesCensusAnalyserProblem;
namespace IndianStateCensusTest
{
    public class Tests
    {
        public static string stateCensusCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCensusData.csv";
        public static string stateCensusWrongCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCensus.csv";

        [Test]
        public void GivenStateCensusData_WhenAnalyze_ShouldReturnNumberOfRecordMatches()
        {
            StateCensusAnalyzer stateCensusAnalyzer = new StateCensusAnalyzer();
            CSVStateCensus cSVStateCensus = new CSVStateCensus();
            Assert.AreEqual(cSVStateCensus.ReadStateCensusData(stateCensusCSVFilePath), stateCensusAnalyzer.ReadStateCensusData(stateCensusCSVFilePath));

        }
        [Test]
        public void GivenStateCensusDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCensusAnalyzer stateCensusAnalyzer = new StateCensusAnalyzer();
            try
            {
                int record = stateCensusAnalyzer.ReadStateCensusData(stateCensusWrongCSVFilePath);
            }
            catch(StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FilePath");
            }
        }
    }
}