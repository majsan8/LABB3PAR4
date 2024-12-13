namespace LABB3PAR4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TemperatureCalculatorsForMay myArray = new TemperatureCalculatorsForMay();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("\nHej och välkommen till temperaturberäknaren för meterologer");
            Console.WriteLine("\n*****************************************************************");
            int userChoice;
            while (true)
            {
                Console.WriteLine("\nVälj ett alternativ du vill se information om, svara med siffra:\n" +
                "\n 1. Visa temperatur för alla dagar i Maj" +
                "\n 2. Dagen med högst temperatur" +
                "\n 3. Dagen med lägst temperatur" +
                "\n 4. Medeltemperaturen" +
                "\n 5. Mediantemperaturen" +
                "\n 6. Temperatur stigande" +
                "\n 7. Temperatur fallande" +
                "\n 8. Vanligaste temperaturen i Maj" +
                "\n 9. Temperaturen igår, idag och imorgon" +
                "\n 10. Alternativ för att ta reda på hur många dagar det varit över en viss temperatur" +
                "\n 11. Avsluta programmet\n");
                userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 11)
                {
                    Console.WriteLine("Nu avslutas programmet.");
                    Environment.Exit(0);

                }
              
                
                else
                    switch (userChoice)
                    {
                        case 1:
                            {
                                myArray.PrintArray();
                                break;
                            }
                        case 2: 
                            {
                             
                                myArray.FindLowestTemperature();
                                break; 
                            }
                        case 3: 
                            {
                              
                                myArray.FindHighestTemperature();


                                break; 
                            }
                        case 4:
                            {
                                myArray.FindAverageTemperature();

                                break;
                            }
                        case 5:
                            {
                                myArray.FindMedianTemperature();
                                break;
                            }
                        case 6:
                            {
                                myArray.PrintLowerToHigherTemperature();
                                break;
                            }
                        case 7: 
                            {
                                myArray.PrintHigherToLowerTemperature();    
                                break;
                            }
                        case 8: 
                            {
                                myArray.FindMostCommonTemperature();
                                break; 
                            }
                        case 9: 
                            {
                                myArray.PrintTempYesterdayTodayTomorrow(DateTime.Today);
                                break; 
                            }
                        case 10: 
                            {
                                myArray.FindTempOverXDegrees();
                                break;
                            }

                        default:
                            Console.WriteLine("Du har valt" + " " + userChoice + "," + " " + "det är ett alternativ som inte finns, välj alternativ 1-11");
                            break;

                    }

                
            }
        }
    }
}        
    






