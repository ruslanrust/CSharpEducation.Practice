namespace Practice5.Task1
{
  internal class Manager : Employee
  {
    public int TeamSize { get; set; }

    public Manager(string name, int salary, int teamsize)
      :base(name, salary) 
    {
      this.TeamSize = teamsize;
    }

    public override double CalculateBonus()
    {
      double bonus = this.TeamSize > 5 ? 0.25 : 0.2;
      
      return this.Salary * bonus;
    }

  }
}
