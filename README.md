#Module 6 Lecture #


The code below is correctly showing the Getters, Setters for
the variables - The variables used in Gets, Sets should have
underscore like 
```c# 
private double _length;
private double _width;
```




```c#
namespace Module6Lecture
{
    public class Rectangle
    {
        private double length;
        private double width;
        private double _length;
        private double _width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        /*
         * Properties
         */
        public double Length
        {
            get => length;
            set => length = value;
        }

        /*
         * Properties
         */
        public double Width
        {
            get => width;
            set => width = value;
        }

        public void SetLength(double len)
        {
            _length = len;
        }

        public void SetWidth(double wid)
        {
           _width = wid;
        }

        public double GetWidth()
        {
            return _width;
        }

        public double GetLength()
        {
            return _length;
        }
    }
}
```


```c#
namespace Module6Lecture
{
    public class Pet
    {
        private int age;
        private string petName;
        private int _age;
        private string _petName;
        public Pet(string petName, int age)
        {
            this.petName = petName;
            this.age = age;
        }


        public string PetName
        {
            get => petName;
            set => petName = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }


        /*
         * These getters amd setters need to use the " _variabel_name " fields
         * with the underscore. Properties will hide the private variables all together
         * this class correctly represents the getters, setters but NOT properties
         */
        public void SetPetName(string petName)
        {
            _petName = petName;
        }

        public string GetPetName()
        {
            return this.petName;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            _age = age;
        }
    }
}
```

```c#
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

            Console.WriteLine($"{kitchen.GetWidth()} Len: {kitchen.GetLength()}");

            Pet pet = new Pet("Odie", 10);
            pet.PetName = "Rodie Puppy";
            pet.Age = 5;
            pet.SetAge(6);
            pet.SetPetName("bowzah");

            //Console.WriteLine($"Name: {pet.PetName}  Age: {pet.Age}");
            Console.WriteLine($"Name: {pet.GetPetName()}  Age: {pet.GetPetName()}");

        }
    }
}
```
