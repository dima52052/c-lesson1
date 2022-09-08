  Console.Write("Введите число: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Сумма всех чисел числа:" + sum(A));

int sum(int A){
    
    int length = Convert.ToString(A).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < length; i++){
      advance = A - A % 10;
      result = result + (A - advance);
      A = A / 10;
    }
   return result;
  }