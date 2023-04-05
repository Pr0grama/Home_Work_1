void Degree3(int number)
{
    Console.Write($"Степени числа до номера {number}: ");
    for (int i = 1; i < number; i++) Console.Write($" {Math.Pow(i,3)},");
    Console.Write($" {Math.Pow(number,3)}.");
}
Console.Write("До какого числа искать кубы чисел ");
Console.Write("");
Degree3(int.Parse(Console.ReadLine()));