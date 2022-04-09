using System;
using System.Threading.Tasks;

namespace PrimeService
{
    public class SyncBreakfastService
    {
        private static void Main(string[] args)
        {
            var service = new SyncBreakfastService();
            service.SyncCook();
        }

        public void SyncCook()
        {
            var cup = pourCoffee();
            Console.WriteLine("coffee is ready");

            var eggs = fryEgs(2);
            Console.WriteLine("eggs are ready");

            var bacon = fryBacon(3);
            Console.WriteLine("bacon is ready");

            var toast = toastBread(2);
            applyButter(toast);
            applyJam(toast);
            Console.WriteLine("toast is ready");

            var oj = pourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready");
        }

        private Coffee pourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }

        private Egg fryEgs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }

        private Bacon fryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }

            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private Toast toastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread int the toaster");
            }

            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private void applyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private void applyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private Juice pourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }
    }
}