namespace Practice2.Task8
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int num1 = int.Parse(Console.ReadLine());
      int num2 = int.Parse(Console.ReadLine());
      int num3 = int.Parse(Console.ReadLine());

      if (num1 == num2 || num1 == num3 || num2 == num3)
      {
        num1 += 5;
        num2 += 5;
        num3 += 5;
      }
      else
      {
        Console.WriteLine("Равных нет");
      }
    }
  }
}
