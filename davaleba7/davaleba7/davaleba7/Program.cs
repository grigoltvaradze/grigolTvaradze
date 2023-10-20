using davaleba7;

Console.WriteLine("Choose a shape:");
Console.WriteLine("1 - Triangle");
Console.WriteLine("2 - Rectangle");
Console.WriteLine("3 - Circle");

int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.Write("Enter side a: ");
    double sideA = double.Parse(Console.ReadLine());
    Console.Write("Enter side b: ");
    double sideB = double.Parse(Console.ReadLine());
    Console.Write("Enter side c: ");
    double sideC = double.Parse(Console.ReadLine());

    Shape shape = new Triangle(sideA, sideB, sideC);
    Console.WriteLine($"Area: {shape.GetArea()}");
    Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
}
else if (choice == 2)
{
    Console.Write("Enter length: ");
    double length = double.Parse(Console.ReadLine());
    Console.Write("Enter width: ");
    double width = double.Parse(Console.ReadLine());

    Shape shape = new Rectangle(length, width);
    Console.WriteLine($"Area: {shape.GetArea()}");
    Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
}
else if (choice == 3)
{
    Console.Write("Enter radius: ");
    double radius = double.Parse(Console.ReadLine());

    Shape shape = new Circle(radius);
    Console.WriteLine($"Area: {shape.GetArea()}");
    Console.WriteLine($"Circumference: {shape.GetPerimeter()}");
}
else
{
    Console.WriteLine("Invalid choice.");
}
    