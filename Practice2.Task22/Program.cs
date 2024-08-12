namespace Practice2.Task22
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int lowerLimit = 1;
      int upperLimit = 100;
      int hiddenNum = new Random().Next(lowerLimit, upperLimit);

      Console.Write($"Попробуйте угадать загаданное число от {lowerLimit} до {upperLimit}: ");
      int attempt = 1;

      while (attempt <= 5)
      {
        int answer = int.Parse(Console.ReadLine());

        if (answer == hiddenNum)
        {
          Console.WriteLine($"Угадали! Кол-во попыток: {attempt}");
          return;
        }
        else if (answer < hiddenNum)
        {
          Console.WriteLine("Загаданное число больше предположенного");
        }
        else if (answer > hiddenNum)
        {
          Console.WriteLine("Загаданное число меньше предположенного");
        }
        
        attempt += 1;
      }

      Console.WriteLine("Не угадали, попыток больше нет!");
    }
  }
}
