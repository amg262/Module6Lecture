using System;
using System.Collections.Generic;

namespace Module6Lecture
{
    class Program
    {
        public void ExampleOne()
        {
            int value = 5;
            string name = "Andrew";
            List<string> names = new List<string>();
            names.Add(name);
        }

        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.ExampleOne();
            
            Rectangle kitchen = new Rectangle(10, 10);
            kitchen.Length = 5;
            kitchen.Width = 4;
            Console.WriteLine($"{kitchen.Length * kitchen.Width}");

        }
    }
}