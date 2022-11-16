using System;

namespace World_Of_Warcraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            

            Console.WriteLine("Select your class.");
            Console.WriteLine(".1 Mage");
            Console.WriteLine(".2 Warrior");
            Console.WriteLine(".3 Warlock");
            Console.WriteLine(".4 Rouge");
            Console.WriteLine(".5 Hunter");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.WriteLine("Du valde mage " + slump.Next(6000, 9001));
                    if (slump.Next(6000, 9000) > 7000)
                    {
                        Console.WriteLine("Din mage har big gear med good pump");
                    }

                    else
                    {
                        Console.WriteLine("Din Mage har inte bra gear med shit pump");
                    }

                    break;

            }


        }
    }
    
}