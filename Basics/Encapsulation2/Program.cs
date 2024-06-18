using System;

class Animal
{
    public string Name { get; set; }
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine($"{Name} is flying.");
    }
}

class Program
{
    static void Main()
    {
        Bird bird = new Bird();
        bird.Name = "peacock";
        bird.Eat();
        bird.Fly();
    }
}
