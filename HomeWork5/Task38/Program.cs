void RandomArray(double[] array, int number)
{
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(double[] array, int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void MaxAndMin(double[] array, int number)
{
    double max = array[0];
    double min = max;
    for (int i = 0; i < number; i++)
    {
        if (max < array[i])  max = array[i];
        if (min > array[i]) min = array[i];
    }
    Console.WriteLine($"Минимальный член {min}, максимальный член {max}. Их разность {max - min}");
}

Console.Write("Введите какого размера одномерный массив ");
int number = Convert.ToInt32(Console.ReadLine());
double[] array = new double[number];
RandomArray(array, number);
PrintArray(array, number);
MaxAndMin(array, number);
