namespace Practice4.Task3
{
  public class Person
  {
    public string name;
    public int age;

    public Person(string name, int age)
    {
      this.name = name;
      this.age = age;
    }

    public string GetInfo()
    {
      return $"Имя: {this.name}, возраст: {this.age}";
    }
  }
}
