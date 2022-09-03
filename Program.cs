
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>999 || a<100)
{
Console.WriteLine("Введённое вами число не трёхзначное");
}
else
{
    int a1 =((a / 10) % 10);
Console.WriteLine("Вторая цифра введённого числа: " + a1);
}
