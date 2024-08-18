namespace Practice3.Task9
{
  public class Student
  {
    public string name;
    public int age;

    public Student(string name)
    {
      this.name = name;
    }
    public static void ChangeNameToAnonymous(Student student)
    {
      student.name = "Anonymous";
    }
  }
}
