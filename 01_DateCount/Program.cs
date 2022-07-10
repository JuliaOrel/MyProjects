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

        public static string Reverse(string str)
        {
            string strRev = null;
            for (int i = str.Length-1; i>=0; i--)
            {
                strRev += str[i];
            }
            return strRev;
        }

        public static long QueueTime(int[] customers, int n)
        {
            long sum = 0;
            int maxValue = 0;
            if (customers.Length > 0)
                maxValue = customers[0];
            for (int i = 0; i < customers.Length; i++)
            {
                sum += customers[i];
               
                if (maxValue < customers[i])
                    maxValue = customers[i];
            }
            if (n >= customers.Length && customers.Length != 0)
                return customers.Max();
            else if (customers.Length == 0)
                return 0;
            else { return sum / n; }
            
        }
        static void Main(string[] args)
        {

            //countdays(new DateTime(2022,7,15));
            //countdays(new DateTime(2022,7,09));
            //countdays(new DateTime(2022,7,01));

            //var todayDate = DateTime.Today;
            //string strDay = todayDate.ToString();
            //Console.WriteLine(strDay);


            string str = Reverse("world");
            Console.WriteLine(str);

            long g = QueueTime(new int[] {  }, 250);
            Console.WriteLine(g);
            Console.ReadLine();
        }
    }
}
