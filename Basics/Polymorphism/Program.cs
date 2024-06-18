
/* Polymorphism can be achieved by two methods:
 * 1. Method Overriding 
 * 2. Interfaces */

// Method overrriding


using System;

//class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("Animal speaks.");
//    }
//}

//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Dog barks.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal myDog = new Dog();
//        myDog.Speak();  // Output: Dog barks.
//    }
//}



// using interfaces


interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
}

class Program
{
    static void Main()
    {
        IShape circle = new Circle();
        IShape rectangle = new Rectangle();

        circle.Draw();        // Output: Drawing a Circle.
        rectangle.Draw();     // Output: Drawing a Rectangle.
    }
}

