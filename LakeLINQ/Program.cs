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
            double averageSize = fish.Average(f => f.SizeCm);
            Console.WriteLine($"De gemiddelde vis is {averageSize}cm groot");

            //Bereken de lengte van alle vissen samen
            int totalSize = fish.Sum(f => f.SizeCm);
            Console.WriteLine($"Alle vissen samen zijn {totalSize} cm groot");

            //Ga na of er een vis is die kleiner is dan 5cm
            bool isSuperSmall = fish.Any(f => f.SizeCm < 5);
            if (isSuperSmall)
            {
                Console.WriteLine("Er is één hele kleine vis");
            } else
            {
                Console.WriteLine("Er is geen hele kleine vis");
            }

            //Groepeer vissen op habitat
            var GroupedByCategory = fish.GroupBy(f => f.Habitat);
            foreach (var group in GroupedByCategory)
            {
                Console.WriteLine($"Categorie: {group.Key}");
                foreach(var f in group)
                {
                    Console.WriteLine($"{f.Name}");
                }
            }

            //Ga na of alle vissen predators zijn
            bool isAllPredators = fish.All(f => f.IsPredator == true);
            if (isAllPredators)
            {
                Console.WriteLine("Alle vissen zijn roofdieren");
            }
            else
            {
                Console.WriteLine("Niet alle vissen zijn roofdieren");
            }

            //De namenlijst
            List<string> fishNames = fish.Select(f => f.Name).ToList();

            //Maak een list van enkel de namen. Ga na of er een vis is die Nemo heet 
            bool nemoExists = fishNames.Contains("Nemo");
            if (nemoExists)
            {
                Console.WriteLine("You found Nemo");
            } else
            {
                Console.WriteLine("Could not find Nemo");
            }

            //Maak een list van enkel de namen. Vind de eerste naam die met C begint.
            string firstCName = fishNames.First(f => f.StartsWith("C"));

            //Ga na of er één Blobfish is (en niet meer).
            Fish blobfish = fish.SingleOrDefault(f => f.Species == "Blobfish");
            if (blobfish != null)
            {
                Console.WriteLine("Er is een blobfish");
            } else
            {
                Console.WriteLine("Er is geen blobfish");
            }

            //Zoek de vis die het minst diep leeft
            Fish shallowfish = fish.MinBy(f => f.DepthMeters);
            Console.WriteLine($"Deze vis leeft het hoogst: {shallowfish.Name} - ({shallowfish.DepthMeters}m)");

            //Zoek de vis die het diepst leeft
            Fish deepfish = fish.MaxBy(f => f.DepthMeters);
            Console.WriteLine($"Deze vis leeft het diepst: {deepfish.Name} - ({deepfish.DepthMeters}m)");

            //Selecteer de eerste 5 vissen uit de lijst
            var firstFive = fish.Take(5);


            //Negeer de eerste 10 vissen en selecteer de rest 
            var skipTen = fish.Skip(10);
        }

    }
}

