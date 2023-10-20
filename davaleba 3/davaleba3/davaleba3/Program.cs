
int[] numbers = {645 , 14314, 8741 };

int index = 1;

int result = CalculateDigitSum(numbers, index);


Console.WriteLine("elementis cifrebis jamia: " + result);


static int CalculateDigitSum(int[] array, int index)
{
    int element = array[index];
    int sum = 0;

    while (element > 0)
    {
        int digit = element % 10;
        sum += digit;
        element /= 10;
    }

    return sum;
}