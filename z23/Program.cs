Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

double[] Cube(int n){
    double[] arr=new double[n];

    for (int i = 1; i <= n; i++)            
    {
        Console.WriteLine(Math.Pow(i, 3)); 
    }

    return arr;
}

Cube(n);