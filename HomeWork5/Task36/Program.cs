void RandomArray(int[] array, int number)
{
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
}

void PrintArray(int[] array, int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SummaOddPositions(int[] array, int number)
{
    int summa = 0;
    for (int i = 1; i < number; i = i + 2)
    {
        summa += array[i];
    }
    Console.WriteLine($"Сумма на нечетных позициях {summa}");
}

Console.Write("Введите какого размера одномерный массив ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
RandomArray(array, number);
PrintArray(array, number);
SummaOddPositions(array, number);
