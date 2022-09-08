double[] GetArray(int size,int min,int max)
{
    double[] array=new double[size];
    Random rand=new Random();
    for (int i=0; i<array.Length;i++)
    {
        array[i]=rand.Next(min,max+1)/10.0;
    }

    return array;
}

double ResultArr(double[] array)
{
    double result=0;
    double min=array[0];
    double max=array[0];
    for (int i=0; i<array.Length;i++)
    {
        if(array[i]>max)
        {
            max=array[i];
        }
        if(array[i]<min)
        {
            min=array[i];
        }
    }
    result=max-min;
    return result;
}


double[] arr=GetArray(4,1,100);

Console.WriteLine(string.Join(", ",arr));
Console.WriteLine($"Разница между max и min: "+ ResultArr(arr));