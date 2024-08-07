using System.Security.Cryptography.X509Certificates;

namespace Practice3.Task2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student brain = new Student();
      Console.WriteLine(brain.name);
      Console.WriteLine(brain.age);
      Console.WriteLine(brain.averageScore);

      brain.AverageScore = 2;
      Console.WriteLine(brain.averageScore);

    }

  }
}
