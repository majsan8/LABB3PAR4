using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LABB3PAR4
{
    public class Everyday_in_may_temp
    {

        private int[] tempInMay = new int[31];
        private int[] originalTempInMay; // Lagrar den ursprungliga arrayen


        public Everyday_in_may_temp()
        {
            GenerateRandomTemperature();
            originalTempInMay = new int[tempInMay.Length]; // Kopiera arrayen
            Array.Copy(tempInMay, originalTempInMay, tempInMay.Length);
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

        public void averageTemperature()
        {
            int sumTemp = 0;

            foreach (int temp in tempInMay)
            {
                sumTemp += temp;
            }

            int averageTemp = (sumTemp / tempInMay.Length);

            Console.WriteLine($"Medeltemperaturen i maj är {averageTemp} ºC");
        }

        public void FindMedianTemperature()
        {


            
            Array.Sort(tempInMay);

            int middleIndex = tempInMay.Length / 2;

            if (tempInMay.Length % 2 != 0)
            {
                Console.WriteLine($"Mediantemperaturen i maj är {tempInMay[middleIndex]} ºC");
            }
            Array.Copy(originalTempInMay, tempInMay, tempInMay.Length);



        }

        public void LowerToHigher()
        {



            
            (int temp, int day)[] tempAndDay = new (int, int)[tempInMay.Length];

            // Fyll arrayen med temperaturer och datum
            for (int i = 0; i < tempInMay.Length; i++)
            {
                tempAndDay[i] = (tempInMay[i], i + 1);
            }

            // Sortera arrayen baserat på temperatur
            Array.Sort(tempAndDay, (a, b) => a.temp - b.temp);

            // Skriv ut temperaturerna med tillhörande datum
            foreach ((int temp, int day) in tempAndDay)
            {
                Console.WriteLine($"{day}/5: {temp} ºC");
            }
            
             Array.Copy(originalTempInMay, tempInMay, tempInMay.Length);
        }

        public void HigherToLower()
        {




            (int temp, int day)[] tempAndDay = new (int, int)[tempInMay.Length];

            // Fyll arrayen med temperaturer och datum
            for (int i = 0; i < tempInMay.Length; i++)
            {
                tempAndDay[i] = (tempInMay[i], i + 1);
            }

            // Sortera arrayen baserat på temperatur
            Array.Sort(tempAndDay, (a, b) => b.temp - a.temp);

            // Skriv ut temperaturerna med tillhörande datum
            foreach ((int temp, int day) in tempAndDay)
            {
                Console.WriteLine($"{day}/5: {temp} ºC");
            }

            Array.Copy(originalTempInMay, tempInMay, tempInMay.Length);
        }


    }
}


    



    

