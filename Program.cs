using System;

namespace Crossover
{
    class Program
    {
        static string P1 = "73182465";

        static string P2 = "43286715";

        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Generation " + i + " :");
                singlePointCrossover(P1, P2);
                twoPointCrossover(P1, P2);
            }
        }


        static void singlePointCrossover(string p1, string p2)
        {
            var rand = new Random();
            var randomPoint = rand.Next(0, Math.Max(P1.Length, P2.Length));

            Console.WriteLine("Crossover point is : " + randomPoint);

            var C1 = P1.Substring(0, randomPoint) + P2.Substring(randomPoint);

            var C2 = P2.Substring(0, randomPoint) + P1.Substring(randomPoint);

            Console.WriteLine(C1 + "\n");
            Console.WriteLine(C2 + "\n");
        }

        static void twoPointCrossover(string p1, string p2)
        {
            var rand = new Random();

            var firstPoint = rand.Next(1, Math.Max(p1.Length, p2.Length));
            var secondPoint = rand.Next(firstPoint, Math.Max(p1.Length, p2.Length));


            while (firstPoint == secondPoint)
            {
                if (firstPoint == Math.Max(p1.Length, p2.Length) - 1)
                {
                    firstPoint = rand.Next(1, Math.Max(p1.Length, p2.Length));
                    secondPoint = rand.Next(firstPoint, Math.Max(p1.Length, p2.Length));
                }
                else
                {
                    secondPoint = rand.Next(firstPoint, Math.Max(p1.Length, p2.Length));
                }
            }

            Console.WriteLine("Parent P1 : " + p1);

            Console.WriteLine("Parent P2 : " + p2);

            Console.WriteLine("First crossover point is : " + firstPoint);

            Console.WriteLine("Second crossover point is : " + secondPoint);


            string p2substring = P2.Substring(0, firstPoint);
            string p1substring = P1.Substring(firstPoint, secondPoint - firstPoint);
            string p2substring2 = P2.Substring(secondPoint);

            var child = p2substring + p1substring + p2substring2;

            Console.WriteLine(child + "\n");
        }
    }
}
