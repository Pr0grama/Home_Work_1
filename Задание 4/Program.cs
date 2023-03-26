Console.WriteLine("Введите число a: ");
string str1 = Console.ReadLine();
int a = Convert.ToInt32(str1);
Console.WriteLine("Введите число b: ");
string str2 = Console.ReadLine();
int b = Convert.ToInt32(str2);
Console.WriteLine("Введите число c: ");
string str3 = Console.ReadLine();
int c = Convert.ToInt32(str3);
int max = a;
if ( b > max) {
    max = b;
}
if (c > max) {
    max = c;
}
Console.WriteLine("Наибольшее число: ");
Console.Write(max);