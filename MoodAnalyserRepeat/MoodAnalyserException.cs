using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserRepeat
{
   public class MoodAnalyserException:Exception
    {
        public enum ExceptionType //Enum class
        {
            NULL_MOOD,EMPTY_MOOD,
        }
        public ExceptionType exceptionType; // created ojbect of enum class

        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
