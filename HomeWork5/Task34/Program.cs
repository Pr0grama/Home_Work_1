void RandomArray(int[] array, int number)
{
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(100,1000);
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

void ChetNumber(int[] array, int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($"Кол-во четных числе {count}");
}

Console.Write("Введите какого размера одномерный массив ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
RandomArray(array, number);
PrintArray(array, number);
ChetNumber(array, number);
