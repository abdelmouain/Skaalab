namespace Skaalab_Exercise2.Models;
public class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set;}

    public List<Course> Courses { get; set; }
}