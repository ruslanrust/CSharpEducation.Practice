namespace Practice2.Task21
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int lowerLimit = 1;
      int upperLimit = 100;
      int hiddenNum = new Random().Next(lowerLimit, upperLimit);

      Console.Write($"Попробуйте угадать загаданное число от {lowerLimit} до {upperLimit}: ");

      int answer = int.Parse(Console.ReadLine());

      if (answer == hiddenNum)
      {
        Console.WriteLine("Угадали!");
      }
      else
      {
        Console.WriteLine("Не угадали!");
      }
      
    }
  }
}
