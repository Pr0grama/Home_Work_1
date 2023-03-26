Console.WriteLine("Введите число a: ");
string str1 = Console.ReadLine();
int a = Convert.ToInt32(str1);
Console.Write("Четные числа: ");
for (int n = 2; n <= a; n=n+2) {
    Console.Write(n);
    Console.Write(" ");
}