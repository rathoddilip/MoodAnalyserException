using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserRepeat
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser()
        {

        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// ability to analyse and respond happy or sad mood
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string MoodAnalyserMethod(string message)
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException )
            {
                return "HAPPY";
            }
        }
        /// <summary>
        /// Constructor method 
        /// </summary>
        /// <returns></returns>
        public string MoodAnalyseConstructorMethod()
        {

            if (this.message.ToLower().Contains("sad"))
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
