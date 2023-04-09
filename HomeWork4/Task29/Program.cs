void AddArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} число массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("]");
}
int[] array = new int[8];
AddArray(array);
PrintArray(array);