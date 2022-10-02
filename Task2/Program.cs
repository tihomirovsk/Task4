Console.Clear();

int number = ReadInt("Введите число: ");
int am = Number1(number);
SummaNumbers(number, am);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Number1(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SummaNumbers(int n, int am)
{
    int sum = 0;
    for (int i = 1; i <= am; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}