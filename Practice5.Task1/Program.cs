using Practice5.Task2;

namespace Practice5.Task1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Employee klark = new Employee("Klark", 100);
      Manager john = new Manager("John", 100, 4);
      Manager david = new Manager("David", 100, 6);
      Contractor bestContractor = new Contractor("BestContractor", 5);

      Console.WriteLine(klark.CalculateBonus());
      Console.WriteLine(john.CalculateBonus());
      Console.WriteLine(david.CalculateBonus());
      Console.WriteLine(bestContractor.CalculateBonus(5));

      ConsoleLogger consoleLogger = new ConsoleLogger();
      consoleLogger.Log("test message", ILogger.LogLevel.Info);

      FileLogger fileLogger = new FileLogger();
      fileLogger.Log("test message for file", ILogger.LogLevel.Trace);

    }
  }
}
