using System;

namespace AccessModifiers
{
    public class Shape   
    {
   
        public int length=2;
        internal int breadth=3;
        public void setShape(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
    }
    public class Rectangle : Shape
    {

        public int area;
        public void Area()
        {
            area = length * breadth;
            Console.WriteLine(area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth of the rectangle");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            Rectangle r = new Rectangle();
            r.setShape(value1, value2);
            r.Area();
        }
    }
}
