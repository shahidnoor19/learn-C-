namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person myObject = new Person();
            myObject.name = "shahidfffffff";
            Console.WriteLine(myObject.name);
        }
    }
}

 class Person{
    public string? name {get; set;}
}

