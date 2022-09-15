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

bool SearchElement(int[,] array, int elements)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            if(array[i,j]==elements) 
            {
                    return true;
            }
            
        }
        
    }
    return false;
}


var arr=GetArray(rows,columns);
foreach (var item in arr)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine(SearchElement(arr,9));