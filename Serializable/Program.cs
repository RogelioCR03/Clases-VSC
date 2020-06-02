using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;

namespace Serializable
{
    public class WeatherForecast
    {
        public DateTimeOffset Date {get; set;}
        public int TemperatureCelcius{get; set;}
        public string Summary {get; set;}
        public WeatherForecast(DateTimeOffset date, int TemperatureCelcius, string Summary)
        {
            this.Date = Date;
            this.TemperatureCelcius = TemperatureCelcius;
            this.Summary = Summary;
        }

        public WeatherForecast()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List <WeatherForecast> week = new List<WeatherForecast>();

            WeatherForecast forecast = new WeatherForecast();
            forecast.Date = DateTimeOffset.Now;
            forecast.TemperatureCelcius = 21;
            forecast.Summary = "Cloudy";
            week.Add(forecast);
            week.Add(new WeatherForecast(new DateTimeOffset(2020,5,18,12,0,0,0, new TimeSpan(-5,0,0)), 37, "Sunny"));

            //Serializamos con
            string serial = JsonSerializer.Serialize(week);

            //File.WriteAllText(@"temps.json", serial);

            
            string jsonString = File.ReadAllText(@"temps.json");
            List<WeatherForecast> file_week = JsonSerializer.Deserialize<List<WeatherForecast>>(jsonString);

            foreach(WeatherForecast w in file_week)
            {
                Console.WriteLine("{0} {1}C {2}", w.Date, w.TemperatureCelcius, w.Summary);
            }
            
            Console.WriteLine(serial);
            
        }
    }
}
