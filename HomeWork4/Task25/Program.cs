Console.Write("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень в которую хотите возвести ");
int numberB = Convert.ToInt32(Console.ReadLine());
int FirstNumberA = numberA;
for (int count = 2; count <= numberB; count++)
{
    numberA = numberA * FirstNumberA;
}
Console.WriteLine($"Итоговое число {numberA}");