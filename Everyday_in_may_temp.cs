using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB3PAR4
{
    public class Everyday_in_may_temp
    {

        private int[] DaysInMay;

        public Everyday_in_may_temp(int size)
        {
            DaysInMay = new int[size];
            GenerateRandomTemperature();
        }

        private void GenerateRandomTemperature()
        {
            Random temp = new Random();
            for (int i = 0; i < DaysInMay.Length; i++)
            {
                DaysInMay[i] = temp.Next(5, 115);
            }

        }
        public void PrintArray()
        {
            Console.WriteLine("Temperaturerna för maj månad");
            for (int i = 0; i < DaysInMay.Length; i++)
            {
                Console.WriteLine($"{i + 1}/5: {DaysInMay[i]} ºC");
            }
        }

        public int[] GetTemperatures()
        {
            return DaysInMay;
        }
    } 
}


    



    

