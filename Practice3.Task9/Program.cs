namespace Practice3.Task9
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student tom = new Student("Tom");
      Console.WriteLine(tom.name);

      Student.ChangeNameToAnonymous(tom);
      Console.WriteLine(tom.name);
    }
  }
}
