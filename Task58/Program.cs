Console.Write("Введите кол-во строк в 1 матрице: ");
int lines1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов в 1 матрице: ");
int columns1 = Convert.ToInt16(Console.ReadLine());
int[,] matrix1 = FillArrayRandom(lines1,columns1);

Console.Write("Введите кол-во строк во 2 матрице: ");
int lines2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во столбцов во 2 матрице: ");
int columns2 = Convert.ToInt16(Console.ReadLine());
int[,] matrix2 = FillArrayRandom(lines2,columns2);

int[,] resultmatrix = new int[columns1, lines2];

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
MatrixMultiplication(matrix1,matrix2,resultmatrix);
Console.WriteLine();
PrintArray(resultmatrix);


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

void MatrixMultiplication(int[,] matrix1, int[,] matrix2, int[,] resultmatrix)
{
    if (matrix1.GetLength(0) == matrix2.GetLength(1))
    {
        for (int i = 0; i < resultmatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultmatrix.GetLength(1); j++)
            {
                int suma = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    suma += matrix1[i,k] * matrix2[k,j];
                }
                resultmatrix[i,j] = suma;
            }
        }
    }
    else
    {
        Console.WriteLine("Нельзя перемножить");
    }
}