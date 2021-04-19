using System;

namespace Inheritance
{
    class AcademicDetails                                      //   Accademic details of students
    {
        string name;
        string department;
        int studentId;
        double cgpa;
        public void GetData()
        {
            Console.WriteLine("Enter the NAME,ID,DEPARTMENT,CGPA");
            name = Console.ReadLine();
            studentId = Convert.ToInt32(Console.ReadLine());
            department = Console.ReadLine();
            cgpa = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine(studentId);
            Console.WriteLine(department);
            Console.WriteLine(cgpa);
        }
    }
    class SportsDetails : AcademicDetails                          //  sports details of students derived from AccademicDetails
    {
        double height;
        double weight;
        int age;
        public void GetDetails()
        {
            Console.WriteLine("Enter HEIGHT,WEIGHT,AGE");
            height = Convert.ToDouble(Console.ReadLine());
            weight = Convert.ToDouble(Console.ReadLine());
            age = Convert.ToInt32(Console.ReadLine());

        }
        public void ShowDetails()
        {
            Console.WriteLine(height);
            Console.WriteLine(weight);
            Console.WriteLine(age);
        }
    }
    class Program                                                   //    main class
    {
        public static void Main(string[] arg)
        {
            SportsDetails s = new SportsDetails();
            s.GetData();
            s.GetDetails ();
            Console.WriteLine("Details are:");
            s.Display();
            s.ShowDetails();
            Console.ReadKey();
        }
    }
}