namespace LABB3PAR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("\nHej och välkommen till temperaturberäknaren för meterologer");
            Console.WriteLine("\n*****************************************************************");

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
                int userChoice = int.Parse(Console.ReadLine());

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
                                Everyday_in_may_temp myArray = new Everyday_in_may_temp(31);

                                // Skriv ut arrayen
                                myArray.PrintArray();
                                break;
                            }
                        case 2: { break; }
                        case 3: { break; }
                        case 4: { break; }
                        case 5: { break; }
                        case 6: { break; }
                        case 7: { break; }
                        case 8: { break; }
                        case 9: { break; }
                        case 10: { break; }

                        default:
                            Console.WriteLine("Du har valt ett alternativ som inte finns, välj alternativ 1-9");
                            break;

                    }
            }
        }
    }
}        
    






