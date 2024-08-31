namespace Practice5.Task1
{
  internal class Contractor : Employee
  {
    public int HourlyRate { get; set; }

    public Contractor(string name, int hourlyRate) 
      : base(name)
    {
      this.HourlyRate = hourlyRate;
    }
    public int CalculateBonus(int hoursWorked)
    {
      return hoursWorked * this.HourlyRate;
    }

  }
}
