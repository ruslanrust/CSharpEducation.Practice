namespace Practice2.Task14
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int length = 5;
      int[] array = MakeArray(length);

      Random randomNum = new Random();

      for (int i = 0; i < array.Length; i++)
      {
        array[i] = randomNum.Next(1, 10);
        Console.Write(array[i] + " ");
      }
    }

    static int[] MakeArray(int length)
    {
      return new int[length];
    }
  }
}
