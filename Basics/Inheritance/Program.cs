/* Inheritance allows a class to inherit fields and methods from another class, promoting code reuse.*/
using System;

//class Mobile
//{
//    public string Name { get; set; }

//    public void Display()
//    {
//        Console.WriteLine($"Mobile phones, and my name is {Name}.");
//    }
//}

//class Samsung : Mobile  // Samsung inherits from Mobile
//{
//    public void click()
//    {
//        Console.WriteLine("image captured successfully!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Samsung phone = new Samsung();
//        phone.Name = "Samsung";
//        phone.Display();
//        phone.click();
//    }
//}

//; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;
class Vehicle
{
    public int Speed { get; set; }
    public string Color { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }
}

class Car : Vehicle
{
    public void Honk()
    {
        Console.WriteLine("Car honking: Beep Beep!");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.Speed = 100;
        car.Color = "blue";
        car.Start();
        car.Honk();
        Console.WriteLine($"Car speed: {car.Speed}, color: {car.Color}");
    }
}

