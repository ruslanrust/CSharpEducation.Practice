namespace Practice2.Task19
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] test = new int[10];
      Random randomNum = new Random();

      for (int i = 0; i < test.Length; i++)
      {
        test[i] = randomNum.Next(1, 100);
      }

      Console.WriteLine(test.Max() - test.Min());      
    }
  }
}
