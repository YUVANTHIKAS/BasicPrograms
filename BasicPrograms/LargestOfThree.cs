using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LargestOfThree
    {
        public void FindLarge()
        {
            Console.WriteLine("Enter number a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number c :");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
                Console.WriteLine("a is largest");
            if ((b > a) && (b > c))
                Console.WriteLine("b is largest");
            else
                Console.WriteLine("c is largest");

        }
    }
}
