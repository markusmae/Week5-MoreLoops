using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kõsob kasutajalt kasutajatunnust ja salasõna
            //kui sisestatud kasutajatunnus on admin ja sisestatud salasõna on admin1234
            //siis programm konsoolis kuvatakse "tere tulemast!";
            //muul juhul kuvatakse konsoolis "Vale kasutajatunnus või salasõna. Proovi uuesti."

            int i = 0;

            while(i<3)
            {
                Console.WriteLine("Palun sisesta oma kasutajanimi:");
                string user = Console.ReadLine();

                Console.WriteLine("Palun sisesta oma salasõna:");
                string password = Console.ReadLine();

                if(user == "admin" && password == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }

                else
                {
                    i++;
                    Console.WriteLine($"Vale kasutajanimi või parool. Sul on {3-i} katset jäänud.");
                }


            }
        }
    }
}
