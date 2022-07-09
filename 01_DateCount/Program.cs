using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DateCount
{
    class Program
    {
        public static void countdays(DateTime d)
        {
            var todayDate = DateTime.Today;
            DateTime start = DateTime.Parse(todayDate.ToString());
            DateTime end = DateTime.Parse(d.ToString());
            if (start>end)
            {
                Console.WriteLine("The day is in the past!");
            }
            else if (start==end)
            {
                Console.WriteLine("Today is the day!");
                
            }
            else
            {
                double days= (end - start).TotalDays;
                Console.WriteLine($"{days} days");
            }
                
                        
            
        }
        static void Main(string[] args)
        {
           
            countdays(new DateTime(2022,7,15));
            countdays(new DateTime(2022,7,09));
            countdays(new DateTime(2022,7,01));
            
            var todayDate = DateTime.Today;
            string strDay = todayDate.ToString();
            Console.WriteLine(strDay);
            Console.ReadLine();
        }
    }
}
