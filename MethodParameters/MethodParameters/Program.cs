using System;

namespace MethodParameters
{
    class Parameters
    {
        public void Change(int value_1,ref int value_2,out int value_3)  //passing value1 as VALUE and value2 as REF
        {
            value_1 += 5;        //changed value does not affect the actual parameters
            value_2 += 5;        //REF(changed value affect the actual parameters)
            value_3 = value_1 + value_2;   //OUT parameter
        }
    }
    class Program
    { 
   
        static void Main(string[] args)
        {
            Parameters p = new Parameters();
            Console.WriteLine("Enter two integer values:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2= 0;  //ref parameter should be intialized
            value2 = Convert.ToInt32(Console.ReadLine());
            int value3;     //out parameter should not be initialized
            Console.WriteLine("Before method invoking....... VALUE 1:{0},VALUE 2:{1}", value1, value2);
            p.Change(value1,ref value2,out value3);
            Console.WriteLine("After method invoked....... VALUE 1: {0},VALUE 2: {1},VALUE 3: {2}", value1, value2,value3);
        }
    }
}
