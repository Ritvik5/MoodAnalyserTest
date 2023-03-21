using MoodAnalyser;

namespace MoodAnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);


            string mood = moodAnalyse.AnalyseMood();


            Assert.AreEqual(expected, mood);
        }
    }
}