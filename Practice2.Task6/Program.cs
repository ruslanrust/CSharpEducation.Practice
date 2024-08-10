namespace Practice2.Task6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      {
        string str = "test";
        char desiredSymbol = 't';

        double count = 0;

        foreach (char s in str)
        {
          if (s == desiredSymbol)
          {
            count++;
          }
        }

        Console.WriteLine($"{(count / str.Length) * 100}%");
      }

      {
        Console.WriteLine("Введите произвольную строку");
        string str = Console.ReadLine();

        Console.WriteLine("Введите искомый символ");
        char desiredSymbol = char.Parse(Console.ReadLine()); 

        double count = 0;

        foreach (char s in str)
        {
          if (s == desiredSymbol)
          {
            count++;
          }
        }

        Console.WriteLine($"{(count / str.Length) * 100}%");
      }

      {        
        string str = args[0];      
        char desiredSymbol = char.Parse(args[1]);

        double count = 0;

        foreach (char s in str)
        {
          if (s == desiredSymbol)
          {
            count++;
          }
        }

        Console.WriteLine($"{(count / str.Length) * 100}%");
      }

    }
  }
}
