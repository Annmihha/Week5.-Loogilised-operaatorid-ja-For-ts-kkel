using System;

namespace ForLoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub kasutajal sisestada 3 numbrit;
            //Programm kuvab nende numbrite summat;

            int sum = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sisesta number/arv:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + userNumber;
            }
            Console.WriteLine($"Sinu tulemus on: {sum}");
        }
    }
}
