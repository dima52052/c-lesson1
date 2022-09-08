int[] GetArray(int size,int min,int max)
{
    int[] array=new int[size];
    Random rand=new Random();
    for (int i=0; i<array.Length;i++)
    {
        array[i]=rand.Next(min,max+1);
    }

    return array;
}

int GetElement(int[] array)
{
    int sum=0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]%2 ==0)
        {
            sum++;
        }
        
    }
    return sum;
}

int[] arr=GetArray(10,100,999);

Console.WriteLine(string.Join(", ",arr));
Console.WriteLine($"Количество четных: "+ GetElement(arr));
