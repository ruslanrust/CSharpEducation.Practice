using System;

namespace Practice3.Task1
{
  public class Student
  {
    public string name;
    public int age;

    public void PrintInfo()
    {
      Console.WriteLine($"Имя: {name}, возраст: {age}");
    }
  }
}
