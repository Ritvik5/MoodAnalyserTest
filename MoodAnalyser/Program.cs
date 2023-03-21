namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyse moodAnalyse = new MoodAnalyse("SAD");
            var obj = moodAnalyse.AnalyseMood();
            Console.WriteLine(obj);
        }
    }
}