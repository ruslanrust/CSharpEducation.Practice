namespace Practice2.Task23
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите год: ");

      int year = int.Parse(Console.ReadLine());

      if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
      {
        Console.WriteLine("Високосный!");
      }
      else
      {
        Console.WriteLine("Невисокосный");
      }
    }
  }
}
