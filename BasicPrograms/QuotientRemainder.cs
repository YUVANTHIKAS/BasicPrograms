using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class QuotientRemainder
    {
        public void PrintQuotientRemainder()
        {
            int q = 0, r = 0;
            Console.WriteLine("Enter first number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            q = a / b;
            r = a % b;
            Console.WriteLine("Quotient is " + q);
            Console.WriteLine("Remainder is " + r);
        }
    }
}
