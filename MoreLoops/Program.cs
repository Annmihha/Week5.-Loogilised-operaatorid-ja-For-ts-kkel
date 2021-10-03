using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul kuvatakse konsoolis "Vale kasutajatunnus või salasõna. Proovi uuest!"

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma salasõna:");
            string userPassword = Console.ReadLine();

            //AND (&&)
            //"admin" AND "admin1234" --> true
            //ülejäänud vastusevariandid --> false

            if(userName == "admin" && userPassword == "1234")
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
