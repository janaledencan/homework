using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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

        public  NoSuchDailyWeatherException(string message, Exception innerException) : base(message,innerException){ }
        protected NoSuchDailyWeatherException(SerializationInfo info, StreamingContext context) :base(info, context){ }
    }
}
