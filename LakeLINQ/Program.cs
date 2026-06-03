using LakeLINQ.Domain;
using LakeLINQ.Infrastructure;
using System.Linq;
using System.Timers;
using static System.Net.WebRequestMethods;

namespace LakeLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new FishRepository();
            var fish = repo.GetAll();

            Console.WriteLine("Welcome to Lake LINQ");
            Console.WriteLine("~    ~     ~    ~ ");

            // Filter alle vissen waar Habitat = River
            var riverFish = fish.Where(f => f.Habitat == "River");
            foreach (var f in riverFish)
            {
                Console.WriteLine(f.Name + " is een riviervis");
            }

            //Filter alle vissen waar SizeCm groter dan 20
            var bigFish = fish.Where(f => f.SizeCm > 20);
            foreach (var f in bigFish)
            {
                Console.WriteLine(f.Name + " is een grote vis");
            }

            // Filter alle vissen waar IsPredator = true
            var predatorFish = fish.Where(f => f.IsPredator == true);
            foreach (var f in predatorFish)
            {
                Console.WriteLine(f.Name + " is een roofdier");
            }

            // Selecteer alle visnamen en toon deze in hoofdletter
            var capitalFish = fish.Select(f => f.Name.ToUpper());
            foreach (string f in capitalFish)
            {
                Console.WriteLine(f);
            }

            //Selecteer alle visformaten en tel er +2 bij op
            var enlargeFish = fish.Select(f => f.SizeCm + 2);
            foreach (int f in enlargeFish)
            {
                Console.WriteLine(f);
            }

            //Sorteer alle vissen alfabetisch op naam
            var alphabeticFish = fish.OrderBy(f => f.Name);
            foreach (var f in alphabeticFish)
            {
                Console.WriteLine(f.Name);
            }

            //Sorteer alle vissen op formaat van groot naar klein
            var sortedBySizeFish = fish.OrderByDescending(f => f.SizeCm);
            foreach (var f in sortedBySizeFish)
            {
                Console.WriteLine(f.SizeCm);
            }

            //Bepaal hoeveel vissen er in totaal in de repo zitten (Count)
            int totalFish = fish.Count();
            Console.WriteLine($"Er zijn in totaal {totalFish} vissen in de lijst");

            //Vind de kleinste vis
            int smallestSize = fish.Min(f => f.SizeCm);
            Console.WriteLine($"De kleinste vis is {smallestSize}cm groot");

            //Vind de grootste vis
            int biggestSize = fish.Max(f => f.SizeCm);
            Console.WriteLine($"De grootste vis is {biggestSize}cm groot");

            //Vind de gemiddelde grootte van alle vissen

            //Bereken de lengte van alle vissen samen

        }




    }
}

