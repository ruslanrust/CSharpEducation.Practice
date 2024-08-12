namespace Practice2.Task25
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите номер дня недели: ");
      int dayNumber = int.Parse(Console.ReadLine());

      switch ((Weekday)dayNumber - 1)
      {
        case Weekday.Monday:
          Console.WriteLine("Это понедельник");
          break;
        case Weekday.Tuesday:
          Console.WriteLine("Это вторник");
          break;
        case Weekday.Wednesday:
          Console.WriteLine("Это среда");
          break;
        case Weekday.Thursday:
          Console.WriteLine("Это четверг");
          break;
        case Weekday.Friday:
          Console.WriteLine("Это пятница");
          break;
        case Weekday.Saturday:
          Console.WriteLine("Это суббота");
          break;
        case Weekday.Sunday:
          Console.WriteLine("Это понедельник");   
          break;
        default: 
          Console.WriteLine("Нет такого дня");
          break ;
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
