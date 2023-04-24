Console.Write("Введите кол-во строк в матрице: ");
int lines = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов в матрице: ");
int columns = Convert.ToInt16(Console.ReadLine());
int[,] matrix = FillArrayRandom(lines,columns);
PrintArray(matrix);
SummaLines(matrix);

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArrayRandom(int lines, int columns)
{
    int[,] matrix = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void SummaLines(int[,] matrix)
{
    int minSuma = 100;
    int imin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int suma = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            suma += matrix[i,j];
        }
        if (suma < minSuma)
        {
            minSuma = suma;
            imin = i;
        }
    }
    Console.WriteLine($"Минимальная сумма в строке {imin} и она равна {minSuma}");
}