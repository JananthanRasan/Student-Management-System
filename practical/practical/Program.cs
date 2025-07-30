using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello, World!");
            //Console.Write("Hello, World!");

            //int myInt = 10;
            //double myDouble = 5.75;
            //bool myBool = true;

            //Console.WriteLine(Convert.ToString(myInt));    
            //Console.WriteLine(Convert.ToDouble(myInt));    
            //Console.WriteLine(Convert.ToInt32(myDouble));  
            //Console.WriteLine(Convert.ToString(myBool));

            //User Input
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your name is : " + name);
            //Console.WriteLine("Your age is : " + age);

            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

        }
    }
}
