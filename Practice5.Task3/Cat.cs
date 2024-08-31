namespace Practice5.Task3
{
  internal class Cat : Animal
  {
    public Cat(string name, int age) : base(name, age)
    {
      Console.WriteLine($"Cat {name} was born");
    }

    public override void MakeSound()
    {
      Console.WriteLine("Meow!");
    }
  }
}
