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
            //Console.WriteLine($"{kitchen.Length * kitchen.Width}");
            kitchen.GetArea();
            /*
             * Area field will create stale data because its just a calculation based entirely
             * only on other fields. Issues with incorrect area values when setter getter for that
             *
             * Always calculate on fly with existing fields, have GetArea() method for that calc.
             */
            Console.WriteLine($"{kitchen.GetWidth()} Len: {kitchen.GetLength()}");

            Console.WriteLine($"Shoe -  {kitchen.PrintRectangle()}");
            


            Rectangle bedroom = new Rectangle();
            Console.WriteLine($"Len:  {bedroom.GetLength()} *  {bedroom.GetWidth()} = {bedroom.GetArea()}");
            
            Pet pet = new Pet("Odie", 10);
            pet.PetName = "Rodie Puppy";
            pet.Age = 5;
            pet.SetAge(6);
            pet.SetPetName("bowzah");
            //Console.WriteLine($"Name: {pet.PetName}  Age: {pet.Age}");
            Console.WriteLine($"Name: {pet.GetPetName()}  Age: {pet.GetPetName()}");

            Console.WriteLine($" Print -  {pet.Print()}");
        }
    }
}