using System;

namespace ViralMarketing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many days are we checking the viral marketing for?");
            int n = int.Parse(Console.ReadLine());
            int peopleLike = 0;
            int peopleShared = 0;
            int peopleAccepted = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    peopleLike = 5 / 2;
                    peopleAccepted = peopleLike;
                }
                else
                {
                    peopleShared = peopleLike * 3;
                    peopleLike = peopleShared / 2;
                    peopleAccepted += peopleLike;
                }
            }
            Console.WriteLine($"{peopleAccepted} people accepted your fliers in {n} days.");
            Console.ReadLine();
        }
    }

}
