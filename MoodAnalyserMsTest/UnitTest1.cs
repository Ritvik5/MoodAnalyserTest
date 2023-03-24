using MoodAnalyser;

namespace MoodAnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenEmptyMoodShouldThrowException()
        {
            try
            {
                string message = "";
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.AnalyseMood();    
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
    }
}