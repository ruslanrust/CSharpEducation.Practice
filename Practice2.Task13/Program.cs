namespace Practice2.Task13
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[,] test = MakeTwoDimArray(4, 5);
      PrintTwoDimArray(test);
    }

    static int[,] MakeTwoDimArray(int rows, int columns) 
    {
      int[,] result = new int[rows, columns];
      Random randomNum = new Random();

      for (int i = 0; i < rows; i++)
      {
        for (int j = 0; j < columns; j++)
        {
          result[i, j] = randomNum.Next(1, 10);
        }
      }

      return result;
    }

    static void PrintTwoDimArray(int[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
      }
    }
  }
}
