using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul juhul kuvatakse konsoolis "Vale kasutajatunnus või salasõna. Proovi uuest!"
            // kasutajal on 3 katest

            int i = 0;

            while (i < 3)

            {
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma salasõna:");
            string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                { 
                    if (i != 2)
                    {
                        i = i + 1;
                        Console.WriteLine($"Vale kasutajatunnus või salasõna. Proovi uuesti, {3 - i} katset on jäänud.");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Vale kasutajatunnus või salasõna. Rohkem katseid pole");
                        break;
                    }
                }
                    else                {
                    Console.WriteLine("Tere tulemast.");
                        break;
                }
            }
        }
    }
}
