using davaleba6_2;

int x = 8;
int y = 6;

int jami = Calculator.Add(x, y);
Console.WriteLine("x + y tolia: " + jami);

int sxvaoba = Calculator.Subtract(x, y);
Console.WriteLine("x - y tolia: " + sxvaoba);

int namravli = Calculator.Multiply(x, y);
Console.WriteLine("x * y tolia: " + namravli);

decimal gayofa = Calculator.Divide(x, y);
Console.WriteLine("x / y tolia: " + gayofa);