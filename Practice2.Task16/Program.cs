namespace Practice2.Task16
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int test = 3;

      ChangeToOpposite(ref test);

      Console.WriteLine(test);
    }

    static void ChangeToOpposite(ref int num)
    {
      num = num * (-1);
    }
  }
}
