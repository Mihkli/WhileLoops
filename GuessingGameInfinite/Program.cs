using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpurandom = rnd.Next(1, 11);

            while (true)
            {
                Console.WriteLine("Sisesta number");
                int userguess = Convert.ToInt32(Console.ReadLine());

                if(userguess == cpurandom)
                {
                    Console.WriteLine("Tubli! Oled mängu võitnud");
                    break;
                }
                else
                {
                    Console.WriteLine("Proovi uuesti");
                }
            }
            
            
        }
    }
}
