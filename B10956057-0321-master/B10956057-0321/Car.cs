using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10956057_0321
{
    class Car
    {
        string color = "blue";
        int cc = 1500;
        string board = "bmw";

        public void showInfo()
        {
            Console.WriteLine("color:" + color);
            Console.WriteLine("cc:" + cc);
            Console.WriteLine("board:" +board);
        }
    }
}