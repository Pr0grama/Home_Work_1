Console.Write("Введите числа (через пробел): ");
int[] arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>0) count++;
}
Console.WriteLine(count);