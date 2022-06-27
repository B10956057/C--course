using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10956057_0314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                if (2<=a&&a<=5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (6 <= a && a <= 20)
                {
                    Console.WriteLine("Weird");
                }
                else if (a > 20)
                {
                    Console.WriteLine("Not Weird");
                }
                else
                {
                    Console.WriteLine("Weird");
                }
                    
            }
            
        }
    }
}
