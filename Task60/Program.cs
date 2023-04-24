Console.Write("Введите x: ");
int x = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите z: ");
int z = Convert.ToInt16(Console.ReadLine());

int[,,] matrix = new int[x,y,z];
AddArray(matrix);
PrintArray(matrix);

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"{matrix[i,j,k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

void AddArray(int[,,] matrix)
{
    int[] number = new int[matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(10,100);
                number[count] = matrix[i,j,k];
                for (int l = 0; l < count; l++)
                {
                    if (matrix[i,j,k] == number[count])
                    {
                        matrix[i,j,k] = new Random().Next(10,100);
                        number[count] = matrix[i,j,k];
                    }
                }
                count++;
            }
        }
    }
}