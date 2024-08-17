namespace Practice3.Task5
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Book book1 = new Book();
      book1.PrintInfo();

      Book book2 = new Book("Война и мир");
      book2.PrintInfo();

      Book book3 = new Book("Война и мир", "Лев Толстой");
      book3.PrintInfo();

      Book book4 = new Book("Война и мир", "Лев Толстой", 1869);
      book4.PrintInfo();

    }
  }
}
