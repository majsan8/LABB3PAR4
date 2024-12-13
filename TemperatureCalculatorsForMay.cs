using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LABB3PAR4
{
    public class TemperatureCalculatorsForMay
    {
        //Skapar en array med 31 index.
        private int[] tempInMay = new int[31];
        private int[] originalTempInMay; // Lagrar den ursprungliga arrayen

        //Skapar en metod för att generera en randomtemperatur för alla dagar i majarrayen.
        public TemperatureCalculatorsForMay()
        {
            GenerateRandomTemperature();
            originalTempInMay = new int[tempInMay.Length]; // Kopierar arrayen som används senare i programmet.
            Array.Copy(tempInMay, originalTempInMay, tempInMay.Length);
        }

        //Här skapar vi metoder som tillkallas beroende på användarens input om vad den vill se för information.
        //Denna metod genererar en random temperatur för alla dagar i maj/ vår array med 31 index.
        private void GenerateRandomTemperature()
        {
            Random temp = new Random();
            for (int i = 0; i < tempInMay.Length; i++)
            {
                tempInMay[i] = temp.Next(1, 16);
            }

        }

        //Metod för att skriva ut arrayen med datum och temperatur.
        public void PrintArray()
        {
            Console.WriteLine("\nTemperaturerna för maj månad:\n");
            for (int i = 0; i < tempInMay.Length; i++)
            {
                Console.WriteLine($"{i + 1}/5: {tempInMay[i]} ºC");

            }
        }
        
        //Metod som hittar och skriver ut den lägsta temperaturen i maj.
        public void FindLowestTemperature()
        {
            int lowestTemperature = tempInMay[0];
            int lowestTemperatureDay = 1;

            for (int i = 1; i < tempInMay.Length; i++)
            {
                if (tempInMay[i] < lowestTemperature) //Här loopar vi igenom hela vår array och sparar det lägsta värdet i en variabel.
                {
                    lowestTemperature = tempInMay[i];
                    lowestTemperatureDay = i + 1;
                }
            }

            Console.WriteLine($"\nKallaste dagen i maj är den {lowestTemperatureDay}/5 och det är {lowestTemperature} ºC.\n");
        }

        //Metod som hittar och skriver ut den högsta temperaturen i maj.
        public void FindHighestTemperature()
        {
            int highestTemperature = tempInMay[0];
                int highestTemperatureDay = 1;

            for (int i = 1;i < tempInMay.Length; i++) //Här sparar vi det högsta värdet i en variabel. 
            {
                if (tempInMay[i] > highestTemperature){
                    highestTemperature = tempInMay[i];
                    highestTemperatureDay = i + 1;
                }
            }
            Console.WriteLine($"\nVarmaste dagen i maj är den {highestTemperatureDay}/5 och det är {highestTemperature} ºC\n");
        }

        //Metod som hittar och skriver ut den mest vanliga temeperaturen i maj. 
        public void FindAverageTemperature()
        {
            int sumTemp = 0; 

            foreach (int temp in tempInMay) //Denna loop går vi igenom hela arrayen och adderar varje värde till variabeln sumTemp.
            {
                sumTemp += temp;
            }

            int averageTemp = (sumTemp / tempInMay.Length); //Här får vi ut meddeltemperaturen genom att ta sumTemp som är summan för alla temperaturer och delar det på arrayens längd (31).

            Console.WriteLine($"\nMedeltemperaturen i maj är {averageTemp} ºC\n");
        }

        //Metod som hittar och skriver ut mediantemperaturen.
        public void FindMedianTemperature()
        {
  
            Array.Sort(tempInMay); //Här sorterar vi arrayen för att så att det blir lättare att hitta medianen.

            int middleIndex = tempInMay.Length / 2; //Vi hittar medianen genom att söka efter det mittersta indexet.

            if (tempInMay.Length % 2 != 0)
            {
                Console.WriteLine($"\nMediantemperaturen i maj är {tempInMay[middleIndex]} ºC\n");
            }
            Array.Copy(originalTempInMay, tempInMay, tempInMay.Length); //Här använder vi kopian som vi skapade i början för att få tillbaka orginalordningen på arrayen efter att vi sorterade den.

        }

        //Metod för att skriva ut datum och temperaturer i stigande ordning.
        public void PrintLowerToHigherTemperature()
        {

            (int temp, int day)[] tempAndDay = new (int, int)[tempInMay.Length]; //Här konkateneras två arrayer till en för att datum och temperatur blir statiskt.

            //Här fylls arrayen med temperaturer och datum.
            for (int i = 0; i < tempInMay.Length; i++)
            {
                tempAndDay[i] = (tempInMay[i], i + 1);
            }

            // Sortera arrayen baserat på temperatur.
            Array.Sort(tempAndDay, (a, b) => a.temp - b.temp);

            Console.WriteLine("Temperatur stigande:\n");

            // En Foreach-loop som skriver ut temperaturerna med tillhörande datum i stigande ordning.
            foreach ((int temp, int day) in tempAndDay)
            {
                Console.WriteLine($"{day}/5: {temp} ºC");
            }
            
             Array.Copy(originalTempInMay, tempInMay, tempInMay.Length);
        }

            //Metod för att skriva ut datum och temeperatur i fallande ordning. 
        public void PrintHigherToLowerTemperature()
        {

            (int temp, int day)[] tempAndDay = new (int, int)[tempInMay.Length];

            for (int i = 0; i < tempInMay.Length; i++)
            {
                tempAndDay[i] = (tempInMay[i], i + 1);
            }

            Array.Sort(tempAndDay, (a, b) => b.temp - a.temp); //Här ändrar vi ordningen så att arrayen visas i fallande ordning. 

            Console.WriteLine($"Temperatur fallande:\n");

            foreach ((int temp, int day) in tempAndDay)
            {
                Console.WriteLine($"{day}/5: {temp} ºC");
            }

            Array.Copy(originalTempInMay, tempInMay, tempInMay.Length);
        }

            //Metod för att hitta den vanligaste temperaturen i maj. 
        public void FindMostCommonTemperature()
        {
            Dictionary<int, int> tempCount = new Dictionary<int, int>(); //Här skapas en dictionary som används för att hålla koll på hur många dagar det är en viss temperatur
                                                                         //Med nyckelordet int spar temperaturen och värdet int lagrar hur många gånger temperaturen förekommer.

            foreach (int temp in tempInMay) //Foreach loop som går igenom arrayen och lägger till värdet 1 i if-else-satsen.
            {

                if (tempCount.ContainsKey(temp))
                {
                    tempCount[temp]++;
                }
                else
                {
                    tempCount.Add(temp, 1);
                }
            }

            int mostCommonTemp = 0;
            int mostFrequentTemp = 0;

            foreach (KeyValuePair<int, int> kvp in tempCount) //Här går vi igenom vår dictionary.
            {
                if (kvp.Value > mostFrequentTemp) //Här går vi igenom varje temperatur och räknar hur många gånger den förekommer.
                                                  //Om vi hittar en temperatur som förekommer fler gånger än den som hittils förekommit mest, uppdateras mostCommonTemp med det nya värdet. 
                {
                    mostFrequentTemp = kvp.Value;
                    mostCommonTemp = kvp.Key;
                }

            } 
            Console.WriteLine($"\nDen vanligaste temperaturen i maj är {mostCommonTemp}ºC");
        }

                //Metod för att skriva ut temperaturen igår, idag och imorgon. 
        public void PrintTempYesterdayTodayTomorrow(DateTime today)
        {
            (int temp, int day)[] tempAndDay = new (int, int)[tempInMay.Length]; //Två arrayer som blir till en för att få datum och temperatur för alla dagar i maj. 
            Console.WriteLine("Vilket datum är det idag, skriv in dagen med siffror, så endast dd? \n");


            string userInput = Console.ReadLine(); //Imput från användaren för att veta vilken dag det är "idag" hos denne.
            int day;

            if (int.TryParse(userInput, out day) && day >= 1 && day <= 31) //Parsar input från en sträng till en int.
            {
                DateTime selectedDate = new DateTime(2024, 5, day); //Spar användarens input "day" i selecteddate.
                DateTime yesterday = selectedDate.AddDays(-1); //Användarens input "day" - 1 för att få fram igår.
                DateTime tomorrow = selectedDate.AddDays(1); //Användarens input +1 för att få fram imorgon. 

                int selectedIndex = selectedDate.Day - 1; //För att få fram rätt dag till rätt index, subtraherar vi med -1 eftersom vi måste ta hänsyn till nollindexering.
                int yesterdayIndex = yesterday.Day - 1;
                int tomorrowIndex = tomorrow.Day - 1;

                int todayTemperature = tempInMay[selectedIndex]; //Här kopplas index för dagar och temperaturen ihop ihop. 
                int yesterdayTemperature = tempInMay[yesterdayIndex];
                int tomorrowTemperature = tempInMay[tomorrowIndex];

                Console.WriteLine($"\nIgår: {yesterday.ToString("MM/dd")}: {yesterdayTemperature} ºC");
                Console.WriteLine($"Idag: {selectedDate.ToString("MM/dd")}: {todayTemperature} ºC");
                Console.WriteLine($"Imorgon: {tomorrow.ToString("MM/dd")}: {tomorrowTemperature} ºC");
            }
            else
            {
                Console.WriteLine("\nFelaktigt datum, välj ett datum mellan 1-31 och skriv bara in daten (dd)");
            }
            
        }

                //Metod för att hitta och skriva ut dagar som är över en viss temperatur.
        public void FindTempOverXDegrees()
        {
            Console.WriteLine("\nVilken temperatur vill du veta vilka dagar det har varit över det?\n"); //Användaren får här välja en temperatur.
            string targetTemperature = Console.ReadLine();
            int targetTemp = int.Parse(targetTemperature); //Parsar input från sträng till int.
            int daysAbove = 0;
            Console.WriteLine($"\nDagar med temperatur över {targetTemp} ºC:\n");
            for (int i = 0; i < tempInMay.Length; i++) //Här stegar vi igenom hela arrayen.
            {
                if (tempInMay[i] > targetTemp) //För varje temperatur osm är högre än användarens input så skriver vi ut den dagen och temperaturen.
                {
                    daysAbove++;
                    Console.WriteLine($"{i + 1}/5: {tempInMay[i]} ºC");
                }
            }
            if (daysAbove == 0) //Om ingen dag skulle ha en temperatur över användarens input, så kommer daysAbove fortfarande vara 0 vilket resulterar i denna utskrift. 
            {

                Console.WriteLine($"\nIngen dag i maj hade en temperatur över {targetTemp} ºC.");
            }

        }  
    }
}


    



    

