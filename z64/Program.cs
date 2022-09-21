Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumber(m, n);


void NaturalNumber(int n, int m)
{
    if (m > n)
    {
        return;
    }
    else
    {
        NaturalNumber(n, m + 1);
        Console.Write(m + " ");
    }
}