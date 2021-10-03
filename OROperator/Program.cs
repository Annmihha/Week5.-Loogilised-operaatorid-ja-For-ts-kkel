using System;

namespace OROperator
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

            // OR või || (pipes)
            // true || true --> true
            // false || true --> true - vähemalt 1 operatidest/avaldistest on õige --> true
            // false || false --> false

            if (userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti");
            }
            else
            {
                Console.WriteLine("Tere tulemast.");
            }

            // if(kui) väärtus !=(pole) üks ||(või) teine siis on avaldis õige --> true - käivitub vastus "Vale kasutajatunnus või salasõna. Proovi uuesti";
            // else(teisalt) - kui aga mõlemad vääsrtused == (võrduvad) tingimustega siis avaldis on vale --> false ja konsool tervitab sisenejat;

        }
    }
}
