Random random  = new Random();
int generatedNumber = random.Next(1, 10);
int attempt  = 3;


Console.WriteLine("Tamashis wesi:\n sheiyvanet 1-10 mde cifri\n Tu sheyvanili cifri daemtxveva kompiuteris mier dagenerirebul cifrs moigebt\n gaqvt mxolod 3 cda");

while (attempt > 0)
{
    Console.WriteLine("sheiyvanet cifri : ");
    if (int.TryParse(Console.ReadLine(), out int userNumber))
    {
        if (userNumber < 1 || userNumber > 10)
        {
            Console.WriteLine(" sheiyvanet cifri 1-10 mde");
            continue;
        }
        attempt--;
        if(userNumber == generatedNumber)
        {
            Console.WriteLine("tqven moiget");
            break;
        }
        else
        {
            Console.WriteLine($"ver gamoicanit dagrchat {attempt} cda");
        }
    }
    else
    {
        Console.WriteLine("sheiyvanet mxolod cifri");
    }
    if(attempt == 0)
    {
        Console.WriteLine("Game Over");
    }
}
