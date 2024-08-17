namespace Practice3.Task4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Book warAndPeace = new Book();
      Book shogun = new Book("Сёгун", "Джеймс Клавелл");

      Console.WriteLine(warAndPeace.title);
      Console.WriteLine(warAndPeace.author);
      Console.WriteLine(shogun.title);
      Console.WriteLine(shogun.author);
    }
  }
}
