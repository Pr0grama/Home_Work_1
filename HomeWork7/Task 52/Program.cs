void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] AddRandomInt(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = new Random().Next(0,9);
        }
    }
    return matrix;
}

void ArithmeticMean(int[,] matrix, double columns)
{
    double suma;
    double srznach;
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        suma = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            suma += matrix[i,j];
        }
        srznach = suma / columns;
        Console.WriteLine($"Ср. Значение {i} столбца = {srznach}");
    }
}

Console.Write("Введите кол-во столбцов в матрице: ");
int columns = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во строк в матрице: ");
int rows = Convert.ToInt16(Console.ReadLine());
int[,] matrix = AddRandomInt(rows, columns);
PrintMatrix(matrix);
ArithmeticMean(matrix,rows);