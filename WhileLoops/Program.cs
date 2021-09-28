using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {


            /*while (true) 
            {
                Console.WriteLine("Sisesta PIN-kood:");
                int userPIn = Convert.ToInt32(Console.ReadLine());

                if (userPIn == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vale PIN proovi uuesti");
                }
            }
            Console.WriteLine("Kena päeva");*/
            int i = 0;
            while(i < 3)
            {
                Console.WriteLine("Sisesta PIN-kood");
                int userpin = Convert.ToInt32(Console.ReadLine());
                if(userpin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else
                {
                    Console.WriteLine($"Vale pin {3 - i} katset on jäänud.");
                    i = i + 1;

                }
            }
            Console.WriteLine("Kena päeva!");
            
            

        }
    }
}
