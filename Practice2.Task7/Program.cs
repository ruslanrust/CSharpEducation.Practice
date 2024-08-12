using System.Globalization;

namespace Practice2.Task7
{
  internal class Program
  {
    static void Main(string[] args)
    {
      {
        string str = "testForUP";
        Console.WriteLine(str.ToUpper());
      }

      {
        string str = "TESTfordown";
        Console.WriteLine(str.ToLower());
      }

      {
        string str = "привет";
        Console.WriteLine(Char.ToUpper(str[0]) + str.Substring(1));
      }
    }
  }
}
