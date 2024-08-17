namespace Practice3.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Calculator calculator = new Calculator();

      Console.WriteLine(calculator.Sum(1, 1));
      Console.WriteLine(calculator.Substraction(4, 2));
      Console.WriteLine(calculator.Division(6, 3));
      Console.WriteLine(calculator.Multiplication(1, 2));

    }
  }
}
