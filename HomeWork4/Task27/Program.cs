int SummaNumber(int number)
{
    int summa = 0;
    for (; number != 0; number /= 10)
    {
        summa += number%10;
    }
    return summa;
}

void PrintNumber(int number)
{
    Console.WriteLine($"Сумма цифр в числе {number}");
}
Console.Write("Введиет число ");
int number = Convert.ToInt32(Console.ReadLine());
int CountNumber1 = SummaNumber(number);
PrintNumber(CountNumber1);