namespace Practice2.Task15
{
  internal class Program
  { 
    static void Main(string[] args)
    {
      int[] test = new int[] { 1, 2, 3 };

      ReverseArray(test);

      foreach (int i in test)
      {
        Console.Write(i + " ");
      }
    }

    static void ReverseArray(int[] array)
    {
      for (int i = 0; i < array.Length / 2; i++)
      {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
      }
    }
  }
}
