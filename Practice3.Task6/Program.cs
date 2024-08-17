namespace Practice3.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Point a = new Point(0, 0);
      Point b = new Point(5, 5);

      Console.WriteLine(CalculateDistance(a, b));
    }

    static public double CalculateDistance(Point a, Point b)
    {
      double dX = (double)(b.x - a.x);
      double dY = (double)(b.y - a.y);

      return Math.Sqrt(dX * dX + dY * dY);
    }

  }

}
