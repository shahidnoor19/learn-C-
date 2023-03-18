namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ALL Objects
            Person myObject = new Person();
            Car carObject = new Car();
            Animals myAnimalObject = new Animals();
            Animals myCatObject = new Cat();
            Animals myDogObject = new Dog();
            MyHome myHome = new MyHome();
            MyImplementInterface myImplement = new MyImplementInterface();

            Console.WriteLine("From Encapsulation");
            myObject.name = "shahidfffffff\n\n";
            Console.WriteLine(myObject.name);

            Console.WriteLine("\nFor Inheritance");
            Console.WriteLine("This is The method I call Here");
            carObject.myMethod();
            Console.WriteLine("This From Parent Class\n"+ carObject.brand
                + "\nThis From Child Class\n"
                + carObject.carName);

            Console.WriteLine("\n\n For Poly morphism");
            myAnimalObject.sound();
            myCatObject.sound();
            myDogObject.sound();

            Console.WriteLine("\n\nFor Abstraction");
            myHome.Room();
            myHome.TVLunch();


            Console.WriteLine("\n\nInterfaces");
            myImplement.myMethod();
            
        }
    }
}


//For Encapsulation
 class Person{
    public string? name {get; set;}
}

// For Inheritance

// Parent Class

// If you don't want to this class inhereted Then use Sealed Class Like (sealed Class Vehicles)
 class Vehicles{
    public string brand = "Suzuki";  // Vehicle field
    public void myMethod() => Console.WriteLine("Hi Im yOuR Boss Respect! AHhahhaha");// Vehicle method 
}


// Child Class Of Vehicel Class
class Car : Vehicles {
    public string carName = "My Audi";

}


// For Polymorphism
class Animals{
    public virtual void sound() => Console.WriteLine("Animals Sound");
}

class Cat : Animals {
    public override void sound() => Console.WriteLine("Cat Meow Meow");
}

class Dog : Animals{
    public override void sound() => Console.WriteLine("Dog Haow Haow");
}


// For Abstraction
abstract class Houses{
    public abstract void Room();
    public void TVLunch(){
        Console.WriteLine("My Home TV Luch");
    }
}

class MyHome : Houses
{
    public override void Room()
    {
        Console.WriteLine("Abstract Method Of ROOM is loaded");
    }
}


// For Interfaces

interface IMyInterface{
    abstract void myMethod();
}

class MyImplementInterface : IMyInterface
{
    public void myMethod()
    {
        Console.WriteLine("This is called Interface");
    }
}