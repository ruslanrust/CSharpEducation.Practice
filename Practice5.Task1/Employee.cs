namespace Practice5.Task1
{
  public class Employee
  {
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(string name)
    {
      this.Name = name;
    }
    public Employee(string name, int salary) 
    {
      this.Name = name;
      this.Salary = salary;
    }

    public virtual double CalculateBonus()
    {
      return this.Salary * 0.1;
    }
  }
}




