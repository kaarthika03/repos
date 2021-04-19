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
            System.Console.WriteLine(".........Which one you wish to sow on your farmland???.......");
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
            if ((22 <= temperature && temperature <= 32) && (150 <= rainfall && rainfall <= 300))
            {
                System.Console.WriteLine("||    You may sow PADDY    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowPaddy();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((10 <= temperature && temperature <= 20) && (75 <= rainfall && rainfall <= 100))
            {
                System.Console.WriteLine("||     You may sow WHEAT     ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowWheat();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((27 <= temperature && temperature <= 32) && (50 <= rainfall && rainfall <= 100))
            {
                System.Console.WriteLine("||    You may sow Millets    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowMillets();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((20 <= temperature && temperature <= 25) && (40 <= rainfall && rainfall <= 45))
            {
                System.Console.WriteLine("||    You may sow GRAMS    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowGrams();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((21 <= temperature && temperature <= 27) && (75 <= rainfall && rainfall <= 150))
            {
                System.Console.WriteLine("||   You may sow SUGARCANE   ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowSugarcane();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((20 <= temperature && temperature <= 30) && (50 <= rainfall && rainfall <= 75))
            {
                System.Console.WriteLine("||   You may sow OIL SEEDS   ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowOilseeds();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((21 <= temperature && temperature <= 30) && (50 <= rainfall && rainfall <= 100))
            {
                System.Console.WriteLine("||   You may sow COTTON   ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowCotton();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((15 <= temperature && temperature <= 30) && (150 <= rainfall && rainfall <= 250))
            {
                System.Console.WriteLine("||   You may sow TEA or COFFEE   ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowTea();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else
                System.Console.WriteLine("You may try vegetables or fruits ...!");
        }
        public void SowVegetables()
        {
            if ((10 <= temperature && temperature <= 30) && (150 <= rainfall && rainfall <= 300))
            {
                System.Console.WriteLine("||    You may sow BEETROOT    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowBeetroot();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((21 <= temperature && temperature >= 23) && (30 <= rainfall && rainfall <= 45))
            {
                System.Console.WriteLine("||    You may sow BROCCOLI    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowBroccoli();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((temperature == 4) && (30<= rainfall && rainfall <= 50))
            {
                System.Console.WriteLine("||    You may sow POTATO    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowPotato();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((10 <= temperature && temperature <= 32) && (75 <= rainfall && rainfall <= 100))
            {
                System.Console.WriteLine("||    You may sow ONION    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowOnion();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((15 <= temperature && temperature <= 35) && (90<=rainfall && rainfall <= 140))
            {
                System.Console.WriteLine("||    You may sow TURNIP    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowTurnip();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((20 <= temperature && temperature <= 30) && (7 <= rainfall && rainfall <= 12))
            {
                System.Console.WriteLine("||    You may sow TOMATO    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowTomato();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
        }
        public void SowFruits()
        {
            if ((22 <= temperature && temperature <= 32) && (150 <= rainfall && rainfall <= 300))
            {
                System.Console.WriteLine("||    You may sow MELON    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowMelon();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
            else if ((16 <= temperature && temperature <= 30) && (130 <= rainfall && rainfall <= 150))
            {
                System.Console.WriteLine("||    You may sow CUCUMBER    ||\nMAY I SUGGEST YOU SOME TIPS...?\n" +
                    "If YES press..... 'Y' \nOr otherwise press any key\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                    SowCucumber();
                else
                    System.Console.WriteLine("|_______________  || HAPPY FARMING ||    ___________|");
            }
        }
    }
    public class Tips
    {
        public void SowPaddy()
        {
            System.Console.WriteLine("\n--->   Gather at least 1 to 2 ounces (28.5 to 56.5 g) of rice seeds to sow.\n" +
                "--->   Soak the seeds in water to prep them for planting.\n" +
                "--->   Allow them to soak for at least 12 hours but not longer than 36 hours.\n" +
                "--->   Remove the seeds from the water afterward.\n" +
                "--->   Plant the rice seeds throughout the soil, during the fall or spring season.\n" +
                "--->   Observe the water levels of the planting area, keeping the soil constantly wet.\n" +
                "--->   Space out, the rice seeds to prevent crowding.\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowWheat()
        {
            System.Console.WriteLine("\n--->   Winter wheat is planted in the fall and harvested in early spring.\n" +
                "--->   Spring wheat is planted in the spring and harvested in the fall.\n" +
                "--->   Time your planting season.Till your soil.Spread compost if necessary.\n" +
                "--->   Spread your seeds.Rake the seeds.\n" +
                "--->   Cover the seed with a thin layer of soil.Water your plants during dry spells.\n" +
                "--->   Use slug baits to keep pests away from your wheat.\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowMillets()
        {
            System.Console.WriteLine("\n--->   Place seeds below a thin layer of soil.\n" +
                "--->    Keep the seeds in a warm space with indirect light.\n" +
                "--->   Water the seeds immediately after planting.\n" +
                "--->   Millet plants enjoy good-draining soil\n" +
                "--->   Harvest seeds just before they ripen\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowGrams()
        {
            System.Console.WriteLine("\n--->   these plants grow very well under good moisture conditions.\n" +
                "--->   it is actually a winter season crop.\n" +
                "--->   Sow the seeds from October 10 to 25 for growing\n" +
                "--->   For direct sowing, 40-50 plants are desirable per square meter\n" +
                "--->   crop will be ready for harvesting when the leaves of the plants turn reddish-brown and start shedding from the plants.\n" +
                "--->   you can expect a yield between 2000 and 2500 kg per hectare.\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowSugarcane()
        {
            System.Console.WriteLine("\n--->   soils – sandy, loamy, and clay soils\n" +
                "--->   It is a spring season plant\n" +
                "--->   Stalk sections, called \"billets\" containing one or more buds—are usually planted in late summer, rooting and developing into a stand over winter.\n" +
                "--->   Sugarcane can take between 9-24 months to harvest\n" +
                "--->   A cane harvester is used to cut down the full stalks.\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowOilseeds()
        {
            System.Console.WriteLine("\n--->   Dry winter is needed at the time of ripening.\n" +
                "--->   Well drained light sandy loams, loams, red, yellow and black cotton soils are well suited for its cultivation.\n" +
                "--->   The water requirement of oilseed in general is low \n" +
                "--->   Sown in June and July and harvested in October and November.\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowCotton()
        {
            System.Console.WriteLine("\n--->   Moisture in the wind is necessary.\n" +
                "--->   Soil: Irrigated cotton should be grown on medium black to deep black soil having a pH range between 6 to 8.\n" +
                "--->   Growing season starts after the last frosts in spring.\n" +
                "--->   Harvesting starts in July in the southern states and may extend into November in the north and will be ready to harvest over time for about 6 weeks.\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowTea()
        {
            System.Console.WriteLine("\n--->   germination time of up to 8 weeks\n" +
                "--->   Soak your tea seeds in water for between 24 and 48 hours.\n" +
                "--->   Sow seeds in a warm, sunny position and spray to keep damp.\n" +
                "--->   Leave a distance of 1.5 metres between the plants.\n" +
                "\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowBeetroot()
        {
            System.Console.WriteLine("\n--->   Sowing depth: 1 inch." +
                "--->   Sowing metho: Direct method." +
                "--->   Water daily until the leaves begin to sprout." +
                "--->   Generally they're ready around 8 weeks after sowing, or when the veggie reaches 2.5cm (1 inch) in diameter. " +
                "--->   Do not cut off the leaves; instead, remove them by twisting about 5cm above the crown." +
                "\n"+
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowBroccoli()
        {
            System.Console.WriteLine("\n--->   Sowing method : Trtansplant." +
                "--->   Sowing depth : 1.5 inches." +
                "--->   Days to maturity : 90 to 100." +
                "--->   Suitable soil :  well-drained, moist soil." +
                "\n"+
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowPotato()
        {
            System.Console.WriteLine("\n--->   Sowing method : Direct." +
                "--->   Sowing depth : 4 inches." +
                "--->   Days to maturity : 70 to 120." +
                "--->   growing seasong :October to December." +
                "\n"+
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowOnion()
        {
            System.Console.WriteLine("\n--->   Sowing method : Transplant" +
                "--->   Sowing depth : 0.25 inch." +
                "--->   Days to maturity : 150 to 160" +
                "--->   growing seasong :March to October." +
                "\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowTurnip()
        {
            System.Console.WriteLine("\n--->   Sowing method : Direct." +
                "--->   Sowing depth : 0.5 inch." +
                "--->   Days to maturity : 40 to 50." +
                "--->   growing seasong :October to November." +
                "\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowTomato()
        {
            System.Console.WriteLine("\n--->   Sowing method : Transplant." +
                "--->   Sowing depth : 0.25 inches." +
                "--->   Days to maturity : 110 to 115." +
                "--->   growing seasong :(January to February ) or (June to July) or (October to November)" +
                "\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowMelon()
        {
            System.Console.WriteLine("\n--->   Sowing method : Direct." +
                "--->   Sowing depth : 1 inch." +
                "--->   Days to maturity : 70 to 85." +
                "--->   growing seasong :(January to February ) or (March to June) or (October to November)" +
                "\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
        }
        public void SowCucumber()
        {
            System.Console.WriteLine("\n--->   Sowing method : Direct." +
                "--->   Sowing depth : 0.5 inch." +
                "--->   Days to maturity : 50 to 70." +
                "--->   growing seasong :(March to June to July) or (September to October) or (December to January)" +
                "\n" +
                "                  | _______________ || HAPPY FARMING || ___________ | ");
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