Console.Write("Введите пятизначное число ");
string Text = Console.ReadLine();
int count = 0;
for (int i = 0; i < 2; i++)
{
    if (Text[i] == Text[4 - i]) count++;
}
if (count == 2) Console.WriteLine("Число является полиндромом");
else Console.WriteLine("Число не является полиндромом");