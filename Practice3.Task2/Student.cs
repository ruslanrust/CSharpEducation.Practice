using System;

namespace Practice3.Task2
{
  internal class Student
  {
    public string name;
    public int age;
    public double averageScore;

    public double AverageScore
    {
      get
      {
        return this.averageScore;
      }

      set
      {
        if (value >= 0 && value <= 5)
        {
          this.averageScore = value;
        }
        else
        {
          throw new ArgumentException("Средний балл должен быть от 0 до 5");
        }
      }
    }
  }
}
