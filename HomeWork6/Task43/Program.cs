 Console.Write($"Введите значинье b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
 Console.Write($"Введите значинье k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

 Console.Write($"Введите значинье b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
 Console.Write($"Введите значинье k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

// y = k1x + b1 = k2x + b2
 double x = -(b1 - b2)/(k1-k2);
 Console.WriteLine(x);
 double y = k1*x + b1;
Console.WriteLine(y);
 Console.WriteLine($"({x},{y})");