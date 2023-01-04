using IndianStatesCensusAnalyserProblem;
namespace IndianStateCodeTest
{
    public class Tests
    {
        public static string stateCodeCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\StateCode.csv";
        public static string stateCensusWrongCSVFilePath = @"D:\Brizlab\All.netprog\NewBatch\IndianStateCensusProblems\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\File\State.csv";

        [Test]
        public void GivenStateCodeData_WhenAnalyze_ShouldReturnNumberOfRecordMatches()
        {
            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            CSVStateCode cSVStateCode = new CSVStateCode();
            Assert.AreEqual(cSVStateCode.ReadStateCodeData(stateCodeCSVFilePath), stateCodeAnalyzer.ReadStateCodeData(stateCodeCSVFilePath));

        }
        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenAnalyzed_ShouldReturnException()
        {
            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            try
            {
                int record = stateCodeAnalyzer.ReadStateCodeData(stateCensusWrongCSVFilePath);
            }
            catch (StateCensusAndCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect FilePath");
            }
        }
    }
}