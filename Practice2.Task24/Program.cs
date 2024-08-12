namespace Practice2.Task24
{
  internal class Program
  {
    static void Main(string[] args)
    {
      foreach (Weekday weekday in Enum.GetValues(typeof(Weekday)))
      {
        Console.WriteLine(weekday);
      }
    }
    enum Weekday
    {
      Monday,
      Tuesday,
      Wednesday,
      Thursday,
      Friday,
      Saturday,
      Sunday
    }
  }
}
