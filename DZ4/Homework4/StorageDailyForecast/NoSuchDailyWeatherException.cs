using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class NoSuchDailyWeatherException: Exception
    {
        DateTime exceptionDate;

        public NoSuchDailyWeatherException() { }
        public NoSuchDailyWeatherException(string message): base(message) { }
        public NoSuchDailyWeatherException(string message, DateTime exceptionDate) :base(message)
        {
            this.exceptionDate = exceptionDate;   
        }
    }
}
