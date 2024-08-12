namespace Practice2.Task20
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[,] test = new int[3, 3];

      Random randomNum = new Random();

      int max = int.MinValue;
      int min = int.MaxValue;

      for (int i = 0; i < test.GetLength(0); i++)
      {
        for (int j = 0; j < test.GetLength(1); j++)
        {
          test[i, j] = randomNum.Next(1, 100);

          if (test[i, j] > max)
          {
            max = test[i, j];
          }

          if (test[i, j] < min)
          {
            min = test[i, j];
          }
        }
      }

      Console.WriteLine(max - min);
    }
  }
}
