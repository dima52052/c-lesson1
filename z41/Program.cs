int ex41()
{
Console.Write("Введите числа через Enter, для окончания ввода введите stop: ");
int sum=0;
for (int i=0; ; i++)
{
    string n= Console.ReadLine();
    if (n == "stop") break;
    else
        {
            int m=Convert.ToInt32(n);
            if (m>0) sum++;
        }
}
Console.Write(sum);
return sum;
}


ex41();

