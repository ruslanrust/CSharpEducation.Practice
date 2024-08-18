namespace Practice3.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Point a = new Point(0, 0);
      Point b = new Point(5, 5);

      Console.WriteLine(Point.CalculateDistance(a, b));
    }
  }

}
