namespace Practice3.Task11
{
  public class Book
  {
    public string title;
    public string author;

    public Book(string title, string author)
    {
      this.title = title;
      this.author = author;
    }

    public static void PrintInfo(Book book)
    {
      Console.WriteLine($"Название: {book.title}, автор: {book.author}");
    }
  }
}
