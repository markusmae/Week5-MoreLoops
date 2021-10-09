using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kõsob kasutajalt kasutajatunnust ja salasõna
            //kui sisestatud kasutajatunnus on admin ja sisestatud salasõna on admin1234
            //siis programm konsoolis kuvatakse "tere tulemast!";
            //muul juhul kuvatakse konsoolis "Vale kasutajatunnus või salasõna. Proovi uuesti."
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            //AND &&

            if (userName == "admin" && userPassword == "admin 1234")
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
        }
    }
}
