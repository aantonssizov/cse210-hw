using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [
            new Circle() {
                Color = "red",
                Radius = 5
            },
            new Rectangle() {
                Color = "green",
                Length = 2,
                Width = 3
            },
            new Square() {
                Color = "blue",
                Side = 4
            }
        ];

        shapes.ForEach(shape =>
        {
            Console.WriteLine($"{shape.Color} - {shape.GetArea()}");
        });
    }
}