namespace Practice3.Task10
{
  public class Car
  {
    public string brand;

    public Car(string brand)
    {
      this.brand = brand;
    }
    public static void PrintBrand(Car car)
    {
      Console.WriteLine("Марка: " + car.brand);
    }
  }
}
