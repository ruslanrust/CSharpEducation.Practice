namespace Practice2.Task10
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int length = int.Parse(args[0]);
      int[] result = new int[length];

      for (int i = 0; i < length; i++)
      {
        result[i] = i;
      }
        
      foreach (int i in result)
      {
        Console.Write(i + " ");
      }
    }
  }
}
