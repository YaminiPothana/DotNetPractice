using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Square.");
    }
}

class Program
{
    static void Main()
    {
        Shape shape1 = new Circle();
        Shape shape2 = new Square();

        shape1.Draw();  // Output: Drawing a Circle.
        shape2.Draw();  // Output: Drawing a Square.
    }
}


