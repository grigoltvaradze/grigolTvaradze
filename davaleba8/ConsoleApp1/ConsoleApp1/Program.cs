using ConsoleApp1;

Console.WriteLine("Enter the lengths of the first triangle's sides:");
double side1 = Convert.ToDouble(Console.ReadLine());
double side2 = Convert.ToDouble(Console.ReadLine());
double side3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the lengths of the second triangle's sides:");
double sideA = Convert.ToDouble(Console.ReadLine());
double sideB = Convert.ToDouble(Console.ReadLine());
double sideC = Convert.ToDouble(Console.ReadLine());

try
{
    Triangle triangle1 = new Triangle(side1, side2, side3);
    Triangle triangle2 = new Triangle(sideA, sideB, sideC);

    Console.WriteLine($"Area of the first triangle: {triangle1.GetArea()}");
    Console.WriteLine($"Area of the second triangle: {triangle2.GetArea()}");

    Triangle sumTriangle = triangle1 + triangle2;
    Console.WriteLine("Sum of two triangles:");

    Console.WriteLine($"Area: {sumTriangle.GetArea()}");
    Console.WriteLine($"Side1: {sumTriangle.Side1}");
    Console.WriteLine($"Side2: {sumTriangle.Side2}");
    Console.WriteLine($"Side3: {sumTriangle.Side3}");


    if (IsRightTriangle(sumTriangle))
    {
        Console.WriteLine("The sum triangle is a right triangle.");
    }
    else
    {
        Console.WriteLine("The sum triangle is not a right triangle.");
    }
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}


static bool IsRightTriangle(Triangle triangle)
{
    double[] sides = { triangle.Side1, triangle.Side2, triangle.Side3 };
    Array.Sort(sides);
    return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < double.Epsilon;
}

