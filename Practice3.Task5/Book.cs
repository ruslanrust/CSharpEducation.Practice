﻿using System.Reflection;
using System.Xml.Linq;

namespace Practice3.Task5
{
  public class Book
  {
    public string title;
    public string author;
    public int yearOfPublication;

    public Book() : this("Unknown title", "Unknown author", 0) { }
   
    public Book(string title) : this(title, "Unknown author", 0) { }

    public Book(string title, string author) : this(title, author, 0) { }

    public Book(string title, string author, int yearOfPublication)
    {
      this.title = title;
      this.author = author;
      this.yearOfPublication = yearOfPublication;
    }
    public void PrintInfo()
    {
      Console.WriteLine($"Название: {this.title}, автор: {this.author}, год публикации: {this.yearOfPublication}");
    }
  }
}
