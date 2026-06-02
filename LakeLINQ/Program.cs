using LakeLINQ.Infrastructure;

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
        }
    }
}
