int rows=3;
int columns=4;

int[,] GetArray(int m,int n)
{
    var array=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {
            array[i,j]=new Random().Next(10);
        }
    }

    return array;
}

void PrintArr(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}


double[] SumColumn(int[,] array)
{
    var result=new double[array.GetLength(1)];
    for (int i=0; i<array.GetLength(1);i++)
    {
        double sum=0;
        for (int j=0; j<array.GetLength(0);j++)
        {
            sum += array[j,i];
            
        }

        result[i]=sum/array.GetLength(0);        
    }

    return result;
}


foreach (var item in SumColumn(GetArray(rows,columns)))
{
    System.Console.WriteLine(item);
}
