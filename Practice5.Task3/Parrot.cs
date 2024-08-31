﻿namespace Practice5.Task3
{
  internal class Parrot : Animal, IFlyable
  {
    public string Color { get; set; }

    public Parrot(string name, int age, string color) : base(name, age)
    {
      this.Color = color;
    }

    public new void MakeSound()
    {
      Console.WriteLine("Parrot is talking");
    }

    public void MakeSound(string words)
    {
      Console.WriteLine($"{words} {words} {words}");
    }

    public void Fly()
    {
      Console.WriteLine("Parrot is flying");
    }
  }
}
