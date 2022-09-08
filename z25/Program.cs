  Console.Write("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Ответ: " + exp(A, B));

int exp(int A, int B){
  int result = 1;
  for(int i=1; i <= B; i++){
    result = result * A;
  }
    return result;
}