using MoodAnalyser;

namespace MoodAnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);


            string mood = moodAnalyse.AnalyseMood();


            Assert.AreEqual(expected, mood);
        }
    }
}