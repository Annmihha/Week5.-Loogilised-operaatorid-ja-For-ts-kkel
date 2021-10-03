using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mängus osaleb 2 mängijat: arvuti (cpu) ja kasutaja (user);
            // Mõlemad mängijad viskavad täringuid;
            // Programm kontrollib kumb mängija viskas rohkem, rohkem visanud mängija on võitja;
            // * täringuid visatakse 3 korda;
            // Programm kuulutab, kes on võitja.

                      
            for (int i = 0; i < 3; i++)
            { 

               Random rnd = new Random();

                //arvuti vise:
                int cpuRandom = rnd.Next(1, 7);

                //kasutaja vise:
                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;

                }
                else
                {
                    Console.WriteLine("Viik!");
                }

            }
        }
    }
}
