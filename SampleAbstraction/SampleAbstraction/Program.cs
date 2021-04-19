using System;

namespace SampleAbstraction
{
    public abstract class Shape              //ABSTRACT CLASS
    {
        public abstract double circumference();    //ABSTRACT METHOD
    }
    class Circle : Shape               //CLASS DERIVED FROM ABSTRACT CLASS
    {
        private int radius;
        public Circle(int temporary = 0)
        {
            radius = temporary;
        }
        public override double circumference()
        {
            return (3.14 * 2 * radius);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter the value of radius");
            a = Convert.ToInt32(Console.ReadLine());
           
            Shape c = new Circle(a);
            
            double result = c.circumference();
            Console.WriteLine("circumference of the circle is.....{0}", result);
            Console.ReadKey();
        }
    }
}
