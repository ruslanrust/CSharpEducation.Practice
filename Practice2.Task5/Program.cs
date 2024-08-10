namespace Practice2.Task5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите первое число для сравнения");
      int num1 = int.Parse(Console.ReadLine());
   
      Console.WriteLine("Введите второе число для сравнения");
      int num2 = int.Parse(Console.ReadLine());


      if (num1 > num2)
      {
        Console.WriteLine("Первое число больше второго");
      }
      else if (num1 < num2)
      {
        Console.WriteLine("Первое число меньше второго");
      }
      else
      {
        Console.WriteLine("Числа равны");
      }
    }
  }
}
