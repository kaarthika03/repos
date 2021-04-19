using System;

namespace Abstraction
{
    public abstract class  Shape              //ABSTRACT CLASS
    {
        public abstract double circumference();    //ABSTRACT METHOD
    }
    class Circle : Shape               //CLASS DERIVED FROM ABSTRACT CLASS
    {
        private int r;
        public void Radius(int x=0)
        {
        r = x;
        }
        public override double circumference()
        {
        return (3.14 * 2 * r);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        int a;
        Console.WriteLine("enter the value of radius");
        a=Convert.ToInt32(Console.ReadLine());
        Circle c = new Radius(a);
        double result = c.circumference();
        Console.WriteLine("circumference of the circle is.....{0}", result);
        }
    }
}
