using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        private string message;

        public MoodAnalyse(string message) 
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if(this.message.Contains("I am in Sad Mood")) 
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
