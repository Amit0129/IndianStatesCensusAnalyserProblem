using IndianStatesCensusAnalyserProblem;
namespace IndianStateCodeTest
{
    public class Tests
    {
        public static string stateCodeCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCode.csv";

        [Test]
        public void GivenStateCodeData_WhenAnalyze_ShouldReturnNumberOfRecordMatches()
        {
            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            CSVStateCode cSVStateCode = new CSVStateCode();
            Assert.AreEqual(cSVStateCode.ReadStateCodeData(stateCodeCSVFilePath), stateCodeAnalyzer.ReadStateCodeData(stateCodeCSVFilePath));

        }
    }
}