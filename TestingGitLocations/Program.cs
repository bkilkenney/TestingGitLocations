using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGitLocations
{
    public class Program
    {
        static void Main(string[] args)
        {

            Person me = new Person();
            me.Age = 34;
            me.Name = "Brad";

            me.PrintPersonDeets();

            Print(3829);

            DoubleTheInt(232);

        }
        static void Print(int x)
        {
            Console.WriteLine(x);
        }

        static void DoubleTheInt(int y)
        {
            Console.WriteLine(y * 2);
        }
    }
}
