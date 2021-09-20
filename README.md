#Module 6 Lecture #


The code below is correctly showing the Getters, Setters for
the variables - The variables used in Gets, Sets should have
underscore like 
```c# 
private double _length;
private double _width;
```

### 

### 2 constructors for seperate business logic
```c#
public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    /*
     * Overloaded constructor that can be created and default values
     */
    public Rectangle()
    {
        length = 1;
        width = 1;
    }
```

# This is how the classes should look for getters and setters #
```c#
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
    /*
     * propertites
     */
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

    /*
    * Using string interpolation is best practice rather than
    * calling WriteLine from class method
    */
    public string Print()
    {
        return $"{_petName} is {_age} years";
    }
}
```


```c#
public class Rectangle
{
    private double _area;
    private double _length;
    private double _width;
    private double length;
    private double width;

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

    public void SetArea()
    {
        _area = length * width;
    }

    public double GetArea()
    {
        return _area;
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
```


```c#
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
```

```c#
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
        kitchen.SetArea();
        kitchen.GetArea();
        /*
         * Area field will create stale data because its just a calculation based entirely
         * only on other fields. Issues with incorrect area values when setter getter for that
         *
         * Always calculate on fly with existing fields, have GetArea() method for that calc.
         */
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
```
