using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskab rohkem on mägnu võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();

            

            int cpuScore = 0;
            int userScore = 0;

            
            for (int i = 0; i < 3; i++)
            {
                int cpu = rnd.Next(1, 7);
                int user = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti viskas {cpu}. Kasutaja viskas {user}.");

                if (cpu < user)
                {
                    Console.WriteLine("Kasutaja võitis mängu, palju õnne!");
                    userScore = userScore + 1;
                }

                else if (cpu > user)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                }

                else
                {
                    Console.WriteLine("Viik.");
                }
            }

            if(userScore > cpuScore)
            {
                Console.WriteLine($"Arvuti võitis {cpuScore} korda ja kasutaja võitis {userScore} korda, seega võitis kasutaja.");
            }

            else if (userScore < cpuScore)
            {
                Console.WriteLine($"Arvuti võitis {cpuScore} korda ja kasutaja võitis {userScore} korda, seega võitis arvuti.");
            }

            else
            {
                Console.WriteLine($"Arvuti võitis {cpuScore} korda ja kasutaja võitis {userScore} korda, seega on mõlemad viigis");
            }            
        }
    }
}
