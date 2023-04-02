/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является 
ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите день недели ");
int NumberDayOfWeek = int.Parse(Console.ReadLine());
if ((NumberDayOfWeek < 8) && (NumberDayOfWeek > 0))
{
    switch (NumberDayOfWeek)
    {
        case 1: Console.WriteLine("Понедельник, не является выходным днем"); break;
        case 2: Console.WriteLine("Вторник, не является выходным днем"); break;
        case 3: Console.WriteLine("Среда, не является выходным днем"); break;
        case 4: Console.WriteLine("Четверг, не является выходным днем"); break;
        case 5: Console.WriteLine("Пятница, не является выходным днем"); break;
        case 6: Console.WriteLine("Суббота, является выходным днем"); break;
        case 7: Console.WriteLine("Воскресенье, является выходным днем"); break;
    }
}
else
{
    Console.WriteLine("Данное число не является днем недели");
}