namespace LABB3PAR4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Everyday_in_may_temp myArray = new Everyday_in_may_temp();
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
                else if (userChoice == 10)
                {
                    Console.WriteLine("Vilken temperatur vill du ta reda på vilka dagar som har just den temperaturen eller högre?");
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
                                myArray.averageTemperature();

                                break;
                            }
                        case 5:
                            {
                                myArray.FindMedianTemperature();
                                break;
                            }
                        case 6:
                            {
                                myArray.LowerToHigher();
                                break;
                            }
                        case 7: 
                            {
                                myArray.HigherToLower();    
                                break;
                            }
                        case 8: 
                            {
                                myArray.MostCommonTemperature();
                                break; 
                            }
                        case 9: { break; }
                        case 10: { break; }

                        default:
                            Console.WriteLine("Du har valt" + " " + userChoice + "," + " " + "det är ett alternativ som inte finns, välj alternativ 1-11");
                            break;

                    }

                         if (userChoice == 9)
                         {
                            userChoice.ToString();
                             Console.WriteLine("Vilket datum är det idag, skriv in åå/mm/dd?");

                         }
            }
        }
    }
}        
    






