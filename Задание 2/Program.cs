Console.WriteLine("Введите число a: ");
string str1 = Console.ReadLine();
int a = Convert.ToInt32(str1);
Console.WriteLine("Введите число b: ");
string str2 = Console.ReadLine();
int b = Convert.ToInt32(str2);
if (a > b) {
    Console.Write("Наибольшее число ");
    Console.WriteLine(a);
}
else {
    Console.Write("Наибольшее число ");
    Console.WriteLine(b);
}