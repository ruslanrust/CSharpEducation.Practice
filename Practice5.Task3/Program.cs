namespace Practice5.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Dog dog = new Dog("Dog", 3);
      dog.MakeSound();

      Cat cat = new Cat("Cat", 5);
      cat.MakeSound();

      Parrot parrot = new Parrot("Parrot", 2, "yellow");
      parrot.MakeSound();
      parrot.MakeSound("keesha");

      IFlyable[] birds = new IFlyable[] { parrot, new Eagle()};

      foreach( IFlyable bird in birds )
      {
        bird.Fly();
      }
    }
  }
}
