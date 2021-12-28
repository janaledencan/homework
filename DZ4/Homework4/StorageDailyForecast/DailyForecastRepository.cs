using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace ClassLibrary
{
    public class DailyForecastRepository :IEnumerable, IEnumerator
    {
        private List<DailyForecast> days;
        private  int position = -1;

        public DailyForecastRepository(){ days = new List<DailyForecast>();  }

        public void Add(DailyForecast forecast)
        {
            int flag = 0;
            int index = 0;
            int remember = 0;

            foreach(DailyForecast day in days)
            {
                if (forecast.GetDay().Date == day.GetDay().Date)
                {
                    flag++;
                    remember = index;
                } 
                index++;  
            }
            if (flag == 0)
            {
                days.Add(forecast);
            }
            else
            {
                days.Remove(days[remember]);
                days.Insert(remember,forecast);
            }
          
        }

        public void Add(List<DailyForecast> ListToAdd)
        {
            foreach (DailyForecast listElement in ListToAdd)
            {
                Add(listElement); //my previous Add method
            }
        }

        public void Remove(DateTime dayForecast)
        {
            int flag = 0;
            int index = 0;
            int remember = 0;

            if (days == null)
            {
                throw new NoSuchDailyWeatherException($"There is no elements in list.", dayForecast);
            }

            foreach (DailyForecast day in days)
            {   
                if (dayForecast.Date == day.GetDay().Date)
                {
                    flag++;
                    remember = index;
                }
                index++;
            }
           
            if(flag != 0)
            {
                days.Remove(days[remember]);
            }

            if(flag == 0)
            {
                throw new NoSuchDailyWeatherException($"No daily forecast for {dayForecast.Date}", dayForecast);
            }
        }


        public bool MoveNext()
        {
            position++;
            return (position < days.Count);
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current
        {
            get { return days[position]; }
        }

        public IEnumerator GetEnumerator()
        {
            return  (IEnumerator) this;
        }

        // Deep clone
        public DailyForecastRepository(DailyForecastRepository repository) 
        {
            days = new List<DailyForecast>();
            foreach(DailyForecast day in repository.days)
            {
                days.Add(new DailyForecast(day.GetDay(),day.Weather));
            }
        }


        //10.12.2021. 12:02:41: T=-2.449213920835973°C, w=2.967170687842728km/h, h=93.82930434952922%
        public override string ToString()
        {
            days = days.OrderBy(it => it.GetDay()).ToList();

            StringBuilder stringB = new StringBuilder();

            foreach (DailyForecast day in days)
            {
                stringB.Append(day + "\n");
            }
            
            return stringB.ToString();   
        }
    }
}
