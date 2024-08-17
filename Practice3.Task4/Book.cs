using System;

namespace Practice3.Task4
{
  public class Book
  {
    public string title;
    public string author;

    public Book()
    {
      this.title = "Война и мир";
      this.author = "Лев Толстой";
    }

    public Book(string title, string author)
    {
      this.title = title;
      this.author = author;
    }

  }
}
