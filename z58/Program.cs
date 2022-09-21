int rows=2;
int columns=2;

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
var matrix1=GetArray(rows,columns);
var matrix2=GetArray(rows,columns);

static int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}




var div=DivMatrix(matrix1, matrix2);

System.Console.WriteLine("Матрица А ");
PrintArr(matrix1);
System.Console.WriteLine("Матрица Б ");
PrintArr(matrix2);


System.Console.WriteLine();
PrintArr(div);



