namespace Practice5.Task3
{
  internal class Dog : Animal
  {
    public Dog(string name, int age) : base(name, age)
    {
      Console.WriteLine($"Dog {name} was born");
    }

    public override void MakeSound()
    {
      Console.WriteLine("Woof!");
    }
  }
}
