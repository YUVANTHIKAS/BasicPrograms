using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine()); 
            if((year %4 ==0) && (year %100 != 0) || (year % 400)==0))
                    Console.WriteLine("Leap year");
           else
                Console.WriteLine("Not a Leap year");
        }
    }
}
