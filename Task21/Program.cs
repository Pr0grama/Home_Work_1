Console.Write("Введите координату x 1 точки ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y 1 точки ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z 1 точки ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату x 2 точки ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату y 2 точки ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату z 2 точки ");
int z2 = int.Parse(Console.ReadLine());

Console.Write($"Расстояние между точка Х {Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2))}");