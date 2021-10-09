using System;

namespace ORoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kõsob kasutajalt kasutajatunnust ja salasõna
            //kui sisestatud kasutajatunnus on admin ja sisestatud salasõna on admin1234
            //siis programm konsoolis kuvatakse "tere tulemast!";
            //muul juhul kuvatakse konsoolis "Vale kasutajatunnus või salasõna. Proovi uuesti."

            //OR (või) 
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            // true || true --> true 
            //false || true --> true
            // true || false --> true
            //false || false --> false

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti.");
            }

            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
