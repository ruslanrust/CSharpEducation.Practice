namespace Practice3.Task7
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(CalculateDaysInMonth(Month.Jule));     
    }

    static int CalculateDaysInMonth(Month month)
    {
      switch (month)
      {
        case Month.January:
        case Month.March:
        case Month.May:
        case Month.Jule:
        case Month.August:
        case Month.October:
        case Month.December:
          return 31;

        case Month.April:
        case Month.June:
        case Month.September:
        case Month.November:
          return 30;

        case Month.February:
          return 28;

        default:
          return 0;
      }
      
    }
  }
}
