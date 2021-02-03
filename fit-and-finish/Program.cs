using System;
using System.Collections.Generic;

namespace fit_and_finish
{
    class WeatherStation
    {
        public String Location { get; init; }

        public void AddObservation(WeatherObservation observation) 
        {
            
        }
    }

    class WeatherObservation
    {
        public double Temperature { get; init; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<WeatherObservation> observations = new();
            Console.WriteLine("Observations: " + observations.Count);

            WeatherStation station = new() { Location = "Tampere" };
            station.AddObservation(new(){ Temperature=10 });
        }
    }
}
