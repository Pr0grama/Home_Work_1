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

void SearchNumber(int number, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == number) 
            {
                Console.WriteLine($"Номера индекса {i + 1}, {j + 1}"); 
                return;
            }
        }
    }
    Console.WriteLine("Такого числа нету");
}

Console.Write("Введите кол-во столбцов в матрице: ");
int columns = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите кол-во строк в матрице: ");
int rows = Convert.ToInt16(Console.ReadLine());
int[,] matrix = AddRandomInt(rows,columns);
do
{
    Console.Write("Введите искомое число от 0 до 9: ");
    int number = Convert.ToInt16(Console.ReadLine());
    if ((number >= 0) && (number < 10))
    {
        PrintMatrix(matrix);
        SearchNumber(number, matrix);
        break;
    }
    else { Console.WriteLine("Число не соответсвует диапозону");}
} while (true);

