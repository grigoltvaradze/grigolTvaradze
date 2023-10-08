// დავალების პირველი ნაწილი
Console.WriteLine("sheiyvanet masivis zoma :");
while (true)
{
    if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
    {
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"sheiyvanet masivis elementi {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int element) && element >= 0)
            {
                array[i] = element;
            }
            else
            {
                Console.WriteLine("sheiyvanet ricxvebi");
                i--;
            }
        }
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (array[i] > array[j])
                {
                    int current = array[i];
                    array[i] = array[j];
                    array[j] = current;
                }
            }
        }
        Console.WriteLine("migebuli masivi:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
           
        }
        break;
    }
    else
    {
        Console.WriteLine("sheiyvanet mxolod cifrebi");
    }
}

// დავალების მეორე ნაწილი
Console.WriteLine("davalebis meore nawili");
Console.WriteLine("sheiyvanet masivis zoma: ");
if (int.TryParse(Console.ReadLine(), out int W) && W > 0)
{
    string[] firstArray = new string[W];
    for (int i = 0; i < W; i++)
    {
        Console.WriteLine($"sheiyvanet {i + 1} sityva");
        firstArray[i] = Console.ReadLine();
    }

    Console.WriteLine("sheiyvanet meore masivis zoma:");
    if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
    {
        int[] secondArray = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"sheiyvanet {i + 1} ricxvi: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                secondArray[i] = value;
            }
            else
            {
                Console.WriteLine("sheiyvanet mxolod ricxvebi");
                i--;
            }
        }

        string[] combinedArray = new string[W + N];
        int firstIndex = 0;
        int secondIndex = 0;

        for (int i = 0; i < W + N; i++)
        {
            if (i % 2 == 0 && firstIndex < W)
            {
                combinedArray[i] = firstArray[firstIndex];
                firstIndex++;
            }
            else if (secondIndex < N)
            {
                combinedArray[i] = secondArray[secondIndex].ToString();
                secondIndex++;
            }
        }

        Console.WriteLine("gaertianebuli masivi:");
        for (int i = 0; i < combinedArray.Length; i++)
        {
            Console.WriteLine($"{combinedArray[i]}");
        }
    }
    else
    {
        Console.WriteLine("meore masivis zoma sheiyvanet cifrebit");
    }
}
else
{
    Console.WriteLine("sheiyvanet masivis zoma cifrebit");
}
