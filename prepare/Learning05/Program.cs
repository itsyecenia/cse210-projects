using System;

class Program
{
    static void Main(string[] args)
    {
        List<shape> shapes = new List<shape>();

        shapes.Add(new square("blue", 5));
        shapes.Add(new rectangle("orange", 7.5, 4));
        shapes.Add(new circle("yellow", 8));

        foreach(shape shape in shapes){
            
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine("The shape whose color is " + color + " has an area of " + area);
        }
    }
}