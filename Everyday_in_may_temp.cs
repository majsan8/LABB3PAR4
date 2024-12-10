using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB3PAR4
{
    public class Everyday_in_may_temp
    {

        private int[] tempInMay = new int[31];

        public Everyday_in_may_temp()
        {
            GenerateRandomTemperature();
        }

        private void GenerateRandomTemperature()
        {
            Random temp = new Random();
            for (int i = 0; i < tempInMay.Length; i++)
            {
                tempInMay[i] = temp.Next(1, 16);
            }

        }
        public void PrintArray()
        {
            Console.WriteLine("Temperaturerna för maj månad");
            for (int i = 0; i < tempInMay.Length; i++)
            {
                Console.WriteLine($"{i + 1}/5: {tempInMay[i]} ºC");
            }
        }
        

        public void FindLowestTemperature()
        {
            int lowestTemperature = tempInMay[0];
            int lowestTemperatureDay = 1;

            for (int i = 1; i < tempInMay.Length; i++)
            {
                if (tempInMay[i] < lowestTemperature)
                {
                    lowestTemperature = tempInMay[i];
                    lowestTemperatureDay = i + 1;
                }
            }

            Console.WriteLine($"Kallaste dagen i maj är {lowestTemperatureDay}/5 och det är {lowestTemperature} ºC.");
        }

        public void FindHighestTemperature()
        {
            int highestTemperature = tempInMay[0];
                int highestTemperatureDay = 1;

            for (int i = 1;i < tempInMay.Length; i++)
            {
                if (tempInMay[i] > highestTemperature){
                    highestTemperature = tempInMay[i];
                    highestTemperatureDay = i + 1;
                }
            }
            Console.WriteLine($"Varmaste dagen i maj är {highestTemperatureDay}/5 och det är {highestTemperature} ºC");
        }
    } 
}


    



    

