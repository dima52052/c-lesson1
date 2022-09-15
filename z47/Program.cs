int rows=3;
int columns=4;

double[,] GetArray(int m,int n)
{
    var array=new double[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {
            array[i,j]=new Random().NextDouble();
        }
    }

    return array;
}

void PrintArr(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}");
        }
        System.Console.WriteLine();
    }
}

PrintArr(GetArray(rows,columns));