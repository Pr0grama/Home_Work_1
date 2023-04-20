Console.Write("Введите кол-во столбцов в матрице: ");
int columns = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во строк в матрице: ");
int rows = Convert.ToInt16(Console.ReadLine());
double[,] matrix = AddRandomDouble(rows,columns);
PrintMatrix(matrix);

void PrintMatrix(double[,] matrix)
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

double[,] AddRandomDouble(int rows, int columns)
{
    double[,] matrix = new double[rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = new Random().Next(10,100) + new Random().NextDouble();
        }
    }
    return matrix;
}
