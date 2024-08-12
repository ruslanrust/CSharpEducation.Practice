namespace Practice2.Task17
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int num1 = 5;
      int num2 = 3;
      Console.WriteLine(num1 - num2);

      ChangeVariables(ref num1, ref num2);

      Console.WriteLine(num1 - num2);
    }

    static void ChangeVariables(ref int num1, ref int num2)
    {
      (num1, num2) = (num2, num1);
    }
  }
}
