namespace Practice3.Task6
{
  public struct Point
  {
    public int x;
    public int y;

    public Point (int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    public static double CalculateDistance(Point a, Point b)
    {
      double dX = (double)(b.x - a.x);
      double dY = (double)(b.y - a.y);

      return Math.Sqrt(dX * dX + dY * dY);
    }

  }
}
