namespace Practice2.Task12
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int length = 3;
      string[] result = new string[length];

      for (int i = 0; i < length; i++)
      {
        result[i] = Console.ReadLine();
      }

      foreach (string s in result)
      {
        Console.Write(s + " ");
      }
    }
  }
}
