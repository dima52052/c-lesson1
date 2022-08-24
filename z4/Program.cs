Console.WriteLine("Введите три числа:");
int a, b, c;
Console.WriteLine("Введите число a:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число с:");
c = Convert.ToInt32(Console.ReadLine());

int max=a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

Console.WriteLine($"Max = {max}");