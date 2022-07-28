using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DateCount
{
    class Program
    {
        public static string Greet(string name)
        {
            string greeting = "Hello, how are you doing?";
            char ch = ',';
            string name1 = ' ' + name;
            int indexOfChar = greeting.IndexOf(ch);
            greeting = greeting.Insert(indexOfChar + 1, name1);
            return greeting;
            
            //throw new NotImplementedException("Greet is not implemented.");
        } 
        public static long[] Digitize(long n)
        {

         if(n==0)
            { long[] array = new long[1] {0};
                return array;
            }

          long digit = 0;
            List<long> longList = new List<long>();
            while (n != 0)
            {
                digit=n% 10;
                n /= 10;
                longList.Add(digit);

            }
            long[] arr = new long[longList.Count];
            for (int i = 0; i < longList.Count; i++)
            {
                arr[i] = longList[i];
            }
            return arr;
            

            // Code goes here
        }
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
                if (maxValue < customers[i])
                    maxValue = customers[i];
            }
            if (n >= customers.Length && customers.Length != 0)
                return customers.Max();
            else if (customers.Length == 0)
                return 0;
            else if (n == 1)
            {
                for (int i = 0; i < customers.Length; i++)
                {
                    sum += customers[i];
                }
                return sum;
            }
            else
            {
                int[] total = new int[n];

                for (int i = 0; i < customers.Length; i++)
                {
                    total[0] += customers[i];
                    Array.Sort(total);                
                }           
                return total[n - 1];

            }            
            
        }

        public static int[] reverseList(int[] list)
        {
            int[] reverseList = new int[list.Length];
            int j = 0;
            for (int i = list.Length-1; i >=0; i--)
            {
                reverseList[j] = list[i];
                j++;
            }
            return reverseList;
        }
        static void Main(string[] args)
        {

            //countdays(new DateTime(2022,7,15));
            //countdays(new DateTime(2022,7,09));
            //countdays(new DateTime(2022,7,01));

            //var todayDate = DateTime.Today;
            //string strDay = todayDate.ToString();
            //Console.WriteLine(strDay);


            //string str = Reverse("world");
            //Console.WriteLine(str);

            //long g = QueueTime(new int[] {10,3,5,7}, 3);
            //Console.WriteLine(g);
            //Console.ReadLine();

            //int[] list = new int[5] {1,2,3,4,5};
            //int[]reverse=reverseList(list);
            //foreach (int item in reverse)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}

            //Digitize(0);

            Greet("Julia");
            

            Console.ReadLine();
        }
    }
}
