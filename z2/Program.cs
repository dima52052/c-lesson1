Console.WriteLine("Введите два числа:");
int a, b;
Console.WriteLine("Введите число a:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
b = Convert.ToInt32(Console.ReadLine());
if (a>b)   {
    Console.WriteLine($"Число {a} больше чем {b}"); 
     }
    else
    Console.WriteLine($"Число {b} больше чем {a}");