using System;

namespace YabsProblemA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] gunnarArray = input.Split(' ');

            string input2 = Console.ReadLine();
            string[] emmaArray = input2.Split(' ');

            double gunnarEV, emmaEV;

            gunnarEV = ((int.Parse(gunnarArray[0]) + int.Parse(gunnarArray[1])) / 2.0) + ((int.Parse(gunnarArray[2]) + int.Parse(gunnarArray[3])) / 2.0);
            emmaEV = ((int.Parse(emmaArray[0]) + int.Parse(emmaArray[1])) / 2.0) + ((int.Parse(emmaArray[2]) + int.Parse(emmaArray[3])) / 2.0);

            if (gunnarEV > emmaEV)
            {
                Console.WriteLine("Gunnar");
            }
            else if (gunnarEV < emmaEV)
            {
                Console.WriteLine("Emma");
            }
            else
            {
                Console.WriteLine("Tie");
            }
        }
    }
}
