using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB3PAR4
{
    public class Lowest_temperature
    {
        private int[] temperatures;

        public Lowest_temperature(int[] temperatures)
        {
            this.temperatures = temperatures;
        }

        public void FindAndPrintLowestTemperature()
        {
            int lowestTemperature = temperatures[0];
            int lowestTemperatureDay = 1;

            for (int i = 1; i < temperatures.Length; i++)
            {
                if (temperatures[i] < lowestTemperature)
                {
                    lowestTemperature = temperatures[i];
                    lowestTemperatureDay = i + 1;
                }
            }

            Console.WriteLine($"Kallaste dagen i maj är {lowestTemperatureDay}/5 och det är {lowestTemperature} ºC.");
        }
    }
}
