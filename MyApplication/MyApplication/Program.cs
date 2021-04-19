using MyApplication;
using System;

namespace MyApplication
{
    class Options:Cultivation
    {
        public void PickUp()
        {
            System.Console.WriteLine("..... ||   Enter the average Rainfall in your area in Centi Meter   || .....");
            rainfall = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("..... ||   Enter the average temperature in your area in Dgree Celcius  || ....");
            temperature = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(".........Which one you wish to sow on yout farmland???.......");
            System.Console.WriteLine("1.) Grains");
            System.Console.WriteLine("2.) vegetables");
            System.Console.WriteLine("3.) fruits");
            int option = Convert.ToInt32(System.Console.ReadLine());
            //return (option);
            switch (option)
            {
                case 1:SowGrains();
                    break;
                case 2:SowVegetables();
                    break;
                case 3:SowFruits();
                    break;
                default:System.Console.WriteLine("May choose correct option");
                    break;
            }
        }
    }
    public  class Cultivation:Tips
    {
        public int rainfall;
        public int temperature;
        public void SowGrains()
        {
            if (((22 <= temperature) || (temperature <= 32)) && ((150 <= rainfall) || (rainfall <= 300)))
            {
                System.Console.WriteLine("||    You may sow PADDY    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowPaddy();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((10 <= temperature || temperature <= 20) && (75 <= rainfall || rainfall <= 100))
            {
                System.Console.WriteLine("||     You may sow WHEAT     ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowWheat();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((27 <= temperature || temperature <= 32) && (50 <= rainfall || rainfall <= 100))
            {
                System.Console.WriteLine("||    You may sow Millets    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowMillets();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((20 <= temperature || temperature <= 25) && (40 <= rainfall || rainfall <= 45))
            {
                System.Console.WriteLine("||    You may sow GRAMS    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowGrams();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((21 <= temperature || temperature <= 27) && (75 <= rainfall || rainfall <= 150))
            {
                System.Console.WriteLine("||   You may sow SUGARCANE   ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowSugarcane();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((20 <= temperature || temperature <= 30) && (50 <= rainfall || rainfall <= 75))
            {
                System.Console.WriteLine("||   You may sow OIL SEEDS   ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowOilseeds();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((21 <= temperature || temperature <= 30) && (50 <= rainfall || rainfall <= 100))
            {
                System.Console.WriteLine("||   You may sow COTTON   ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowCotton();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((15 <= temperature || temperature <= 30) && (150 <= rainfall || rainfall <= 250))
            {
                System.Console.WriteLine("||   You may sow TEA or COFFEE   ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowTea();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else
                System.Console.WriteLine("You may try any other than grains ...!");
        }
        public void SowVegetables()
        {
            
        }
        public void SowFruits()
        {

        }
    }
    public class Tips
    {
        public void SowPaddy()
        {
            System.Console.WriteLine("--->Gather at least 1 to 2 ounces (28.5 to 56.5 g) of rice seeds to sow.\n" +
                "--->Soak the seeds in water to prep them for planting.\n" +
                "--->Allow them to soak for at least 12 hours but not longer than 36 hours.\n" +
                "--->Remove the seeds from the water afterward.\n" +
                "--->Plant the rice seeds throughout the soil, during the fall or spring season.\n" +
                "---Observe the water levels of the planting area, keeping the soil constantly wet.\n" +
                "--->space out, the rice seeds to prevent crowding.\n");
        }
        public void SowWheat()
        {
            System.Console.WriteLine("--->Winter wheat is planted in the fall and harvested in early spring.\n" +
                "--->Spring wheat is planted in the spring and harvested in the fall.\n" +
                "--->Time your planting season.Till your soil.Spread compost if necessary.\n" +
                "--->Spread your seeds.Rake the seeds.\n" +
                "--->Cover the seed with a thin layer of soil.Water your plants during dry spells.\n" +
                "--->use slug baits to keep pests away from your wheat.\n");
        }
        public void SowMillets()
        {
            System.Console.WriteLine("--->Place seeds below a thin layer of soil.\n" +
                "--->Keep the seeds in a warm space with indirect light.\n" +
                "--->Water the seeds immediately after planting.\n" +
                "--->millet plants enjoy good-draining soil\n" +
                "--->Harvest seeds just before they ripen\n");
        }
        public void SowGrams()
        {

        }
        public void SowSugarcane()
        {

        }
        public void SowOilseeds()
        {

        }
        public void SowCotton()
        {

        }
        public void SowTea()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Options op = new Options();
            op.PickUp();
        }
    }
}