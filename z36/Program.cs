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
    int sumi=0;
    for(int i=1 ;i<array.Length;i=i+2)
    {
        
            sumi=sumi+array[i];
        
        
    }
    return sumi;
}

int[] arr=GetArray(4,-10,10);

Console.WriteLine(string.Join(", ",arr));
Console.WriteLine($"Сумма элементов на нечетных позициях:"+ GetElement(arr));
