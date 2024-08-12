namespace Practice2.Task9
{
  internal class Program
  {
    static void Main(string[] args)
    {
      static int[] CreateArray (int length)
      {
        int[] result = new int[length];

        for (int i = 0; i < length; i++)
        {
          result[i] = i;
        }

        return result;
      }

      static void PrintArray(int[] array)
      {
        foreach (int i in array)
        {
          Console.Write(i + " "); 
        }
      }

      PrintArray(CreateArray(5));
    }
  }
}
