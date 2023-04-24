Console.Write("Введите кол-во строк в кв.матрице: ");
int lines = Convert.ToInt16(Console.ReadLine());
int[,] matrix = FillArrayRandom(lines);
PrintArray(matrix);


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

int[,] FillArrayRandom(int lines)
{
    int[,] matrix = new int[lines, lines];
    int num = 0;
    int i = 0;
    int j = 0;
    while (num < lines*lines)
    {
        matrix[i,j] = num;
        num++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matrix;
}