using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGitLocations
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public void PrintPersonDeets()
        {
            Console.WriteLine("This person's name is {0} and their age is {1}", Name, Age);
        }
          
          
    }
}
