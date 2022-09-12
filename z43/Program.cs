Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] Point(double b1,double k1,double b2,double k2) 
{
    double[] result=new double[2];
    result[0]=(b2-b1)/(k1-k2);
    result[1]=k1*result[0]+b1;

    return result;
}
Console.WriteLine(string.Join(" ",Point(b1,k1,b2,k2)));