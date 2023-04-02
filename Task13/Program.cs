/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> c
32679 -> 6*/
int DowngradingToAThreeDigitNumber(int number)
{
    while (number > 999) 
    {
        number /= 10;
    }
    return number;
}
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
number = DowngradingToAThreeDigitNumber(number);
if (number > 99)
{
    Console.WriteLine(number%10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}