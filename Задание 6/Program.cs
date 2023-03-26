Console.WriteLine("Введите число a: ");
string str1 = Console.ReadLine();
int a = Convert.ToInt32(str1);
if (a % 2 == 0) {
    Console.WriteLine("Четное");
}
else {
    Console.WriteLine("Нечетное");
}