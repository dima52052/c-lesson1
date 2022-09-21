int rows=4;
int columns=4;

//Создание массива
int[,] GetArray(int m,int n)
{
    var array=new int[m,n];
    for (int i=0; i<m;i++)
    {
        for (int j=0; j<n;j++)
        {
            array[i,j]=new Random().Next(5);
        }
    }

    return array;
}

//Вывод массива
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

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

var x=GetArray(rows,columns);



PrintArr(x);
System.Console.WriteLine();


NumberRowMinSumElements(x);
